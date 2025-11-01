namespace UnitTests
{
    public class SimpleTest
    {
        [Fact]
        public void TestAddition()
        {
            int a = 5;
            int b = 10;
            int sum = a + b;
            Assert.Equal(15, sum);
        }
    }
}
