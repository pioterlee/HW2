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
                Console.WriteLine("��J�~��");
                input.year = int.Parse(Console.ReadLine());
                Console.WriteLine("��J���");
                input.mounth = int.Parse(Console.ReadLine());
                Console.WriteLine("��J���");
                input.day = int.Parse(Console.ReadLine());
                Console.WriteLine("*****************************************");
                if (!input.isTrueDay())
                {
                    Console.WriteLine("�п�J�X�k���", input.year);
                    Console.WriteLine("���@���~��");
                    Console.ReadLine();
                    continue;
                }
                if (input.isYear() == 1)
                {
                    Console.WriteLine("�~��{0}�~,���|�~", input.year);
                    Console.WriteLine("�~��{0}�~,��366��", input.year);
                }
                else if (input.year <= 0)
                    Console.WriteLine("�п�J�X�k�Ʀr -1 ���� or �j��0 ");
                else
                {
                    Console.WriteLine("�~��{0}�~,�����~", input.year);
                    Console.WriteLine("�~��{0}�~,��365��", input.year);
                }

                if(!input.isTrueDay())
                    Console.WriteLine("�п�J�X�k�Ʀr�C�~��>0�A���1~12");
                else 
                {
                    Console.WriteLine("{0}�~{1}�릳{2}��",input.year,input.mounth,input.isMounth());
                    input.printdata();
                    Console.WriteLine("���P��{0}", input.isDay());
                }
                Console.WriteLine("*****************************************");
                Console.WriteLine("�O�_�~��?(-1�����A���@���~��)");
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
