using NUnit.Framework;

namespace UnitTestDemo
{
    [TestFixture]
    public class EmployeeTests
    {
        // Test Case for Test Input Data
        [TestCase(Author = "Gurvinder")]
        [Order(1)]
        public void When_NameContainsIllegalChars_Expect_ContainsIllegalChars_ReturnsTrue()
        {
            Employee employee = new Employee();
            employee.Name = "Da$ya";
            var result = employee.ContainsIllegalChars();
            Assert.IsTrue(result);
        }
        //NUnit TestCase Without Arguments / Parameters
        [TestCase(Author = "Michael", TestName = "EmployeeAgeGreaterAndEqualTo60_Expects_IsSCitizenAsTrue")]
        [Order(2)]
        public void When_AgeGreaterAndEqualTo60_Expects_IsSeniorCitizeAsTrue()
        {
            Employee emp = new Employee();
            emp.Age = 60;
             bool result = emp.IsSeniorCitizen();
            Assert.That(result == true);
        }
        //NUnit TestCase Arguments / Parameters
        [TestCase(60)]
        [TestCase(80)]
        [TestCase(90)]
        [Order(4)]
        public void When_AgeGreaterAndEqualTo60_Expects_IsSeniorCitizeAsTrue(int age)
        {
            Employee emp = new Employee();
            emp.Age = age;
            bool result = emp.IsSeniorCitizen();
            Assert.That(result == true);
        }
        //NUnit TestCase ExpectedResult
        [TestCase(29, ExpectedResult = false)]
        [TestCase(0, ExpectedResult = false)]
        [TestCase(60, ExpectedResult = true)]
        [TestCase(80, ExpectedResult = true)]
        [TestCase(90, ExpectedResult = true)]
        [Order(3)]
        public bool When_AgeGreaterAndEqualTo60_Expects_IsSeniorCitizeAsTrueResult(int age)
        {
            Employee emp = new Employee();
            emp.Age = age;
            bool result = emp.IsSeniorCitizen();
            return result;
        }
      
     }
}
