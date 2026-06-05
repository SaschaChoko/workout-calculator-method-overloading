class WorkoutCalculator
{
    public double CalculateCalories(double kilometers)
    {
        calculationCounter++;
        return kilometers * 65;
    }
    public double CalculateCalories(double kilometers, double weight)
    {
        calculationCounter++;
        return weight * kilometers * 1.0;
    }
    public double CalculateCalories(double kilometers, double weight, int hours)
    {
        calculationCounter++;
        return 9.8 * weight * hours;
    }
    public double CalculateCalories(int hours, int minutes)
    {
        calculationCounter++;
        return ((hours * 60) + minutes) * 10;
    }
    static int calculationCounter = 0;
    public static int Counter => calculationCounter;
}
class Program
{
    static void Main()
    {
        WorkoutCalculator calculator = new WorkoutCalculator();
        bool run = true;
        while (run)
        {
            ShowMenu();
            Console.WriteLine("Please choose what do you want to calculate:");
            int menuChoise = Convert.ToInt32(Console.ReadLine());

            switch (menuChoise)
            {
                case 1:
                    Console.WriteLine("Enter kilometers:");
                    double kilometers = Convert.ToDouble(Console.ReadLine());
                    double calories = calculator.CalculateCalories(kilometers);
                    Console.WriteLine($"You burned {calories} calories");
                    break;

                case 2:
                    Console.WriteLine("Enter kilometers:");
                    double kilometers2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter weight:");
                    double weight2 = Convert.ToDouble(Console.ReadLine());
                    double calories2 = calculator.CalculateCalories(kilometers2, weight2);
                    Console.WriteLine($"You burned {calories2} calories");
                    break;

                case 3:
                    Console.WriteLine("Enter kilometers:");
                    double kilometers3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter weight:");
                    double weight3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter hours:");
                    int hours3 = Convert.ToInt32(Console.ReadLine());
                    double calories3 = calculator.CalculateCalories(kilometers3, weight3, hours3);
                    Console.WriteLine($"You burned {calories3} calories");
                    break;

                case 4:
                    Console.WriteLine("Enter hours:");
                    int hours4 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter minutes:");
                    int minutes4 = Convert.ToInt32(Console.ReadLine());
                    double calories4 = calculator.CalculateCalories(hours4, minutes4);
                    Console.WriteLine($"You burned {calories4} calories");
                    break;
                case 5:
                    Console.WriteLine(WorkoutCalculator.Counter);
                    break;
                case 0:
                    Console.WriteLine("Exit...");
                    run = false;
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
    static void ShowMenu()
    {
        Console.WriteLine();
        Console.WriteLine("1 – Simple calculation");
        Console.WriteLine("2 – Calculation with weight");
        Console.WriteLine("3 – Calculation with weight and time");
        Console.WriteLine("4 – Calculation by time");
        Console.WriteLine("5 - Number of calculator calls");
        Console.WriteLine("0 - Exit");
        Console.WriteLine();
    }
}