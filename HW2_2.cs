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
        public int isYear()//判斷閏年1、平年0
        {
            if (year % 4 == 0 && year % 100 > 0)
                return 1;


            else if (year % 400 == 0)
                return 1;
            else
                return 0;
        }
        public int isYear(int a)//判斷閏年1、平年0
        {
            if (a % 4 == 0 && a % 100 > 0)
                return 1;


            else if (a % 400 == 0)
                return 1;
            else
                return 0;
        }
        public int isMounth()//判斷指定月份有幾天
        {
            int yeardata = isYear();
            for (int i = 1; i < 8; i++)//判斷1~7月
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
            for (int i = 8; i < 13; i++) //判斷8~12月
            {
                if (i % 2 == 0 && mounth == i)
                    return 31;
                if (i % 2 == 1 && mounth == i)
                    return 30;
            }
            return 0;
        }
        public int isMounth(int a, int b)//判斷指定月份有幾天
        {
            a = isYear(a);
            for (int i = 1; i < 8; i++)//判斷1~7月
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
            for (int i = 8; i < 13; i++) //判斷8~12月
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
        public int isDay()//判斷指定月份日期
        {
            int nadd = 0;
            //2014元旦星期3    2014/2/26/3
            int inishoDay = 3;

            //判斷+-幾年
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
                        nadd += 2; //閏年+2
                    }
                    else
                    {
                        nadd += 1; //平年 +1
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

            //計算該年元旦是星期幾inishoDay:0~6
            inishoDay = (inishoDay + nadd) % 7;
            if (inishoDay < 0)
                inishoDay += 7;
            //計算該月的第一天是星期幾
            nadd = 0;
            for (int i = 1; i < mounth; i++)
            {
                if (i == mounth)
                    break;
                nadd += isMounth(year, i);
            }
            //計算該月1日是星期幾
            inishoDay = (inishoDay + nadd) % 7;
            //計算該月__日是星期幾
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
