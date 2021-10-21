using System;

namespace NumberInWords
{
    class Program
    {
        static void Main(string[] args)
        {

            Word word = new Word();
            decimal Number = 0; // число
            int IntNumber = 0; //целая часть
            decimal FractionalNumber = 0; // дробная часть
            int Fractional = 0; // дробная часть * 100
            int DigitCount = 0; // количество разрядов
            string IntNumberString; // целая часть числа прописью
            string FractionalNumberString; // дробная часть числа прописью
            string Dollar; // склоненние слова доллар
            string Cent; // склонение слова центы


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

            //количество разрядов в числе
            DigitCount = (int)Math.Log10(IntNumber) + 1;

            //дробную часть переводим в целое число
            Fractional = (int)(FractionalNumber * 100);

            //перевод целой части числа в текст
            IntNumberString = word.Transform(IntNumber, DigitCount);
            if (Fractional != 0)
            {
                DigitCount = (int)Math.Log10(Fractional) + 1;
                //перевод дробной части числа в текст
                FractionalNumberString = word.Transform(Fractional, DigitCount);
            }
            //если дробной части нет выводить ноль
            else
            {
                FractionalNumberString = "ноль ";
            }
            //выбор правильного падежа для доллара и цента
            Dollar = word.Dollars(IntNumber);
            Cent = word.Cents(Fractional);

            
            Console.WriteLine(IntNumberString + Dollar + " и " + FractionalNumberString + Cent);
        }
    }
}
