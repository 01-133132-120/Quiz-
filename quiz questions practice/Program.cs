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
            Program obj = new Program();
            int[] arra =new int[] { 1, 2, 3 };
            obj.Swap();
            int ans=obj.Find(arra,3);
            Console.WriteLine("Ans is: {0} ", ans);
            Console.ReadLine();
        }
    }
}
