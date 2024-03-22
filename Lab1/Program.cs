namespace Lab1
{
  internal class Program
  {
	static void Main(string[] args)
	{
	  //int age = 5;
	  //float grade = 5.521321f;
	  //double gpa = 2.312323;
	  //char letter = 'B';
	  //string name = "Vu";
	  //Console.WriteLine("age: " + age + ", grade: " + grade);
	  //Console.WriteLine("age: {0}, grade: {1:f1} ", age, grade);
	  //Console.WriteLine($"age: {age}, grade: {grade:f3}");

	  //Console.Write("Name");
	  //string tao = Console.ReadLine();
	  //Console.WriteLine($"name: {name}");

	  //Console.Write("num 1: ");
	  //int a = Int32.Parse(Console.ReadLine());

	  //Console.Write("num 2: ");
	  //int b = Int32.Parse(Console.ReadLine());
	  //int sum = a + b;
	  //Console.WriteLine($"Sum: {sum}");


	  //Console.Write("num 1: ");
	  //Double.TryParse(Console.ReadLine(), out double a);

	  //Console.Write("num 2: ");
	  //Double.TryParse(Console.ReadLine(), out double b);
	  //double sum = a + b;
	  //Console.WriteLine($"Sum: {sum:f2}");


	  //bool result = a > b;
	  //Console.WriteLine($"a > b: {result}");
	  //result = a < b;
	  //Console.WriteLine($"a < b: {result}");
	  //result = a == b;
	  //Console.WriteLine($"a = b: {result}");
	  //result = a != b;
	  //Console.WriteLine($"a != b: {result}");

	  //Console.WriteLine("-----If-else example----");
	  //if (a == b)
	  //{
	  //    Console.WriteLine("a = b");
	  //}
	  //else if (a < b)
	  //{
	  //    Console.WriteLine("a < b");
	  //}
	  //else if (a > b)
	  //{
	  //    Console.WriteLine("a > b");
	  //}



	  //Back-in-30-Minutes exercise
	  int hour;
	  int min;
	  do
	  {
		Console.Write("Hours: ");
		Int32.TryParse(Console.ReadLine(), out hour);
	  } while (0 < hour && hour > 23);

	  do
	  {
		Console.Write("Minutes: ");
		Int32.TryParse(Console.ReadLine(), out min);
	  } while (0 < min && min > 60);

	  int minplus30 = min + 30;

	  if (minplus30 >= 60 && hour >= 23)
	  {
		int minRemain = minplus30 - 60;
		hour = 0;
		Console.Write($"{hour}:{minRemain}");
	  }
	  else if(minplus30 >= 60)
	  {
		int minRemain = minplus30 - 60;
		hour++;
		Console.Write($"{hour}:{minRemain}");
	  }
	  else
	  {
		Console.Write($"{hour}:{minplus30}");
	  }


	  //Console.ReadKey();
	}
  }
}
