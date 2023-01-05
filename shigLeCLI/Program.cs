using Spectre.Console;

namespace shigLeCLI;

internal class Program
{
    static void Main(string[] args)
    {
        Table table = new Table();

        table.AddColumn("name");
        table.AddColumn("hoge2");
        table.AddRow("foo", "bar");
        table.AddRow("foo2", "bar2");

        AnsiConsole.Write(table);
    }
}