using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInWords
{
    class Word
    {


        public string Transform(int number, int digitCount)
        {
            string res = "";// промежуточный результат
            string result = "";// окончательный результат
            int rest = 0;    // остаток от деления
            bool isThousand = false;
            bool isMillion = false;

            //если у нас двухзначное число и оно лежит в интервале от 10 до 19
            if (digitCount == 2 && number % 100 >= 10 && number % 100 <= 19)
            {
                res = First_Tens(number);
                result = result.Insert(0, res + " ");

            }
            else
            {
                //проходимся по всем разрядам начиная с меньшего
                for (int i = 0; i < digitCount; i++)
                {
                    //если два последних разряда, образовавши число, попадает в интервал от 10 до 19
                    if (number % 100 >= 10 && number % 100 <= 19 && (i == 0 || i == 3 || i == 6))
                    {

                        rest = number % 100;
                        if (i == 3)
                        {
                            res = First_Tens(rest);
                            result = result.Insert(0, res + " тысяч ");
                        }
                        if (i == 6)
                        {
                            res = First_Tens(rest);
                            result = result.Insert(0, res + " миллионов ");
                        }
                        else
                        {
                            First_Tens(rest);
                            result = result.Insert(0, res + "");

                        }
                        i++;
                        continue;
                    }
                    //получаем последний разряд числа
                    rest = number % 10;
                    //отбрасываем последний разряд от числа
                    number /= 10;
                    //если последний разряд числа не равен 0
                    if (rest != 0)
                    {
                        switch (i + 1)
                        {
                            case 1:
                                res = Units(rest);
                                result = result.Insert(0, res + " "); break;//единицы
                            case 2:
                                res = Tens(rest);
                                result = result.Insert(0, res + " "); break;//десятки
                            case 3:
                                res = Hundreds(rest);
                                result = result.Insert(0, res + " "); break;//сотни
                            case 4:
                                res = Thousands(rest);
                                result = result.Insert(0, res + " "); break;//тысячи
                            case 5:
                                res = Tens(rest);
                                result = result.Insert(0, res + " "); break;//десятки тысяч
                            case 6:
                                res = Hundreds(rest);
                                result = result.Insert(0, res + " "); break;//сотни тысяч
                            case 7:
                                res = Millions(rest);
                                result = result.Insert(0, res + " "); break;//миллион
                            case 8:
                                res = Tens(rest);
                                result = result.Insert(0, res + " "); break;//десятки миллионов
                            case 9:
                                res = Hundreds(rest);
                                result = result.Insert(0, res + " "); break;//сотни милионнов
                            case 10:
                                res = Billion(rest);
                                result = result.Insert(0, res + " "); break;//миллиард

                            case 0: break;
                        }
                    }
                    //если последний разряд числа равен 0
                    else
                    {
                        switch (i + 1)
                        {
                            case 1: break;//единицы
                            case 2: break;//десятки
                            case 3: break;//сотни
                            case 4:
                                if (!isThousand && number % 100 != 0)
                                {
                                    result = result.Insert(0, "тысяч ");
                                    isThousand = true;
                                }
                                else isThousand = true;
                                break;//тысячи
                            case 5:
                                if (!isThousand)
                                {
                                    result = result.Insert(0, "тысяч ");
                                    isThousand = true;
                                }
                                break;//десятки тысяч
                            case 6:
                                if (!isThousand)
                                {
                                    result = result.Insert(0, "тысяч ");
                                    isThousand = true;
                                }
                                break;//сотни тысяч
                            case 7:
                                if (!isMillion && number % 100 != 0)
                                {
                                    result = result.Insert(0, "миллионов ");
                                    isMillion = true;
                                }
                                else
                                {
                                    isMillion = true;
                                }
                                break;//миллионы
                            case 8:
                                if (!isMillion)
                                {
                                    result = result.Insert(0, "миллионов ");
                                    isMillion = true;
                                }
                                break;//десятки миллионов
                            case 9:
                                if (!isMillion)
                                {
                                    result = result.Insert(0, "милионов ");
                                    isMillion = true;
                                }
                                break;//сотни миллионов

                        }
                    }
                }
            }
            return result;
        }
        //еденицы в тексте
        public string Units(int rest)
        {
            switch (rest)
            {
                case 1: return "один";
                case 2: return "два";
                case 3: return "три";
                case 4: return "четыре";
                case 5: return "пять";
                case 6: return "шесть";
                case 7: return "семь";
                case 8: return "восемь";
                case 9: return "девять";

            }
            return "";
        }
        //с 10 по 19 в тексте
        public string First_Tens(int rest)
        {
            switch (rest)
            {
                case 10: return "десять";
                case 11: return "одиннадцать";
                case 12: return "двенадцать";
                case 13: return "тринадцать";
                case 14: return "четырнадцать";
                case 15: return "пятнадцать";
                case 16: return "шестнадцать";
                case 17: return "семнадцать";
                case 18: return "восемнадцать";
                case 19: return "девятнадцать";

            }
            return "";
        }

        //десятки в тексте
        public string Tens(int rest)
        {
            switch (rest)
            {
                case 2: return "двадцать";
                case 3: return "тридцать";
                case 4: return "сорок";
                case 5: return "пятьдесят";
                case 6: return "шестьдесят";
                case 7: return "семдесят";
                case 8: return "восемдесят";
                case 9: return "девяносто";

            }
            return "";
        }

        //сотни в тексте
        public string Hundreds(int rest)
        {
            switch (rest)
            {
                case 1: return "сто";
                case 2: return "двести";
                case 3: return "триста";
                case 4: return "четыреста";
                case 5: return "пятьсот";
                case 6: return "шетьсот";
                case 7: return "семьсот";
                case 8: return "восемьсот";
                case 9: return "девятьсот";

            }
            return "";
        }
        //тысячи в тексте
        public string Thousands(int rest)
        {
            switch (rest)
            {
                case 1: return "одна тысяча";
                case 2: return "две тысячи";
                case 3: return "три тысячи";
                case 4: return "четыре тысячи";
                case 5: return "пять тысяч";
                case 6: return "шеть тысяч";
                case 7: return "семь тысяч";
                case 8: return "восемь тысяч";
                case 9: return "девять тысяч";
                case 0: return "тысяч";

            }
            return "";
        }
        //миллионы в тексте
        public string Millions(int rest)
        {
            switch (rest)
            {
                case 1: return "один миллион";
                case 2: return "два миллиона";
                case 3: return "три миллиона";
                case 4: return "четыре миллиона";
                case 5: return "пять миллионов";
                case 6: return "шеть миллионов";
                case 7: return "семь миллионов";
                case 8: return "восемь миллионов";
                case 9: return "девять миллионов";
                case 0: return "миллионов";

            }
            return "";
        }
        //миллиарды в тексте
        public string Billion(int rest)
        {
            switch (rest)
            {
                case 1: return "один миллиард";
            }
            return "";
        }
        //форма слова доллар
        public string Dollars(int number)
        {
            switch (number % 10)
            {
                case 1: return "доллар";
                case 2: case 3: case 4: return "доллара";
                case 5: case 6: case 7: case 8: case 9: case 0: return "долларов";
            }
            return "";
        }
        //форма слова цент
        public string Cents(int number)
        {
            switch (number % 10)
            {
                case 1: return "цент";
                case 2: case 3: case 4: return "цента";
                case 5: case 6: case 7: case 8: case 9: case 0: return "центов";
            }
            return "";
        }
    }
}
