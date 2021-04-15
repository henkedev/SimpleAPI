using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();

        [Fact]
        public void GetReturnsStringsValue1AndValue2()
        {
            var response = controller.Get();
            var expectedValues = new string[] {"Value1", "Value2"};
            
            foreach (string v in response.Value)
            {
                Assert.Contains<string>(v, expectedValues);
            }
        }

        [Fact]
        public void GetReturnsMyName()
        {
            var response = controller.Get(1);

            Assert.Equal("Henke", response.Value);
        }
    }
}
