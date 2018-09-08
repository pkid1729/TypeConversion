using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = "123456";
            int i = Convert.ToInt32(number);
            Console.WriteLine(i);
           
            try
            {
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {

                Console.WriteLine("The numer could not be converted into byte");
            }
            try
            {
                string str = "true";
                bool bo = Convert.ToBoolean(str);
                Console.WriteLine(bo);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
