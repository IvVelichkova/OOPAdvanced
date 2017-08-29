using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator
{
   public class ListyIterator
   {
       private  List<string> collection;
       private int currentIndex = 0;

       public ListyIterator(params string[] element)
       {
           
           this.collection=new List<string>();
       }

       public void Add(params string[] element)
       {
           if (element.Length==0)
           {
               throw new Exception("Invalid Operation!");
           }
           else
           {
               foreach (var el in element)
               {
                   collection.Add(el);
               }
            }
          
       }

      
       public string Current => this.collection[currentIndex];
        
       
       public bool MoveNext() => this.currentIndex++ < this.collection.Count;

       public string Print()
       {
           return Current;
       }

       public bool HasNext()
       {
           if (++currentIndex<collection.Count)
           {
                return true;
           }
           return false;
       }

       public void Reset()
       {
           currentIndex = 0;
       }






   }

      
}
