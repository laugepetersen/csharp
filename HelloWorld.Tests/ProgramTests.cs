namespace HelloWorld.Tests;

public class ProgramTests
{
    [Fact]
    public void Test1()
    {
      var program = new Program();
      bool output4 = program.isLeapYear(4);
      bool output16 = program.isLeapYear(16);
      bool output100 = program.isLeapYear(100);
      bool output1700 = program.isLeapYear(1700);
      bool output2000 = program.isLeapYear(2000);

      Assert.Equal(true, output4);
      Assert.Equal(true, output16);
      Assert.Equal(false, output100);
      Assert.Equal(false, output1700);
      Assert.Equal(true, output2000);
    }
}