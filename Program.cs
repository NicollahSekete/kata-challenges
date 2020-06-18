using System;

namespace piechallengecshap
{
    class PieTime
    {
       public void Pie(int pieEaters,int slicesEaten)
       {
           var workOut = pieEaters% slicesEaten;
           if (workOut==0)
           Console.WriteLine("enough for everyone");
           else
           Console.WriteLine("not enough slices sorry");
                   
             
       }
    }
        
    class Program
    {
        static void Main(string[] args)
        {

               Prime findPrime = new Prime();
               findPrime.primeNumber();

               Palindome findPalindome = new Palindome();
               findPalindome.palin();
        }
           
            
            
        }
    }

