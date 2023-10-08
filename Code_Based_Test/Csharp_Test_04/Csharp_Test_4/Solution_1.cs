using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace CSharp_Test_4
{
    class Sol
    {
        static void Main()
        {
            string filePath = @"D:\Assignment\Code_Based_Test\Csharp_Test_4\Csharp_Test_4.txt";

            string textToAppend = "C_Sharp_test 4";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {

                writer.WriteLine(textToAppend);          // Append text to the file
                writer.Close();
            }
            Console.WriteLine("Text has been appended successfully!.");
            Console.ReadLine();
        }
    }
}