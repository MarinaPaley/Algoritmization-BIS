namespace Task_1_1
{
    /// <summary>
    /// Главная программа.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args"> Список параметров. </param>
        static void Main(string[] args)
        {
            const double a = 2;
            const double b = 1;
            const double c = 3;

            double x = GetDouble("Введите x = ");
            double y = GetResult(a, b, c, x);

            Console.WriteLine($"x = {x}, y = {y}");
        }

        /// <summary>
        /// Получает значение функции.
        /// </summary>
        /// <param name="a"> Константа a.</param>
        /// <param name="b"> Константа b.</param>
        /// <param name="c"> Константа c.</param>
        /// <param name="x"> Аргумент функции.</param>
        /// <returns> Значение функции.</returns>
        private static double GetResult(double a, double b, double c, double x)
        {
            return (a * Math.Abs(x * x * x) + 5.0/2 * b * Math.Sqrt(x * x + 1)) / (c + Math.Sin(x) * Math.Cos(x));
        }

        /// <summary>
        /// Получает вещественное число из консоли.
        /// </summary>
        /// <param name="message"> Сообщение пользователю. </param>
        /// <returns> Вещественное число.</returns>
        private static double GetDouble(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            return double.Parse(input);
        }
    }
}
