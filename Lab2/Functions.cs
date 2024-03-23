namespace Lab2
{
   class Functions
  {
	//switch-case
	public static void print_month()
	{
	  Console.WriteLine("Month: ");
	  int.TryParse(Console.ReadLine(), out int month);
	  switch (month)
	  {
		case 1: Console.WriteLine("January"); break;
		case 2: Console.WriteLine("February"); break;
		case 3: Console.WriteLine("March"); break;
		case 4: Console.WriteLine("April"); break;
		case 5: Console.WriteLine("May"); break;
		case 6: Console.WriteLine("June"); break;
		case 7: Console.WriteLine("July"); break;
		case 8: Console.WriteLine("August"); break;
		case 9: Console.WriteLine("September"); break;
		case 10: Console.WriteLine("October"); break;
		case 11: Console.WriteLine("November"); break;
		case 12: Console.WriteLine("December"); break;
		default: Console.WriteLine("Error"); break;
	  }
	}

	//for
	public static void for_example()
	{
	  Console.Write("Enter int number: ");
	  int n = int.Parse(Console.ReadLine());
	  int sum = 0;
	  for (int i = 0; i < n; i++)
	  {
		int odd_sum = 2 * i + 1;
		sum += odd_sum;
		Console.WriteLine($"Number: {odd_sum}");
	  }
	  Console.WriteLine($"Sum: {sum}");
	}

	//while
	public static void multiplication_table()
	{
	  Console.Write("Input a number: ");
	  var number = int.Parse(Console.ReadLine());
	  var times = 1;
	  while (times <= 10)
	  {
		Console.WriteLine($"{number} X {times} = {number * times}");
		times++;
	  }

	}
  }
}
