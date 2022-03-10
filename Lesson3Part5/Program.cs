using System;

namespace Lesson3Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двухзначное число: ");

            int number;
            string secondDigitInWord = "";
            int.TryParse(Console.ReadLine(),out number);
            
            int secondDigit = number % 10;

            if (secondDigit == 1) secondDigitInWord = "один";
                else if (secondDigit == 2) secondDigitInWord = "два";
                    else if (secondDigit == 3) secondDigitInWord = "три";
                        else if (secondDigit == 4) secondDigitInWord = "четыре";
                            else if (secondDigit == 5) secondDigitInWord = "пять";
                                else if (secondDigit == 6) secondDigitInWord = "шесть";
                                    else if (secondDigit == 7) secondDigitInWord = "семь";
                                        else if (secondDigit == 8) secondDigitInWord = "восемь";
                                            else if (secondDigit == 9) secondDigitInWord = "девять";

            if (number == 11) Console.WriteLine("Одинадцать");
                else if (number == 12) Console.WriteLine("Двенадцать");
                    else if (number == 13) Console.WriteLine("Тринадцать");
                        else if (number == 14) Console.WriteLine("Четырнадцать");
                            else if (number == 15) Console.WriteLine("Пятнадцать");
                                else if (number == 16) Console.WriteLine("Шеснадцать");
                                    else if (number == 17) Console.WriteLine("Семнадцать");
                                        else if (number == 18) Console.WriteLine("Восмнадцать");
                                            else if (number == 19) Console.WriteLine("Девятнадцать");

            if (number >= 20 && number < 30) Console.WriteLine($"Двадцать {secondDigitInWord}");
                else if (number >= 30 && number < 40) Console.WriteLine($"Тридцать {secondDigitInWord}");
                    else if (number >= 40 && number < 50) Console.WriteLine($"Сорок {secondDigitInWord}");
                        else if (number >= 50 && number < 60) Console.WriteLine($"Пятьдесят {secondDigitInWord}");
                            else if (number >= 60 && number < 70) Console.WriteLine($"Шестьдесят {secondDigitInWord}");
                                else if (number >= 70 && number < 80) Console.WriteLine($"Семьдесят {secondDigitInWord}");
                                    else if (number >= 80 && number < 90) Console.WriteLine($"Восемьдесят {secondDigitInWord}");
                                        else if (number >= 90 && number < 100) Console.WriteLine($"Девяносто {secondDigitInWord}");
        }
    }
}
