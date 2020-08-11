using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;



namespace CalculatorLib
{
    [Serializable]
    public class Calculate
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int Addition()
        {
            return num1 + num2;
        }
        public int Subtract()
        {
            return num1 - num2;
        }
        public int Multiply()
        {
            return num1 * num2;
        }
        public double Divide()
        {
            return num1 / num2;
        }
       
    }
    
}
