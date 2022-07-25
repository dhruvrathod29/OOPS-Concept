using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    class MethodTypes
    {
        // Get Something Retun Nothig
        public void sum1(int a, int b)
        {
            int ans = a + b;
            Console.WriteLine(ans);
        } 

        //Get Nothing Return Something
        public int sum2()
        {
            int ans = 2 + 3;
            return ans;

        }

        // Get Nothing Return Nothing
        public void sum3()
        {
            int ans = 2 + 3;
            Console.WriteLine(ans);
        }

        //Get Something Return Something
        public int sum4(int a , int b)
        {
            int ans = a + b;
            return ans; 
        }

    }

    public class MethodTypesDemo
    {
        public static void Main()
        {
            MethodTypes mt = new MethodTypes();
            int a = 2;
            int b = 3;
            mt.sum1(a, b);


           int ans1 = mt.sum2();
           Console.WriteLine(ans1);

            mt.sum3();

            int ans2 = mt.sum4(a, b);
            Console.WriteLine(ans2);

            


        }
    }
}
