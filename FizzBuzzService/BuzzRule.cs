﻿namespace FizzBuzzService
{
    internal class BuzzRule : IFizzBuzzRule
    {
        public bool IsMatch(int number)
        {
            return number % 5 == 0;
        }

        public string GetOutput()
        {
            return "Buzz";
        }
    }
}