using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInText
{
    public class DictionrysEng
    {
       //Текст единиц
       public Dictionary<int, string> Textunit = new Dictionary<int, string>()
        {
                { 1, "one" },
                { 2, "two" },
                { 3, "three" },
                { 4, "four" },
                { 5, "five" },
                { 6, "six" },
                { 7, "seven" },
                { 8, "eight" },
                { 9, "nine" }
        };
        ////Текст тысяч
        //public Dictionary<int, string> TextThousand = new Dictionary<int, string>()
        //{
        //        { 1, "тысяча" },
        //        { 2, "тысячи" },
        //        { 3, "тысячи" },
        //        { 4, "тысячи" },
        //        { 5, "тысяч" },
        //        { 6, "тысяч" },
        //        { 7, "тысяч" },
        //        { 8, "тысяч" },
        //        { 9, "тысяч" }
        //};
        ////Текст миллионов
        //public Dictionary<int, string> TextMillion = new Dictionary<int, string>()
        //{
        //        { 1, "миллион" },
        //        { 2, "миллиона" },
        //        { 3, "миллиона" },
        //        { 4, "миллиона" },
        //        { 5, "миллионов" },
        //        { 6, "миллионов" },
        //        { 7, "миллионов" },
        //        { 8, "миллионов" },
        //        { 9, "миллионов" }
        //};
        //Текст чисел от 10 до 19
        public Dictionary<int, string> TextFirstTen = new Dictionary<int, string>()
        {
                { 10, "ten" },
                { 11, "eleven" },
                { 12, "twelve" },
                { 13, "thirteen" },
                { 14, "fourteen" },
                { 15, "fifteen" },
                { 16, "sixteen" },
                { 17, "seventeen" },
                { 18, "eighteen" },
                { 19, "nineteen" }
        };
        ////Текст сотен
        //public Dictionary<int, string> TextHundred = new Dictionary<int, string>()
        //{
        //        { 1, "сто" },
        //        { 2, "двести" },
        //        { 3, "триста" },
        //        { 4, "четыреста" },
        //        { 5, "пятьсот" },
        //        { 6, "шетьсот" },
        //        { 7, "семьсот" },
        //        { 8, "восемьсот" },
        //        { 9, "девятьсот" }
        //};
        //Текст десятков
        public Dictionary<int, string> TextTen = new Dictionary<int, string>()
        {
                { 1, "" },
                { 2, "twenty" },
                { 3, "thirty" },
                { 4, "forty" },
                { 5, "fifty" },
                { 6, "sixty" },
                { 7, "seventy" },
                { 8, "eighty" },
                { 9, "ninety" }
        };
        ////Форма доллара
        //public Dictionary<int, string> TextDollar = new Dictionary<int, string>()
        //{
        //        { 1, "доллар" },
        //        { 2, "доллара" },
        //        { 3, "доллара" },
        //        { 4, "доллара" },
        //        { 5, "долларов" },
        //        { 6, "долларов" },
        //        { 7, "долларов" },
        //        { 8, "долларов" },
        //        { 9, "долларов" }
        //};
        ////Форма цента
        //public Dictionary<int, string> TextCent = new Dictionary<int, string>()
        //{
        //        { 1, "цент" },
        //        { 2, "цента" },
        //        { 3, "цента" },
        //        { 4, "цента" },
        //        { 5, "центов" },
        //        { 6, "центов" },
        //        { 7, "центов" },
        //        { 8, "центов" },
        //        { 9, "центов" }
        //};
    }
}

