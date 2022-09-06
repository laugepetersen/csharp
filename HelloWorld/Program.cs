// See https://aka.ms/new-console-template for more information
public class Program {

  public static void Main(string[] args) {
  }
  
  public bool isLeapYear(int year) {
    var leapYear = false;
    if(year % 4 == 0) leapYear = true;
    if(year % 100 == 0) leapYear = false;
    if(year % 400 == 0) leapYear = true;
    return leapYear;
  }

}
