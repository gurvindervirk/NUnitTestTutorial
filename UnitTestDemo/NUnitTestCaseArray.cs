using NUnit.Framework;
namespace UnitTestDemo
{
    public class NUnitTestCaseArray
    {
        [TestCase(new int[] { 2, 4, 6 })]
        public void When_AllNumberAreEven_Expects_AreAllNumbersEvenAsTrue(int[] numbers)
        {
            Employee employee = new Employee();
            bool result = employee.AreAllNumbersEven(numbers);
            Assert.That(result == true);
        }
        //Nunit passing strings as object array.
        [TestCase(new object[] { "1", "2", "3" }, Ignore = "Code is not complete yet.")]
        public void When_AllNumberAreEven_Expects_AreAllNumbersEvenAsTrue(object[] numbers)
        {
    
        }
    }
}
