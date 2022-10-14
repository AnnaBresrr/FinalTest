using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // string[] values = {"hello", "world", ":-)"};
         string[] values = {"1234", "1567", "-2", "computer science"};
        // string[] values = {"Russia", "Denmark", "Kazan"};

        string[] result = Array.FindAll(values, i => i.Length <= 3);

        foreach (string item in result) {
            Console.WriteLine(item);
        }
    }
}