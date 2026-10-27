namespace Task_1_2
{
    /// <summary>
    /// Программа.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args"> Аргументы.</param>
        static void Main(string[] args)
        {
            double radius = GetDouble("Введите радиус = ");
            double height = GetDouble("Введите высоту = ");

            double area = GetArea(radius, height);

            Console.WriteLine($"Площадь боковой поверхности цилиндра = {area}");
        }

        /// <summary>
        /// Рассчитывает площадь поверхности цилиндра.
        /// </summary>
        /// <param name="radius"> Радиус основания. </param>
        /// <param name="height"> Высота. </param>
        /// <returns></returns>
        private static double GetArea(double radius, double height)
        {
            return 2* Math.PI*radius * height;
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
