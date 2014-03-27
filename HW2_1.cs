using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW1week2
{
    class StartUp
    {
        static void Main(string[] args)
        {

            Mydata input=new Mydata();
            int chooese = -1;
            while (chooese != 0)
            {
                Console.Clear(); // Clear the screen
                Console.WriteLine("輸入年份");
                input.year = int.Parse(Console.ReadLine());
                Console.WriteLine("輸入月份");
                input.mounth = int.Parse(Console.ReadLine());
                Console.WriteLine("輸入日期");
                input.day = int.Parse(Console.ReadLine());
                Console.WriteLine("*****************************************");
                if (!input.isTrueDay())
                {
                    Console.WriteLine("請輸入合法日期", input.year);
                    Console.WriteLine("任一鍵繼續");
                    Console.ReadLine();
                    continue;
                }
                if (input.isYear() == 1)
                {
                    Console.WriteLine("年份{0}年,為閏年", input.year);
                    Console.WriteLine("年份{0}年,有366天", input.year);
                }
                else if (input.year <= 0)
                    Console.WriteLine("請輸入合法數字 -1 結束 or 大於0 ");
                else
                {
                    Console.WriteLine("年份{0}年,為平年", input.year);
                    Console.WriteLine("年份{0}年,有365天", input.year);
                }

                if(!input.isTrueDay())
                    Console.WriteLine("請輸入合法數字。年份>0，月份1~12");
                else 
                {
                    Console.WriteLine("{0}年{1}月有{2}天",input.year,input.mounth,input.isMounth());
                    input.printdata();
                    Console.WriteLine("為星期{0}", input.isDay());
                }
                Console.WriteLine("*****************************************");
                Console.WriteLine("是否繼續?(-1結束，任一鍵繼續)");
                Console.ReadLine();
                if (chooese == 0)
                    break;
                else 
                {
                    continue;
                }


             }
             Console.ReadLine();
        }                
    }
}
