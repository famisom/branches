class Program
{
    static void sum(double x, double y) => Console.WriteLine(x + y);
    static void Main(string[] args)
    {
        bool tf = true;

        Console.WriteLine("Введите 2 числа:");
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());

        while (tf)
        {
            Console.Clear();

            Console.WriteLine("Меню:" +
                "\n1. Вывести числа" +
                "\n2. Найти сумму" +
                "\n3. Найти разность" +
                "\n4. Найти частное" +
                "\n5. Возвести в степень" +
                "\n6. Выйти");

            int res = Convert.ToInt32(Console.ReadLine());

            switch (res)
            {
                case 1:
                    wrt(x, y);
                    break;
                case 2:
                    sum(x, y);
                    break;
                case 3:
                    sub(x, y);
                    break;
                case 4:
                    div(x, y);
                    break;
                case 5:
                    pow(x, y);
                    break;
                default:
                    tf = false;
                    break;
            }

            Console.ReadKey();
        }
    }
}