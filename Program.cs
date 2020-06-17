using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Create("J:\\new_file.txt");
            File.WriteAllText("J:\\new_file.txt", "текст");
            File.AppendAllText("J:\\new_file.txt", "текст метода AppendAllText ()");
            File.Delete("J:\\test.txt");

            FileStream file1 = new FileStream("J:test.txt", FileMode.Open);

        }
    }
}
