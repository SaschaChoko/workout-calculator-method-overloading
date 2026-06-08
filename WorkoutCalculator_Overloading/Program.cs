using static System.Console;
using static System.Convert;
using Menu = System.Console;
using Info = ProgramInfo;
using Calculator = WorkoutCalculator;
class WorkoutCalculator
{
    const int coefficient1 = 65;
    const double coefficient2 = 1.0;
    const double coefficient3 = 9.8;
    const int coefficient4 = 10;
    public double CalculateCalories(double kilometers)
    {
        calculationCounter++;
        return kilometers * coefficient1;
    }
    public double CalculateCalories(double kilometers, double weight)
    {
        calculationCounter++;
        return weight * kilometers * coefficient2;
    }
    public double CalculateCalories(double kilometers, double weight, int hours)
    {
        calculationCounter++;
        return coefficient3 * weight * hours;
    }
    public double CalculateCalories(int hours, int minutes)
    {
        calculationCounter++;
        return ((hours * 60) + minutes) * coefficient4;
    }
    static int calculationCounter = 0;
    public static int Counter => calculationCounter;
}
class ProgramInfo
{
    public const double Version = 2.0;
}
class Program
{
    static void Main()
    {
        const string programName = "WorkoutCalculator";
        DateTime startTime = DateTime.Now;
        Calculator calculator = new Calculator();
        bool run = true;
        while (run)
        {
            WriteLine(programName);
            ShowMenu();
            WriteLine("Please choose what do you want to calculate:");
            int menuChoise = ToInt32(ReadLine());

            switch (menuChoise)
            {
                case 1:
                    WriteLine("Enter kilometers:");
                    double kilometers = ToDouble(ReadLine());
                    double calories = calculator.CalculateCalories(kilometers);
                    WriteLine($"You burned {calories} calories");
                    break;

                case 2:
                    WriteLine("Enter kilometers:");
                    double kilometers2 = ToDouble(ReadLine());
                    WriteLine("Enter weight:");
                    double weight2 = ToDouble(ReadLine());
                    double calories2 = calculator.CalculateCalories(kilometers2, weight2);
                    WriteLine($"You burned {calories2} calories");
                    break;

                case 3:
                    WriteLine("Enter kilometers:");
                    double kilometers3 = ToDouble(ReadLine());
                    WriteLine("Enter weight:");
                    double weight3 = ToDouble(ReadLine());
                    WriteLine("Enter hours:");
                    int hours3 = ToInt32(ReadLine());
                    double calories3 = calculator.CalculateCalories(kilometers3, weight3, hours3);
                    WriteLine($"You burned {calories3} calories");
                    break;

                case 4:
                    WriteLine("Enter hours:");
                    int hours4 = ToInt32(ReadLine());
                    WriteLine("Enter minutes:");
                    int minutes4 = ToInt32(ReadLine());
                    double calories4 = calculator.CalculateCalories(hours4, minutes4);
                    WriteLine($"You burned {calories4} calories");
                    break;
                case 5:
                    ShowCalculationCounts();
                    break;
                case 6:
                    TimeSpan runtime = DateTime.Now - startTime;
                    WriteLine($"Your run time is: {runtime}");
                    break;
                case 7:
                    WriteLine($"The version of the program is: {Info.Version}");
                    break;
                case 0:
                    WriteLine("Exit...");
                    run = false;
                    break;

                default:
                    WriteLine("Invalid input");
                    break;
            }
        }
    }
    static void ShowMenu()
    {
        Menu.WriteLine("1 – Simple calculation");
        Menu.WriteLine("2 – Calculation with weight");
        Menu.WriteLine("3 – Calculation with weight and time");
        Menu.WriteLine("4 – Calculation by time");
        Menu.WriteLine("5 - Number of calculator calls");
        Menu.WriteLine("6 - My runtime");
        Menu.WriteLine("7 - Version of the Calculator");
        Menu.WriteLine("0 - Exit");
        Menu.WriteLine();
    }
    static void ShowCalculationCounts()
    {        
        WriteLine($"Your count of calculations: {Calculator.Counter}");
    }
}