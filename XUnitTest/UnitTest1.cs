using Moq;
using Xunit;

namespace XUnitTest
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            var imp = new Mock<IInterface>();
        }
    }
}