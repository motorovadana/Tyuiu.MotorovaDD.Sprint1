namespace Tyuiu.MotorovaDD.Sprint1.Task2.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int x;
            Console.WriteLine("Введите значение x");
            x = ConvertMToKM(Console.ReadLine);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Известно расстояние в метрах");
            Console.ReadKey;
        }
    }
}
