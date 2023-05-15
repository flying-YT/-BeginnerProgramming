class Program3_1
{
	public static void Main()
	{
		System.Console.WriteLine("整数を入力してください。");
		string text = System.Console.ReadLine();
		int age = int.Parse(text);

		if(age == 20)
		{
			System.Console.WriteLine("20歳です。");
		}
		else if(age == 19)
		{
			System.Console.WriteLine("来年20歳です。");
		}
		else
		{
			System.Console.WriteLine("20歳ではないです。");
		}
	}
}