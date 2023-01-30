using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInText
{
    public class Dictionrys
    {
       //Текст единиц
       public Dictionary<int, string> Textunit = new Dictionary<int, string>()
        {
                { 1, "один" },
                { 2, "два" },
                { 3, "три" },
                { 4, "четыре" },
                { 5, "пять" },
                { 6, "шесть" },
                { 7, "семь" },
                { 8, "восемь" },
                { 9, "девять" }
        };
        //Текст тысяч
        public Dictionary<int, string> TextThousand = new Dictionary<int, string>()
        {
                { 1, "тысяча" },
                { 2, "тысячи" },
                { 3, "тысячи" },
                { 4, "тысячи" },
                { 5, "тысяч" },
                { 6, "тысяч" },
                { 7, "тысяч" },
                { 8, "тысяч" },
                { 9, "тысяч" }
        };
        //Текст миллионов
        public Dictionary<int, string> TextMillion = new Dictionary<int, string>()
        {
                { 1, "миллион" },
                { 2, "миллиона" },
                { 3, "миллиона" },
                { 4, "миллиона" },
                { 5, "миллионов" },
                { 6, "миллионов" },
                { 7, "миллионов" },
                { 8, "миллионов" },
                { 9, "миллионов" }
        };
        //Текст чисел от 10 до 19
        public Dictionary<int, string> TextFirstTen = new Dictionary<int, string>()
        {
                { 10, "десять" },
                { 11, "одиннадцать" },
                { 12, "двенадцать" },
                { 13, "тринадцать" },
                { 14, "четырнадцать" },
                { 15, "пятнадцать" },
                { 16, "шестнадцать" },
                { 17, "семнадцать" },
                { 18, "восемнадцать" },
                { 19, "девятнадцать" }
        };
        //Текст сотен
        public Dictionary<int, string> TextHundred = new Dictionary<int, string>()
        {
                { 1, "сто" },
                { 2, "двести" },
                { 3, "триста" },
                { 4, "четыреста" },
                { 5, "пятьсот" },
                { 6, "шетьсот" },
                { 7, "семьсот" },
                { 8, "восемьсот" },
                { 9, "девятьсот" }
        };
        //Текст десятков
        public Dictionary<int, string> TextTen = new Dictionary<int, string>()
        {
                { 1, "" },
                { 2, "двадцать" },
                { 3, "тридцать" },
                { 4, "сорок" },
                { 5, "пятьдесят" },
                { 6, "шестьдесят" },
                { 7, "семдесят" },
                { 8, "восемдесят" },
                { 9, "девяносто" }
        };
        //Форма доллара
        public Dictionary<int, string> TextDollar = new Dictionary<int, string>()
        {
                { 1, "доллар" },
                { 2, "доллара" },
                { 3, "доллара" },
                { 4, "доллара" },
                { 5, "долларов" },
                { 6, "долларов" },
                { 7, "долларов" },
                { 8, "долларов" },
                { 9, "долларов" },
                { 0, "долларов" }
        };
        //Форма цента
        public Dictionary<int, string> TextCent = new Dictionary<int, string>()
        {
                { 1, "цент" },
                { 2, "цента" },
                { 3, "цента" },
                { 4, "цента" },
                { 5, "центов" },
                { 6, "центов" },
                { 7, "центов" },
                { 8, "центов" },
                { 9, "центов" },
                { 0, "центов" }
        };
    }
}

