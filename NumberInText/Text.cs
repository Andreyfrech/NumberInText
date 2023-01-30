using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInText
{
    class Text
    {
        Dictionrys dictionry = new Dictionrys();
        DictionrysEng dictionrysEng = new DictionrysEng();
        public  string Transform(int number, int digitCount)
        {
            string res = "";// промежуточный результат
            string resEng = "";// промежуточный результат на английском
            string result = "";// окончательный результат
            string resultEng = "";// окончательный результат на английском
            int rest = 0;    // остаток от деления
            

            //если у нас двухзначное число и оно лежит в интервале от 10 до 19
            if (digitCount == 2 && number % 100 >= 10 && number % 100 <= 19)
            {
                res = dictionry.TextFirstTen[number];
                result = result.Insert(0, res + " ");
                resEng = dictionrysEng.TextFirstTen[number];
                resultEng = resultEng.Insert(0, resEng + " ");
            }
            else
            {
                //проходимся по всем разрядам начиная с меньшего
                for (int i = 0; i < digitCount;i++)
                {
                    //если два последних разряда, образовавши число, попадает в интервал от 10 до 19
                    
                    if (number % 100 >= 10 && number % 100 <= 19 && (i == 0 || i == 3 || i == 6))
                    {
                        rest = number % 100;
                        if(i == 0)
                        {
                            res = dictionry.TextFirstTen[rest];
                            result = result.Insert(0, res + " ");
                            resEng = dictionrysEng.TextFirstTen[rest];
                            resultEng = resultEng.Insert(0, resEng + " ");

                        }
                        if (i == 3)
                        {
                            res = dictionry.TextFirstTen[rest];
                            result = result.Insert(0, res + " тысяч ");
                            resEng = dictionrysEng.TextFirstTen[rest];
                            resultEng = resultEng.Insert(0, resEng + " thousand ");
                        }
                        if (i == 6)
                        {
                            res = dictionry.TextFirstTen[rest];
                            result = result.Insert(0, res + " миллионов ");
                            resEng = dictionrysEng.TextFirstTen[rest];
                            resultEng = resultEng.Insert(0, resEng + " million ");
                        }
                        //отбрасываем последний разряд от числа
                        number /= 10;
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
                                res = dictionry.Textunit[rest];
                                result = result.Insert(0, res + " ");
                                resEng = dictionrysEng.Textunit[rest];
                                resultEng = resultEng.Insert(0, resEng + " "); break;//единицы
                            case 2:
                                res = dictionry.TextTen[rest];
                                result = result.Insert(0, res + " ");
                                resEng = dictionrysEng.TextTen[rest];
                                resultEng = resultEng.Insert(0, resEng + " "); break;//десятки
                            case 3:
                                res = dictionry.TextHundred[rest];
                                result = result.Insert(0, res + " ");
                                resEng = dictionrysEng.Textunit[rest];
                                resultEng = resultEng.Insert(0, resEng + " hundred "); break;//сотни
                            case 4:
                                res = Thousands(rest);
                                result = result.Insert(0, res + " ");
                                resEng = dictionrysEng.Textunit[rest];
                                resultEng = resultEng.Insert(0, resEng + " thousand "); break;//тысячи
                            case 5:
                                res = dictionry.TextTen[rest];
                                result = result.Insert(0, res + " ");
                                resEng = dictionrysEng.TextTen[rest];
                                resultEng = resultEng.Insert(0, resEng + " "); break;//десятки тысяч
                            case 6:
                                res = dictionry.TextHundred[rest];
                                result = result.Insert(0, res + " ");
                                resEng = dictionrysEng.Textunit[rest];
                                resultEng = resultEng.Insert(0, resEng + " hundred "); break;//сотни тысяч
                            case 7:
                                res = Millions(rest);
                                result = result.Insert(0, res + " ");
                                resEng = dictionrysEng.Textunit[rest];
                                resultEng = resultEng.Insert(0, resEng + " million "); break;//миллион
                            case 8:
                                res = dictionry.TextTen[rest];
                                result = result.Insert(0, res + " ");
                                resEng = dictionrysEng.TextTen[rest];
                                resultEng = resultEng.Insert(0, resEng + " "); break;//десятки миллионов
                            case 9:
                                res = dictionry.TextHundred[rest];
                                result = result.Insert(0, res + " ");
                                resEng = dictionrysEng.Textunit[rest];
                                resultEng = resultEng.Insert(0, resEng + " hundred "); break;//сотни милионнов
                            case 10:
                                res = Billion(rest);
                                result = result.Insert(0, res + " ");
                                resEng = dictionrysEng.Textunit[rest];
                                resultEng = resultEng.Insert(0, resEng + " billion "); break;//миллиард

                            case 0: break;
                        }
                    }
                }
            }
            return result + "\n" + resultEng;
        }
        //Тысячи в тексте
        public string Thousands(int rest)
        {
            switch (rest)
            {
                case 1: return "одна тысяча";
                case 2: return "две тысячи";

            }
            string Thousand = dictionry.TextThousand[rest];
            return dictionry.Textunit[rest] + " " + Thousand;
        }

        //миллионы в тексте
        public string Millions(int rest)
        {
            string Million = dictionry.TextMillion[rest];
            return dictionry.Textunit[rest] + " " + Million;
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
            if(number % 100 > 10 && number % 100 < 20)
            {
                return "долларов";
            }
           return dictionry.TextDollar[number % 10];
        }

        //форма слова цент
        public string Cents(int number)
        {
            if (number % 100 > 10 && number % 100 < 20)
            {
                return "центов";
            }
            return dictionry.TextCent[number % 10];
        }
    }
}

