// Поиск максимального элемента массива и его индекса.
// Массив заполняется рандомно.

Console.Clear();
void FillArray(int[] ar)
{
  int len = ar.Length;
  int ind = 0;
  while (ind < len)
  {
    ar[ind] = new Random().Next(1, 100);
    ind++;
  }
}

void PrintArray(int[] arr)
{
  int leng=arr.Length;
  int inde=0;
  while (inde<leng)
  {
    Console.Write(arr[inde] + " ");
    inde++;
  }
}

int Max(int[] ar)
{
  int max=0;
  int lengar=ar.Length;
  int index=0;
  while (index<lengar)
  {
    if (ar[index]>max)
    {
      max=ar[index];
    }
    index++;
  }
  return max;
}

int IndexOf(int[] ar, int find)
{
  int count=ar.Length;
  int innd=0;
  int position=-1;

  while (innd<count)
  {
    if (ar[innd]==find)
    {
      position=innd;
    }
    innd++;
  }
  return position;
}

int[] array= new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int maximum=Max(array);
int pos=IndexOf(array, maximum);
Console.WriteLine("Maximum = " + maximum);
Console.WriteLine("Index of maximum = " + pos);

