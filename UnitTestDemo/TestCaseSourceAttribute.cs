using System.Collections;
using NUnit.Framework;
namespace UnitTestDemo
{
    public class StringArrayTestDataSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new string[] { "2", "4", "6" };
            yield return new string[] { "3", "4", "5" };
            yield return new string[] { "6", "8", "10" };
        }
    }
    [TestFixture]
    public class EmployeeTest
    {
        [TestCaseSource(typeof(StringArrayTestDataSource))]
        public void When_StringArrayAreEvenNumbers_Expects_IsStringArrayOfEvenNumbersAsTrue(string[] numbers)
        {
            Employee employee = new Employee();
            bool result = employee.IsStringArrayOfEvenNumbers(numbers);
            Assert.That(result == true);
        }
    }
}
