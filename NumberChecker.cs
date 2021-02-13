using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingProject
{
    //Check if number is even
    //check if number is odd
    //isGettingAllEvenNumberBetweenRange
    //isGettingAllOddNumberBetweenRange
    //isAdditionEvenNumberTrue
    //isAdditionOddNumberTrue
    //IsStartNumberLesserThanEndNumber
    //IsEndNumberGreaterThanStartNumber

    //CheckDatatype
    public class NumberChecker
    {
        //public bool CheckDataType(int number) { 
        //    if(number.)
        //}
        public bool IsNumberEven(int number) {
            if (number.isEven()) {
                return true;
            }
            return false;
        }

        public bool IsNumberOdd(int number)
        {
            if (!number.isEven()) {
                return true;
            }
            return false;
        }

        public bool IsStartNumberLesserThanEndNumber(int startNumber, int endNumber)
        {
            if (startNumber < endNumber)
            {
                return true;
            }
            return false;
        }
        public bool IsEndNumberGreaterThanStartNumber(int startNumber, int endNumber)
        {
            if (endNumber > startNumber)
            {
                return true;
            }
            return false;
        }

        public List<int> IsGettingAllEvenNumber(int startNumber, int endNumber) {
            List<int> evenNumbers = new List<int>();
            for (int i = startNumber; i <= endNumber; i++)
            {

                if (i.isEven())
                {
                    evenNumbers.Add(i);
                }
            }
            return evenNumbers;

        }

        public List<int> IsGettingAllOddNumber(int startNumber, int endNumber) {
            List<int> oddNumbers = new List<int>();
            for (int i = startNumber; i <= endNumber; i++)
            {

                if (!i.isEven())
                {
                    oddNumbers.Add(i);
                }
            }
            return oddNumbers;


        }

        public int IsAdditionOfEvenNumber(int startNumber, int endNumber)
        {
            int sumEven = 0;
            for (int i = startNumber; i <= endNumber; i++)
            {

                if (i.isEven())
                {
                    sumEven += i;
                }
            }
            return sumEven;

        }

        public int IsAdditionOfOddNumber(int startNumber, int endNumber)
        {
            int sumOdd = 0;
            for (int i = startNumber; i <= endNumber; i++)
            {

                if (!i.isEven())
                {
                    sumOdd += i;
                }
            }
            return sumOdd;

        }



    }
}
