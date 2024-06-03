using System.Collections.Generic;

class kadai
{
	public static void Main()
	{
		List<int> list = new List<int>();

		for(int i=0;i<10;i++)
		{
			list.Add(i);
		}

		list.Add(100);
		list.Add(200);

		foreach(int i in list)
		{
			System.Console.WriteLine(i);
		}
	}
}