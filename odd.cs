int[] array = {7, 4, 6, 9, 10, 12, 18};
int n = array.Length;


int count = 0;
int index = 0;

while (index < n)
{
    if(array[index]%2==1)
    {
        count ++;
        index ++;
    }
    else
    {
        index ++;
    }

    index = index ++;
}
    Console.WriteLine(count);