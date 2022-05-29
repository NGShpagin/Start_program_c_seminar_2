void Func(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Please, print number >=100 and <1000");
    }
    else if (number > 1000)
    {
        Console.WriteLine("Please, print number >=100 and <1000");
    }
    else
    {
        Console.WriteLine((number / 10)%10);
    }
}

Console.Write("Please, print number >=100 and <1000: ");
string our_number = Console.ReadLine();
int our_num = int.Parse(our_number);
Console.Write("The 2nd digit in your number: ");
Func(our_num);