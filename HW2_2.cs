using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW1week2
{
    class Mydata
    {
        public int year;
        public int mounth;
        public int day;

        public void printdata()
        {
            Console.Write("{0}/{1}/{2}",year,mounth,day);
        }
        public int isYear()//�P�_�|�~1�B���~0
        {
            if (year % 4 == 0 && year % 100 > 0)
                return 1;


            else if (year % 400 == 0)
                return 1;
            else
                return 0;
        }
        public int isYear(int a)//�P�_�|�~1�B���~0
        {
            if (a % 4 == 0 && a % 100 > 0)
                return 1;


            else if (a % 400 == 0)
                return 1;
            else
                return 0;
        }
        public int isMounth()//�P�_���w������X��
        {
            int yeardata = isYear();
            for (int i = 1; i < 8; i++)//�P�_1~7��
            {
                if (i % 2 == 1 && mounth == i)
                    return 31;
                if (i % 2 == 0 && mounth == i && mounth != 2)
                    return 30;
                if (i % 2 == 0 && mounth == i && mounth == 2)
                {
                    if (yeardata == 1)
                        return 29;

                    else
                        return 28;
                }
            }
            for (int i = 8; i < 13; i++) //�P�_8~12��
            {
                if (i % 2 == 0 && mounth == i)
                    return 31;
                if (i % 2 == 1 && mounth == i)
                    return 30;
            }
            return 0;
        }
        public int isMounth(int a, int b)//�P�_���w������X��
        {
            a = isYear(a);
            for (int i = 1; i < 8; i++)//�P�_1~7��
            {
                if (i % 2 == 1 && b == i)
                    return 31;
                if (i % 2 == 0 && b == i && b != 2)
                    return 30;
                if (i % 2 == 0 && b == i && b == 2)
                {
                    if (a == 1)
                        return 29;

                    else
                        return 28;
                }
            }
            for (int i = 8; i < 13; i++) //�P�_8~12��
            {
                if (i % 2 == 0 && b == i)
                    return 31;
                if (i % 2 == 1 && b == i)
                    return 30;
            }
            return 0;
        }
        public Boolean isTrueDay()
        {
            if (year < -1 || year == 0 || mounth > 12 || mounth < 1)
                return false;

            else if (day < 1 || day > isMounth())
                return false;

            else
                return true;
        }
        public int isDay()//�P�_���w������
        {
            int nadd = 0;
            //2014�����P��3    2014/2/26/3
            int inishoDay = 3;

            //�P�_+-�X�~
            if (year == 2014)
            {
                nadd = 0;
            }
            else if (year > 2014)
            {
                for (int i = 2014; i < year; i++)
                {
                    if (isYear(i) != 0)
                    {
                        nadd += 2; //�|�~+2
                    }
                    else
                    {
                        nadd += 1; //���~ +1
                    }
                }
            }
            else
            {
                for (int i = 2013; i >= year; i--)
                {
                    if (isYear(i) != 0)
                        nadd -= 2;
                    else
                        nadd -= 1;
                }
            }
            //if end

            //�p��Ӧ~�����O�P���XinishoDay:0~6
            inishoDay = (inishoDay + nadd) % 7;
            if (inishoDay < 0)
                inishoDay += 7;
            //�p��Ӥ몺�Ĥ@�ѬO�P���X
            nadd = 0;
            for (int i = 1; i < mounth; i++)
            {
                if (i == mounth)
                    break;
                nadd += isMounth(year, i);
            }
            //�p��Ӥ�1��O�P���X
            inishoDay = (inishoDay + nadd) % 7;
            //�p��Ӥ�__��O�P���X
            inishoDay = (inishoDay + day - 1) % 7;
            if (inishoDay == 0)
                return 7;
            else if (inishoDay >= 1 && inishoDay <= 7)
                return inishoDay;
            else
                return 0;

        }
    }
}
