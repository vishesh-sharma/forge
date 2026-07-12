using System.Diagnostics;

internal static class DoctorCommand
{
    public static int Execute()
    {
        bool dotnetSdkAvailable = TryRun("dotnet", ["--version"], out _);
        bool gitAvailable = TryRun("git", ["--version"], out _);
        bool gitRepository = TryRun("git", ["rev-parse", "--is-inside-work-tree"], out string repositoryOutput)
            && string.Equals(repositoryOutput.Trim(), "true", StringComparison.Ordinal);
        bool workingTreeClean = TryRun("git", ["status", "--porcelain"], out string statusOutput)
            && string.IsNullOrWhiteSpace(statusOutput);

        Console.WriteLine("Forge Doctor");
        Console.WriteLine();
        WriteCheck(".NET SDK", dotnetSdkAvailable, ".NET SDK check failed.");
        WriteCheck("Git", gitAvailable, "Git check failed.");
        WriteCheck("Git Repository", gitRepository, "Git repository check failed.");
        WriteCheck("Working Tree", workingTreeClean, "Working tree is not clean.");
        Console.WriteLine();

        bool healthy = dotnetSdkAvailable && gitAvailable && gitRepository && workingTreeClean;
        Console.WriteLine(healthy ? "Overall Status: HEALTHY" : "Overall Status: FAILED");

        return healthy ? 0 : 1;
    }

    private static bool TryRun(string fileName, string[] arguments, out string output)
    {
        output = string.Empty;

        try
        {
            using Process process = new();
            process.StartInfo.FileName = fileName;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;

            foreach (string argument in arguments)
            {
                process.StartInfo.ArgumentList.Add(argument);
            }

            process.Start();

            Task<string> standardOutput = process.StandardOutput.ReadToEndAsync();
            Task<string> standardError = process.StandardError.ReadToEndAsync();

            process.WaitForExit();
            output = standardOutput.GetAwaiter().GetResult();
            _ = standardError.GetAwaiter().GetResult();

            return process.ExitCode == 0;
        }
        catch (Exception)
        {
            return false;
        }
    }

    private static void WriteCheck(string name, bool passed, string failureMessage)
    {
        Console.WriteLine($"[{(passed ? "PASS" : "FAIL")}] {name}");

        if (!passed)
        {
            Console.WriteLine($"       {failureMessage}");
        }
    }
}
