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
           //PieTime pieUp = new PieTime();
           //int modMe = pieUp.Pie(1,4);
          // Console.WriteLine(modMe);
           {  
          int n, i, m=0, flag=0;    
          Console.Write("Enter the Number to check Prime: ");    
          n = int.Parse(Console.ReadLine());  
          m=n/2;    
          for(i = 2; i <= m; i++)    
          {    
           if(n % i == 0)    
            {    
             Console.Write("Number is not Prime.");    
             flag=1;    
             break;    
            }    
          }    
          if (flag==0)    
           Console.Write("Number is Prime.");       
     }  
       

          
            
        }
    }
}
