using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
     class Countru
     {
        int a, b;
        public Countru()
        {
            Console.WriteLine("Welcome to the Default Countru");

        }
        public Countru(int a1, int b1) // Perameterize Constructore
        {
            a = a1;
            b = b1; 
        }
        public void sum()
        {
            int ans = a + b; 
            Console.WriteLine(ans); 
        }
        public void sub()
        {
            int ans = a - b;
            Console.WriteLine(ans);

        }
        public void mul()
        {
            int ans = a * b;
            Console.WriteLine(ans);

        }
        
        public void divi()
        {
            int ans = a / b;
            Console.WriteLine(ans);
        }
        

     }

    public class CountruDemo
    {
        public static void Main()
        {
            Countru co = new Countru(); // Default
            Countru co1 = new Countru(3,2);
            co1.sum();
            co1.sub();
            co1.mul();
            co1.divi();

        }
    }
}
