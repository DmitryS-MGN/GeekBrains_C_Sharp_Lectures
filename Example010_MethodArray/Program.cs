int[] array = { 10, 12, 33, 41, 35, 64, 57, 18, 29, 64 };
int n = array.Length;
int find = 64;
int index = 0;
while(index < n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    index++;
}