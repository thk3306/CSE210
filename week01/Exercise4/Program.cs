using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter numbers, type 0 when finished:");
        while (true)
        {
            int number = int.Parse(Console.ReadLine());
            if (number == 0) break;
            numbers.Add(number);
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}