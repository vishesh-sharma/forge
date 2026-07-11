string? command = args.Length > 0 ? args[0] : null;
int exitCode;

switch (command)
{
    case null:
        Console.WriteLine("========================================");
        Console.WriteLine("           Forge v0.1");
        Console.WriteLine("    Engineering Toolkit for ForgeLabs");
        Console.WriteLine("========================================");
        Console.WriteLine();
        Console.WriteLine("Initializing...");
        Console.WriteLine("Run 'forge --help' to see available commands.");
        exitCode = 0;
        break;
    case "--help":
        Console.WriteLine("Help is not yet implemented.");
        exitCode = 0;
        break;
    case "--version":
        Console.WriteLine("Version information is not yet implemented.");
        exitCode = 0;
        break;
    case "doctor":
        Console.WriteLine("Doctor is not yet implemented.");
        exitCode = 0;
        break;
    default:
        Console.WriteLine($"Unknown command: {command}");
        Console.WriteLine("Run 'forge --help' for available commands.");
        exitCode = 1;
        break;
}

return exitCode;
