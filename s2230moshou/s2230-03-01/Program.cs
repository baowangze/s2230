using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2230_03_01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 01增删改查
            ////定义一个容器保存
            //ArrayList lis = new ArrayList();
            //lis.Add("牡丹");
            //lis.Add("菊花");
            //lis.Add("桃花");
            ////遍历
            //foreach (var item in lis)
            //{
            //    Console.WriteLine(item);
            //}
            ////删除
            //lis.Remove("菊花");
            //lis.RemoveAt(1);//按照下标 来进行删除
            ////修改
            //lis[0] = "牡丹花";  //修改直接赋值
            //Console.WriteLine("============================");
            //foreach (var item in lis)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey(); 
            #endregion
            #region 简介语6言
            //ArrayList lis = new ArrayList()
            //{
            //new book (){BookName = "红楼梦"},
            //new book () { BookName = "西游记"}, 
            //new book() { BookName = "水浒传" },
            //};
            //foreach (book item in lis)
            //{
            //    Console.WriteLine(item.BookName);
            //}
            #endregion
            #region 同时调用key  和value 
     
           
            //Hashtable tabe = new Hashtable();
            //tabe.Add(1, 3);
            //tabe.Add(2, 4);
            //tabe.Add(3, 6);
            //foreach (DictionaryEntry item in tabe)   //调用DictionaryEntry
            //{
            //    Console.WriteLine(item.Key + "\t" + item.Value);
            //}
        #endregion
            #region MyRegion
        //SizeClass sizeClass = new SizeClass() { Width = 10, Length = 10 };
        //Console.WriteLine("赋值前：width={0},length={1}", sizeClass.Width, sizeClass.Length);

        //var copyOfSizeClass = sizeClass;
        //copyOfSizeClass.Length = 5;
        //copyOfSizeClass.Width = 5;
        //Console.WriteLine("赋值后：width={0},length={1}", sizeClass.Width, sizeClass.Length);
        //Console.ReadKey();
        #endregion
            #region 三种遍历
            //Dictionary<string, book> dic = new Dictionary<string, book>();
            //book bo = new book();
            //bo.BookName = "红楼梦";
            //bo.BookAge = 32;
            //dic.Add(bo.BookName,bo);
            //foreach (string  key in dic.Keys)
            //{
            //    Console.WriteLine(key+"\t"+dic[key]);
            //}
            #endregion
            #region 自定义泛型
            MyGent<int>list = new MyGent<int>();
            list.r = 2;
            #endregion
            Console.ReadKey(); 

        }
        public class SizeClass
        {
            public int Width { get; set; }
            public int Length { get; set; }
        }


        public struct SizeStruct
        {
            public int Width { get; set; }
            public int Length { get; set; }
        }
    }
}
