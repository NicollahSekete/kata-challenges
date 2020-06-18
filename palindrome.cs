using System;

namespace piechallengecshap{

    class Palindome{
        public void palin()
        {
            int a,r,sum=0,temp;    
          Console.Write("Enter the Number: ");   
          a = int.Parse(Console.ReadLine());  
          temp=a;      
          while(a>0)      
          {      
           r=a%10;      
           sum=(sum*10)+r;      
           a=a/10;      
          }      
          if(temp==sum)      
           Console.Write("Number is Palindrome.");      
          else      
           Console.Write("Number is not Palindrome");   

        }
    
    }


}