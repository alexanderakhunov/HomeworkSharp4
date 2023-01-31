int inputNumber(string str)
{
    int number;
    string text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();

        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Неверное число");
    }
    return number;
}

// 
int num = inputNumber("Введите число ");
int SR = inputNumber("Введите степень ");
int SQR(int number)
{
int res = 1;
for (int i = 1; i<=SR; i++)
{
res *=num;
}
return res;
}
int result = SQR(SR);
System.Console.WriteLine(result);