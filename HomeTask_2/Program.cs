int Func(int number)
{
    int result = (number / 100)*10 + (number % 10);
    return result;
}

int random_number = new Random().Next(100, 1000);
Console.WriteLine($"Random number: {random_number}");
Console.Write($"Random number without 2nd digit: ");
Console.WriteLine(Func(random_number));