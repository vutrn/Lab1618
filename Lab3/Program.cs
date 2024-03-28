Console.Write("Input number of students: ");
int nums = Int32.Parse(Console.ReadLine());
string[] names = new string[nums];
double[] grades = new double[nums];

for (int i = 0; i < names.Length; i++)
{
  Console.Write("Enter student name: ");
  names[i] = Console.ReadLine();
}

for (int i = 0; i < grades.Length; i++)
{
  Console.Write("Enter student grade: ");
  grades[i] = double.Parse(Console.ReadLine());
}

for (int i = 0; i < names.Length - 1; i++)
{
  Console.Write($"{names[i]}: {grades[i]:f2}, ");
  // if the last array, end it with dot.
  
  if(i == names.Length){
    Console.Write($"{names[i]}: {grades[i]:f2}.");
  }
}



//string[] names = { "Anh", "Toan", "Tu", "Hieu", "Giang", "Long", "Khanh", "Vu", "Vinh" };
// string[] names = new string[9];

// double[] grades = new double[9];

// for (int i = 0; i < names.Length; i++)
// {
//   Console.WriteLine($"Enter {names[i]} grade:");
//   grades[i] = double.Parse(Console.ReadLine());
// }




// Console.ReadKey();