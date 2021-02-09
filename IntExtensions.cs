using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingProject
{
    public static class IntExtensions
    {
        public static bool isEven(this int number) {

            return number % 2 == 0;
        }

    }
}
