namespace Lab2
{
  internal class Program
  {
	static void Main(string[] args)
	{
	  int[] arr = { 5, 7, 3, 8, 2, 7, 1 };
	  int temp = arr[0];
	  for (int i = 0; i < arr.Length; i++)
	  {
		for (int j = i + 1; j < arr.Length; j++)
		{
		  if (arr[i] > arr[j])
		  {
			temp = arr[i];
			arr[i] = arr[j];
			arr[j] = temp;
		  }
		}
	  }
	}
  }
}
