using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Calculator6
{
    static void Main6()
    {
        string expression = "70+82*79-78+84/73+83";
        Console.WriteLine($"= {expression}");
        var result = GetResult(expression);
        Console.WriteLine($"= {result}");
        Console.WriteLine("The result of the expression '{0}' is: {1}", expression, result);
        Console.ReadKey();
    }

    static decimal GetResult(string input)
    {
        bool IsNegative = false;
        int oIndex = 0;
        List<decimal> numbers = new List<decimal>();
        List<string> operators = new List<string>();

        foreach (Match match in Regex.Matches(input, @"(\d+)|([+\-*/])"))
        {
            if (match.Groups[1].Success)
            {
                var value = decimal.Parse(match.Value);
                if (IsNegative)//
                {
                    value = -value;
                    IsNegative = false;
                }//
                numbers.Add(value);
            }
            if (match.Groups[2].Success)
            {
                operators.Add(match.Value);
                if (match.Value.Contains('-'))//
                {
                    IsNegative = true;
                }//
            }
        }
        foreach (var item in operators)
        {
            if (item.Contains('*'))
            {
                var multiply = numbers[oIndex] * numbers[oIndex + 1];
                input = input.Replace($"{numbers[oIndex]}*{numbers[oIndex + 1]}", multiply.ToString());
                Console.WriteLine($"= {input}");
                numbers[oIndex + 1] = multiply;
                numbers[oIndex] = 0;
            }
            if (item.Contains('/'))
            {
                var divide = numbers[oIndex] / numbers[oIndex + 1];
                input = input.Replace($"{numbers[oIndex]}/{numbers[oIndex + 1]}", divide.ToString());
                Console.WriteLine($"= {input}");
                numbers[oIndex + 1] = divide;
                numbers[oIndex] = 0;
            }
            oIndex++;
        }
        return numbers.Sum();
    }
}
