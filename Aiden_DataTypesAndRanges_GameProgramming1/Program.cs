using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aiden_DataTypesAndRanges_GameProgramming1
{
    internal class Program
    {
        static int intExample = -2147483648;
        static uint uintExample = 0;
        static short shortExample = -32768;
        static ushort ushortExample = 0;

        static void IntExampleText()
        {
            Console.WriteLine($"An int is an integer, hence the name. The smallest number you can have with an int is {intExample}\nand the biggest number is {intExample = 2147483647}");
            Console.ReadKey();
            Console.WriteLine($"The smallest number you can have with a uint is: {uintExample}\nThe biggest number you can have with a uint is: {uintExample = 4294967295}");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"uint stands for unsigned int, which means the value cannot be negative.");
            Console.ReadKey();
            Console.WriteLine("This also means that the maximum of uint is double the maximum value of int (plus one because the negative number inside of signed variables is one more than the positive numbers)");
            Console.ReadKey();
            Console.Clear();
        }

        static void ShortExampleText()
        {
            Console.WriteLine($"The smallest number you can have with a short is: {shortExample}\nThe biggest number you can have with a uint is: {shortExample = 32767}");
            Console.ReadKey();
            Console.WriteLine($"A ushort has the same differences with a short as uint has with int, so smallest number you can have with a ushort is: {ushortExample}\nThe biggest number you can have with a ushort is: {ushortExample = 65535}");
            Console.ReadKey();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            IntExampleText();
            ShortExampleText();

            
        }
    }
}
