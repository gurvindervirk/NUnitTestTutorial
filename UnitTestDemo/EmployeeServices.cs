using System;
using System.Collections.Generic;
using System.Linq;
namespace UnitTestDemo
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
      
        public bool IsSeniorCitizen()
        {
            if (Age >= 60)
            {
                return true;
            }
            return false;
        }
        public bool AreAllNumbersEven(int[] num)
        {
            if (num[0] == 2 || num[0]==4 || num[0]==6)
            {
                return true;
            }
            return false;
        }
        public bool IsStringArrayOfEvenNumbers(string[] num)
        {
            if (num[0] == "2" || num[0] == "4" || num[0] == "6")
            {
                return true;
            }
            return false;
        }
        public bool ContainsIllegalChars()
        {
            if (this.Name.Contains("$"))
            {
                return true;
            }
            return false;
        }
    }

  }
