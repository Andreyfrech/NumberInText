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
                            result = result.Insert(0, res + " thousand ");
                        }
                        if (i == 6)
                        {
                            res = First_Tens(rest);
                            result = result.Insert(0, res + " million ");
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
                                result = result.Insert(0, res + ", "); break;//единицы
                            case 2:
                                res = Tens(rest);
                                if (number % 10 == 0)
                                {
                                    result = result.Insert(0, res + " "); break;//десятки
                                }
                                else
                                {
                                    result = result.Insert(0, "and " + res + " "); break;//десятки
                                }
                            case 3:
                                res = Units(rest);
                                result = result.Insert(0, res + " hundred "); break;//сотни
                            case 4:
                                res = Units(rest);
                                result = result.Insert(0, res + " thousand, "); break;//тысячи
                            case 5:
                                res = Tens(rest);
                                if (number % 10 == 0)
                                {
                                    result = result.Insert(0, res + " "); break;//десятки тысяч
                                }
                                else
                                {
                                    result = result.Insert(0, "and " + res + " "); break;//десятки тысяч
                                }
                            case 6:
                                res = Units(rest);
                                result = result.Insert(0, res + " hundred "); break;//сотни тысяч
                            case 7:
                                res = Units(rest);
                                result = result.Insert(0, res + " million, "); break;//миллион
                            case 8:
                                res = Tens(rest);
                                if (number % 10 == 0)
                                {
                                    result = result.Insert(0, res + " "); break;//десятки миллионов
                                }
                                else
                                {
                                    result = result.Insert(0, "and " + res + " "); break;//десятки миллионов
                                }
                            case 9:
                                res = Units(rest);
                                result = result.Insert(0, res + " hundred "); break;//сотни милионнов
                            case 10:
                                res = Units(rest);
                                result = result.Insert(0, res + " billion, "); break;//миллиард

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
                                    result = result.Insert(0, "thousand ");
                                    isThousand = true;
                                }
                                else isThousand = true;
                                break;//тысячи
                            case 5:
                                if (!isThousand)
                                {
                                    result = result.Insert(0, "thousand ");
                                    isThousand = true;
                                }
                                break;//десятки тысяч
                            case 6:
                                if (!isThousand)
                                {
                                    result = result.Insert(0, "thousand ");
                                    isThousand = true;
                                }
                                break;//сотни тысяч
                            case 7:
                                if (!isMillion && number % 100 != 0)
                                {
                                    result = result.Insert(0, "million ");
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
                                    result = result.Insert(0, "million ");
                                    isMillion = true;
                                }
                                break;//десятки миллионов
                            case 9:
                                if (!isMillion)
                                {
                                    result = result.Insert(0, "million ");
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
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";

            }
            return "";
        }
        //с 10 по 19 в тексте
        public string First_Tens(int rest)
        {
            switch (rest)
            {
                case 10: return "ten";
                case 11: return "eleven";
                case 12: return "twelve";
                case 13: return "thirteen";
                case 14: return "fourteen";
                case 15: return "fifteen";
                case 16: return "sixteen";
                case 17: return "seventeen";
                case 18: return "eighteen";
                case 19: return "nineteen";

            }
            return "";
        }

        //десятки в тексте
        public string Tens(int rest)
        {
            switch (rest)
            {
                case 2: return "twenty";
                case 3: return "thirty";
                case 4: return "forty";
                case 5: return "fifty";
                case 6: return "sixty";
                case 7: return "seventy";
                case 8: return "eighty";
                case 9: return "ninety";

            }
            return "";
        }
    }
}
