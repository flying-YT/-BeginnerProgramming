class Program4
{
	public static void Main()
	{
		int count = 0;
		for(int i=1;i<=10;i++)
		{
			count++;
			if(count%2 == 0)
			{
				System.Console.WriteLine("count=" + count);
			}
		}
	}
}