class Kadai
{
	public static void Main()
	{
		string text = System.Console.ReadLine();
		int money = int.Parse(text);

		if(money >= 2000)
		{
			System.Console.WriteLine("キャンペーン対象です。");
			money = money - 200;
		}
		else if(money >= 1500)
		{
			System.Console.WriteLine("キャンペーン対象です。");
			money = money - 150;
		}
		else if(money > 1000)
		{
			System.Console.WriteLine("キャンペーン対象です。");
			money = money - 100;
		}
		else
		{
			System.Console.WriteLine("キャンペーン対象外です。");
		}

		System.Console.WriteLine(money);
	}
}