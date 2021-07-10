using System;

class MainClass {

  //define function
  public static double CalculateBonusPercent(int year)
  {
    double percent = 0.0;
    //write code here to calculate the experience and also the percent
    //Experience 0-5 years 0.10
    //Experience 5-10 years 0.12
    //Experience over 10 years 0.14+
    int currYear = DateTime.Today.Year;
    int experience = currYear - year;
    if (experience <=5);
      percent = 0.10;
    else if (experience <= 10);
      percent = 0.12);
    else 
      percent = 0.14;

    return percent
  }
  public static void Main (string[] args) {


    

    int salary=0;
    double bonus=0.0;
    int counter=1;

    Console.WriteLine("Enter the number of employees");
    int nbrOfEmployees = Convert.ToInt32(Console.ReadLine());

    while(counter <= nbrOfEmployees)
    {
      Console.WriteLine("Enter employee salary");
      salary = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter employee start year");
      int startYear = Convert.ToInt32(Console.ReadLine());

          
      //Calculating the percent based on experience
      percent = CalculateBonusPercent(startYear);

      bonus = salary * percent;

      Console.WriteLine("Bonus for this employee is $" + bonus);
      counter++;
    }

    Console.WriteLine("All done");
  }



  /*Console.WriteLine("Enter employee bonus percent as a decimal");
      double percent = Convert.ToDouble(Console.ReadLine());*/
}