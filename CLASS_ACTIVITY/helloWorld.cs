using System;

class Sum 
{ 
	public int Add(int num1,int num2)
	{
		return num1 + num2;
	}
}

class Program
{   

	public static void Main(string[] args)
	{
		Console.WriteLine("Hello World!");

		Sum sum = new Sum();
		int result = sum.Add(5, 10);

		Console.WriteLine(result);
    }

}