using System;

namespace piechallengecshap
{
    class pieTime
    {
        public void pieUp(int pieEaters, int slicesEaten)
        {
            int workOut = pieEaters% slicesEaten;
           if (workOut==0)
           Console.WriteLine("enough for everyone");
           else
           Console.WriteLine("not enough slices sorry");

        }
    }





    
}