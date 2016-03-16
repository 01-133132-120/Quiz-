using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_questions_practice
{
    class Program
    {
        public void Swap()//Function start
        {
            int num1 = 20;
            int num2 = 30;
            Console.WriteLine("Before Swaping");
            Console.WriteLine("NUM 1 : " +num1);
            Console.WriteLine("NUM 2  : " +num2);
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine("After Swaping");
            Console.WriteLine("NUM 1 : "+ num1);
            Console.WriteLine("NUM 2 : "+ num2);
            Console.ReadLine();
        }//Swap function end
        public static void swapref(ref int a,ref int b)//Start Swapping function with Reference
        {
            a= 20;
            b = 30;
            Console.WriteLine("Before Swapping Values are");
            Console.WriteLine("Value of num1 : " + a);
            Console.WriteLine("Value of num2 : " + b);
            Console.WriteLine("APPLYING SWAPPING");
            a = a + b;
            b= a - b;
           a = a - b;
           Console.WriteLine("After Swapping Values are ");
           Console.WriteLine("Value of num1 After Swappimg : " + a);
           Console.WriteLine("Value of num2 After Swapping : " + b);
           // Console.ReadLine();
           
        }//End of swapping fun
        public int Find( int []a,int b)//Start of find function
        {
          // b = 2;
            int i;
            for ( i = 0; i < a.Length; i++)//start for
            {
                if (a[i] == b)//start if
                {
                   return a[i];
                }//end if    
            }//end for
            return 0;   
        }//End of find functon
        static void Main(string[] args)
        {
            int x = 30, y = 30;
            Program obj = new Program();

            int[] arra =new int[] { 1, 2, 3 };
            //Simple swap function
            obj.Swap();
            //Find the value in Array
            int ans=obj.Find(arra,3);
            Console.WriteLine("Ans is: {0} ", ans);
            //Swapping function call With ref
           swapref(ref x,ref y);
           Console.WriteLine("Value With Reference "+  x);
           Console.WriteLine("second value with Reference "+ y);
            Console.ReadLine();
        }
    }
}
