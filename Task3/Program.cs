
Random rand = new Random();
int [] array = new int[8];
for(int i =0; i<array.Length; i++)
{
    array[i] = rand.Next(0,100);
}
System.Console.WriteLine(string.Join(", ", array));
