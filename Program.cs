using Mylibrary;
using System;
namespace program;
public class program00{
    static void Main(){

        Console.Write("Geben sie eine Binaerzahl ein:");
        string binary = Console.ReadLine();
        int dec_value = Class1.Binary_converter(binary);
        Console.WriteLine(dec_value);
    }
}