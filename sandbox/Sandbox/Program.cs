using System;
using System.Text.RegularExpressions;

public class Program
{
    static void Main(string[] args)
    {
        string tar = "taravarmehar";
        string replaced = Regex.Replace(tar, @"([a-z])", "_");
        Console.WriteLine(replaced);
        Console.WriteLine(tar);
    }
}