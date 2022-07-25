using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    internal class EncaptulationDemo
    {
        public static void Main()
        {
            Encaptulation en = new Encaptulation();
            en.SetA(2);
            int a = en.GetA();
            Console.WriteLine(a);

            Bank bank = new Bank();
            bank.SetTotal(100);
            int Total = bank.GetTotal();
            Console.WriteLine(Total);   
        }
    }

    class Encaptulation
    {
        private int a;

        public void SetA(int a1) // Set perameter pass kare
        {
            
            a = a1;

        }
        public int GetA() //Get return velue pass kare
        {
            return a;
        }

    }
    class Bank
    {
        private int Total;
        public void SetTotal(int val) // Set methods value set karva
        {
            if (val>0)
            {
                Total = val;

            }
            else
            {
                Console.WriteLine("Nagetive");
            }
        }

        public int GetTotal() // Get methods value get karva consol ma print karva
        {
            return Total;
        }
    }
}
