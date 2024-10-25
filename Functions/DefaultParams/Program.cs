using System;

void PrintWithPrefix(string thestr, string prefix="")
{
    Console.WriteLine($"{prefix} {thestr}");
}

PrintWithPrefix("Hello there!");
PrintWithPrefix("Hello there!", ">: ");

PrintWithPrefix(prefix: "% ", thestr: "Hello there!");
