void Holidays(int number)
{
    string[] week = {"Monday", "Tuesday", "Wensday", "Thursday", "Friday", "Saturday", "Sunday"};
    if (number < 1 || number > 7)
    {
        Console.WriteLine("Please, print number from 1 to 7");
    }
    else if (number == 6 || number == 7)
    {
        Console.WriteLine($"{week[number-1]} is a holiday");
    }
    else
    {
        Console.WriteLine($"{week[number-1]} is a workday");
    }

}

Console.Write("Please, print day_number: ");
string day_number = Console.ReadLine();
int day_num = int.Parse(day_number);
Holidays(day_num);
