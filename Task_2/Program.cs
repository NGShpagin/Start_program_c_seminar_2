void Function(double number1, double number2)
{
    if(number1 >= number2)
    {
        if(number1 % number2 == 0)
        {
            Console.WriteLine("Кратно");
        }
        else
        {
            Console.WriteLine($"Не кратно. Остаток: {number1 % number2}. Значение: {number1 / number2}");
        }
    }
    else
    {
        if(number2 % number1 == 0)
        {
              Console.WriteLine("Кратно");
        }
        else
        {
            Console.WriteLine($"Не кратно. Остаток: {number2 % number1}. Значение: {number2 / number1}");
        }
    }
}

Function(45,7);