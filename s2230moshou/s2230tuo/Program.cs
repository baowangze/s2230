using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2230tuo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] points = new int[5];//历史记录数组
            int[] newPoints = new int[5];//新年积分数组 
            Console.WriteLine("请输入5位会员的积分");
            for (int i = 0; i < points.Length; i++)
            {
                Console.Write("第"+(i+1)+"位会员积分");//循环输出每次循环自加1
                points[i] = Convert.ToInt32(Console.ReadLine());
            }
            //数组赋值
            for (int i = 0; i < points.Length; i++)
            {
                newPoints[i] = points[i];
                newPoints[i] = newPoints[i] + 500;//赠送500积分
            }
            Console.WriteLine("\n序号   历史积分   新年积分");
            for (int i = 0; i < newPoints.Length; i++)
            {
                Console.WriteLine((i+1)+"\t"+points[i]+"\t\t"+newPoints[i]);
            }
            Console.ReadKey();
        }
    }
}
