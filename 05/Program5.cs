class Program5
{
	public static void Main()
	{
		int[] x = new int[3];

		x[0] = 2;
		x[1] = 0;
		x[2] = 10;

		for(int i=0;i<3;i++)
		{
			System.Console.WriteLine(x[i]);
		}


		int[] a = new int[10];
		a[0] = 2;

		for(int i=1;i<10;i++)
		{
			a[i] = 3 * a[i-1] + 2;
		}

		for(int i=0; i<10; i++)
		{
			System.Console.WriteLine(a[i]);
		}
	}
}