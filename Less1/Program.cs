using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ConvertingToInt
            /*
            string str = "55757546";
            int num1 = Convert.ToInt32(str);

            Console.WriteLine(num1 + 10);
            */
            #endregion

            #region ConvertingToString
            /*
            int num2 = 895;
            string str2 = Convert.ToString(num2);

            Console.WriteLine(str2 + 100);
            */
            #endregion

            #region Concatenation 
            /*
            string text = Console.ReadLine();
            Console.WriteLine("Ну здарова, " + text + "!");
            */
            #endregion

            #region IfElse 
            /*
            string thisText;
            thisText = Console.ReadLine();

            if (thisText == "Антошка")
            {
                Console.WriteLine("Ну здарова, " + thisText + "!");
            }
            else
            {
                Console.WriteLine("Добро пожаловать, " + thisText + "!");
            }
            */
            #endregion

            #region MyRegion TaskCycle
            /*
            string symbol = ".";
            string res;
            string text = "Привет";
            int i = 0;

            for (; i < 10; i++)
            {
                //Оба способа работают
                text += symbol;
                //Console.WriteLine(text = text + symbol, text);
                Console.WriteLine(text);
            } 
             */
            #endregion

            Console.ReadKey();
        }
    }
}
