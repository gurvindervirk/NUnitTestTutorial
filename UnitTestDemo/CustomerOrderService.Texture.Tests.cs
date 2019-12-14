using NUnit.Framework;

namespace CustomerOrderService.Tests
{
    [TestFixture(CustomerType.Premium, 100.00)]
    [TestFixture(CustomerType.Basic)]
    public class CustomerOrderServiceTestsTexture
    {
        private CustomerType customerType;
        private double minOrder;
        public CustomerOrderServiceTestsTexture(CustomerType customerType, double minOrder)
        {
			    this.customerType = customerType;
				this.minOrder = minOrder;
        }
        public CustomerOrderServiceTestsTexture(CustomerType customerType) : this(customerType, 0)
        {
			
        }
        [TestCase]
        public void TestMethod()
        {
            Assert.IsTrue((customerType == CustomerType.Basic && minOrder == 0 || customerType == CustomerType.Premium && minOrder > 0));
        }
    }
}

