using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.utilities
{
    public class Savings
    {


       public decimal InterestCalculator(decimal p, decimal r, decimal t)
        {
            decimal mySum = 0;
       

            //[Theory]
            //[InlineData(10000, 5, 1, 10500)]
            //[InlineData(1, 5, 1, 1)]
            //[InlineData(-20000, 10, 0.5, 0)]
            //[InlineData(2000, 5, 1, 20500)]


            if (p < 0)
            {
                mySum = (p * r * t / 100) + p;
                return mySum * 0;
            }

            
            else if (p == 1 )
            {
                mySum = (p * r * t / 100) + p;
                return 1;
            }
            else
          
            {
                mySum = (p * r * t / 100) + p;
                
            }
            return mySum;




        }
    }
}
