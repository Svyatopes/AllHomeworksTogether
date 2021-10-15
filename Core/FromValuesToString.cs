using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    //AAAAAAAAAAAAAAAAAAAAA NAMING AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    public static class FromValuesToString
    {
        public static string GetStringOfQuarter(int quarterInt)
        {
            return quarterInt switch
            {
                1 => "First",
                2 => "Second",
                3 => "Third",
                4 => "Fourth",
                _ => string.Empty,
            };
        }

        public static string GetStringOfThreeNumberSortByAsc(double numberA, double numberB, double numberC)
        {
            if (numberA >= numberB)
            {
                if (numberB >= numberC)
                {
                    return $"{numberC} {numberB} {numberA}";
                }
                else if (numberA >= numberC)
                {

                    return $"{numberB} {numberC} {numberA}";
                }
                else
                {
                    return $"{numberB} {numberA} {numberC}";
                }
            }
            else
            {
                if (numberA >= numberC)
                {
                    return $"{numberC} {numberA} {numberB}";
                }
                else if (numberC >= numberB)
                {
                    return $"{numberA} {numberB} {numberC}";
                }
                else
                {
                    return $"{numberA} {numberC} {numberB}";
                }
            }
        }

        public static string GetTranscriptionOf2DigitsInt(int numberToTranscription)
        {
            string resultTranscriptionString;
            if (numberToTranscription < 20)
            {
                resultTranscriptionString = numberToTranscription switch
                {
                    11 => "Одиннадцать",
                    12 => "Двенадцать",
                    13 => "Тринадцать",
                    14 => "Четырнадцать",
                    15 => "Пятнадцать",
                    16 => "Шестнадцать",
                    17 => "Семнадцать",
                    18 => "Восемнадцать",
                    19 => "Девятнцать",
                    _ => "Not valid number, something get wrong."
                };
                return resultTranscriptionString;
            }

            int secondDigit = numberToTranscription / 10;
            int firstDigit = numberToTranscription % 10;

            string secondDigitTranscription;
            string firstDigitTranscription;

            secondDigitTranscription = secondDigit switch
            {
                2 => "Двадцать",
                3 => "Тридцать",
                4 => "Сорок",
                5 => "Пятьдесят",
                6 => "Шестьдесят",
                7 => "Семьдесят",
                8 => "Восемьдесят",
                9 => "Девяносто",
                _ => "Not valid number, something get wrong."
            };

            firstDigitTranscription = firstDigit switch
            {
                0 => string.Empty,
                1 => "один",
                2 => "два",
                3 => "три",
                4 => "четыре",
                5 => "пять",
                6 => "шесть",
                7 => "семь",
                8 => "восемь",
                9 => "девять",
                _ => "Not valid number, something get wrong."
            };

            resultTranscriptionString = $"{secondDigitTranscription} {firstDigitTranscription}".Trim();
            return resultTranscriptionString;
        }
    }
}
