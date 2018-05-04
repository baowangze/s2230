using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue("A");//添加元素
            q.Enqueue("M");
            q.Enqueue("G");
            q.Enqueue("W");
            Console.WriteLine("currrent quueue:");//Amgw
            foreach (char  c in q)
            {
                Console.WriteLine(c+"  ");
                Console.WriteLine( );
                q.Enqueue('v');
                q.Enqueue('h');
                Console.WriteLine("Current queue:");//AMGWVH
                foreach (char l in q)
                {
                    Console.WriteLine(c+" ");
                    Console.WriteLine();
                    Console.WriteLine("Removing quueue:");
                    char ch = (char)q.Dequeue();//移除元素
                    Console.WriteLine("The removed value:{0}",ch);//a
                    ch = (char)q.Dequeue();
                    Console.WriteLine("the removed value :{0}",ch);//m
                }
            }
        }
    }
}
