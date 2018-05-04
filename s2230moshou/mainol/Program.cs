

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace mainol
{
    class Program
    {
        static void Main(string[] args)
        {
            ReanDataFromFile();
            //WriteToFile();
            Console.ReadKey();
        }

        private static void ReanDataFromFile()
        {
            FileStream fs = new FileStream("E:\\晚自习.Txt", FileMode.Open);
            //2.创建一个写入器
            StreamReader sr = new StreamReader(fs);
            //3.读取操作
            string wordes = sr.ReadToEnd();
            //遍历
            Console.WriteLine(wordes);
            //4.关闭读取器
            sr.Close();
            fs.Close();
            Console.WriteLine("成功");
        }

        private static void WriteToFile()
        {

            FileStream fs = new FileStream("E:\\晚自习.Txt", FileMode.Open);
            //创建读取器
            StreamWriter sw = new StreamWriter(fs);
            //3真正的写入
            sw.WriteLine("hello word");
            //4.关闭写入器
            sw.Close();
            fs.Close();
            Console.WriteLine("成功");
        }
    }
}
