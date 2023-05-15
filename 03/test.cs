class test
{
    public static void Main()
    {
        System.Console.WriteLine("整数を入力してください。");
        string text = System.Console.ReadLine();
        int money = int.Parse(text);

        if(money > 1000)
        {
            money = money - 100;
        }
        else if(money >= 1500)
        {
            money = money - 150;
        }

        System.Console.WriteLine(money);
    }
}