namespace SimpleLogin.Test
{
    public class TestClass
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            int i = 1;
            int j = 1;

            //Act
            int k = i + j;

            //Assert
            Assert.Equal(2, k);
        }
    }
}