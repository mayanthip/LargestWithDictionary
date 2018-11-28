using System;
using System.Collections.Generic;

namespace LargestwithDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var newNumDictionary = new Dictionary<int,int>();
            newNumDictionary.Add(1,10);
            newNumDictionary.Add(2,11);
            newNumDictionary.Add(3,24);
            newNumDictionary.Add(4,-5);
            newNumDictionary.Add(5,5100);
            newNumDictionary.Add(6,101);
       
       
       int largest=0;
       foreach(var entry in newNumDictionary )
       {
           if(entry.Value>largest)
           {
               largest=entry.Value;
           }
       }
       
       Console.WriteLine($"The largest number is {largest}",largest);
       Console.ReadKey();
       }
        
    }
}
