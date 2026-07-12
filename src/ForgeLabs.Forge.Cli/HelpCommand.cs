using System;

internal static class HelpCommand
{
    public static int Execute()
    {
        Console.WriteLine("Forge Engineering Toolkit");
        Console.WriteLine();
        Console.WriteLine("Repository-native engineering platform for humans and AI.");
        Console.WriteLine();
        Console.WriteLine("Usage");
        Console.WriteLine("  forge [command]");
        Console.WriteLine();
        Console.WriteLine("Commands");
        Console.WriteLine("  doctor        Validate the local development environment");
        Console.WriteLine("  help          Display this help information");
        Console.WriteLine();
        Console.WriteLine("Options");
        Console.WriteLine("  --help        Display this help information");
        Console.WriteLine("  --version     Display version information");
        Console.WriteLine();
        Console.WriteLine("Documentation");
        Console.WriteLine("  See the repository documentation under the docs/ directory.");

        return 0;
    }
}
