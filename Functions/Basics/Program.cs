using System;


float MilesToKm(float miles) {
    float result = miles * 1.6f;
    return result;
}

void PrintWithPrefix(string thestr) {
    Console.WriteLine($"::> {thestr}");
}

Console.WriteLine($"The result is {MilesToKm(8.0f)}");
Console.WriteLine($"The result is {MilesToKm(52.0f)}");

PrintWithPrefix("Test string");
PrintWithPrefix("Another test string");
