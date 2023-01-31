string num = Console.ReadLine();
int dl=num.Length;
int res = 0;
for(int i = 1; i<dl; i++)
{
    res = res + num[i];
}
System.Console.WriteLine(res);