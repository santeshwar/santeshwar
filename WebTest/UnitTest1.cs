namespace WebTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            int x = 5; int y = 6;
            //act
            int z = x+y;
            //assert
            Assert.Equal(11, z);
        }
    }
}