using System;

namespace NumberInText
{
    class Program
    {
        static void Main(string[] args)
        {

            Text word = new Text();
            decimal Number = 0; // число
            int IntNumber = 0; //целая часть
            decimal FractionalNumber = 0; // дробная часть
            int Fractional = 0; // дробная часть * 100
            int DigitCount = 0; // количество разрядов
            string IntNumberString; // целая часть числа прописью
            string FractionalNumberString; // дробная часть числа прописью
            string[] IntNumberStringArr; // целая часть числа прописью массив из двух языков
            string[] FractionalNumberStringArr = new string[]{ "ноль ","zero "}; // дробная часть числа прописью массив из двух языков
            string Dollar; // склоненние слова доллар
            string Cent; // склонение слова центы
            string DollarEng = "DOLLARS"; // склоненние слова доллар на английском
            string CentEng = "CENTS"; // склонение слова центы на английском


            while (Number == 0)
            {
                Console.WriteLine("Enter number\n");
                try
                {
                    Number = Convert.ToDecimal(Console.ReadLine());
                }
                catch (Exception e) { Console.WriteLine("\n" + e.Message + "\n"); }
            }

            //разделение числа на целую и дробную части
            IntNumber = (int)Math.Truncate(Number);
            FractionalNumber = Number - IntNumber;
            FractionalNumber = Math.Round(FractionalNumber, 2, MidpointRounding.AwayFromZero);
            //количество разрядов в числе
            DigitCount = (int)Math.Log10(IntNumber) + 1;

            //дробную часть переводим в целое число
            Fractional = (int)(FractionalNumber * 100);

            //перевод целой части числа в текст
            IntNumberString = word.Transform(IntNumber, DigitCount);
            IntNumberStringArr = IntNumberString.Split('\n');
            if (Fractional != 0)
            {
                DigitCount = (int)Math.Log10(Fractional) + 1;
                //перевод дробной части числа в текст
                FractionalNumberString = word.Transform(Fractional, DigitCount);
                FractionalNumberStringArr = FractionalNumberString.Split("\n");
            }
            //если дробной части нет выводить ноль
            else
            {
                FractionalNumberString = "ноль ";
            }
            //выбор правильного падежа для доллара и цента
            Dollar = word.Dollars(IntNumber);
            Cent = word.Cents(Fractional);
            if(IntNumber % 10 == 1 && IntNumber % 100 < 11 && IntNumber %  100 > 19)
            {
                DollarEng = "DOLLAR";
            }
            if (Fractional % 10 == 1 && Fractional % 100 < 11 && Fractional % 100 > 19)
            {
                CentEng = "CENT";
            }

            Console.WriteLine(IntNumberStringArr[0] + Dollar + " и " + FractionalNumberStringArr[0] + Cent + "\n" + IntNumberStringArr[1] + DollarEng + " AND " + FractionalNumberStringArr[1] + CentEng);
        }
    }
}
