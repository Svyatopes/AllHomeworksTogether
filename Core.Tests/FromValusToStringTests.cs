using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tests
{
    public class FromValusToStringTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, "First")]
        [TestCase(2, "Second")]
        [TestCase(3, "Third")]
        [TestCase(4, "Fourth")]
        public void GetStringOfQuarterTest(int quarter, string expected)
        {
            //arrange

            //act
            string actualResult = FromValuesToString.GetStringOfQuarter(quarter);


            //assert
            Assert.AreEqual(expected, actualResult);
        }


        [TestCase(0, 1, 2, "0 1 2")]
        [TestCase(0, 2, 1, "0 1 2")]
        [TestCase(1, 0, 2, "0 1 2")]
        [TestCase(1, 2, 0, "0 1 2")]
        [TestCase(2, 0, 1, "0 1 2")]
        [TestCase(2, 1, 0, "0 1 2")]
        [TestCase(2, 1, 1, "1 1 2")]
        [TestCase(2, 2, 2, "2 2 2")]
        public void GetStringOfThreeNumberSortByAscTest(double numberA, double numberB, double numberC, string expected)
        {
            //arrange

            //act
            string actualResult = FromValuesToString.GetStringOfThreeNumberSortByAsc(numberA, numberB, numberC);


            //assert
            Assert.AreEqual(expected, actualResult);
        }

        [TestCase(10, "Десять")]
        [TestCase(11, "Одиннадцать")]
        [TestCase(12, "Двенадцать")]
        [TestCase(13, "Тринадцать")]
        [TestCase(14, "Четырнадцать")]
        [TestCase(15, "Пятнадцать")]
        [TestCase(16, "Шестнадцать")]
        [TestCase(17, "Семнадцать")]
        [TestCase(18, "Восемнадцать")]
        [TestCase(19, "Девятнадцать")]
        [TestCase(20, "Двадцать")]
        [TestCase(21, "Двадцать один")]
        [TestCase(22, "Двадцать два")]
        [TestCase(33, "Тридцать три")]
        [TestCase(44, "Сорок четыре")]
        [TestCase(55, "Пятьдесят пять")]
        [TestCase(66, "Шестьдесят шесть")]
        [TestCase(77, "Семьдесят семь")]
        [TestCase(88, "Восемьдесят восемь")]
        [TestCase(99, "Девяносто девять")]
        public void GetTranscriptionOf2DigitsIntTest(int userNumber, string expected)
        {
            //arrange

            //act
            string actualResult = FromValuesToString.GetTranscriptionOf2DigitsInt(userNumber);


            //assert
            Assert.AreEqual(expected, actualResult);
        }


        [TestCase(9)]
        [TestCase(0)]
        [TestCase(100)]
        [TestCase(1000)]
        public void GetTranscriptionOf2DigitsIntTestNegative(int userNumber)
        {
            //arrange

            //act
            ArgumentException ex = Assert.Throws<ArgumentException>(() => FromValuesToString.GetTranscriptionOf2DigitsInt(userNumber));

            //assert
            Assert.AreEqual("Value can be only with 2 digits", ex.Message);
        }


        [TestCase(0, 5, "Y = 5*X")]
        [TestCase(1, 5, "Y = 5*X + 1")]
        [TestCase(-1, 5, "Y = 5*X - 1")]
        public void GetLinearFunctionStringByFreeMemberAndArgumentXTest(double freeMember, double argumentX, string expected)
        {
            //arrange

            //act
            string actualResult = FromValuesToString.GetLinearFunctionStringByFreeMemberAndArgumentX(freeMember, argumentX);


            //assert
            Assert.AreEqual(expected, actualResult);
        }
    }
}
