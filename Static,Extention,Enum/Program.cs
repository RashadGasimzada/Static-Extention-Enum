using System;
using Static_Extention_Enum.Helpers;
namespace Static_Extention_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Salam Rashad,necesen Rashad";
            int result = str.StringCheck("Rashad");
            Console.WriteLine(result);
        }
    }
}
