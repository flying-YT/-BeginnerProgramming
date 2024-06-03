using System.Collections.Generic;

class Program6
{
	public static void Main()
	{
		List<string> list = new List<string>();

		list.Add("Hello");
		list.Add("World");
		list.Add("!!!");

		for(int i=0; i<3; i++)
		{
			System.Console.WriteLine(list[i]);
		}

		foreach(string text in list)
		{
			System.Console.WriteLine(text);	
		}

		list.Add("list add");
		list.Add("test");

		foreach(string text in list)
		{
			System.Console.WriteLine(text);	
		}

		list.Remove("!!!");

		foreach(string text in list)
		{
			System.Console.WriteLine(text);	
		}
	}
}