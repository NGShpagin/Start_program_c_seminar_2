int LastNumber(int number)
{
    int number1 = number % 10;
    int number2 = number / 10;
    if(number2>number1)
    {
        return number2;
    } 
    else
    {
        return number1;
    }
}

int RandomNumber = new Random().Next(10, 100);
Console.WriteLine(LastNumber(RandomNumber));
Console.WriteLine(RandomNumber);