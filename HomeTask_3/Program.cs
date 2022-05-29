void Func(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Please, print number >=100");
    }
    else
    {
        while (number >= 1000)
        {
            number = number / 10; 
        }
    int third_number = number % 10;
    Console.WriteLine(third_number);
    }
}

Console.Write("Please, print number >=100: ");
string our_number = Console.ReadLine();
int our_num = int.Parse(our_number);
Console.Write("The 3rd digit in your number: ");
Func(our_num);