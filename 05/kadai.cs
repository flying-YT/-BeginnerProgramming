class Program5
{
	public static void Main()
	{
		int[] a = new int[21];
		a[1] = 3;

		for(int i=2; i<21; i++)
		{
			a[i] = a[i-1] + 2;
		}

		for(int i=1; i<21; i++)
		{
			System.Console.WriteLine(a[i]);
		}
	}
}