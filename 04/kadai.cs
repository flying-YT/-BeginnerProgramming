class Program4
{
	public static void Main()
	{
		int count = 0;
		for(int i=0;i<30;i++)
		{
			count++;
			System.Console.WriteLine("count=" + count);
			if(count%2 == 0)
			{
				System.Console.WriteLine("偶数");
			}
			else
			{
				System.Console.WriteLine("奇数");
			}
		}
	}
}