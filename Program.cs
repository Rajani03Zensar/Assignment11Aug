using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLib;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//PublicKeyToken=6ce49746132bacb4
namespace CalculatorConsole
{
    [Serializable]
    class Program
    {
        static void Main(string[] args)
        {
            Calculate cal = new Calculate();
            FileStream fs = new FileStream("calculator.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, cal);
            Console.WriteLine("Data Serialized");
            Console.Read();
        }
    }
}
