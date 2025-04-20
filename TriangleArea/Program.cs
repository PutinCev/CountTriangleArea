namespace TriangleSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Посчитаем площадь равностороннего треугольника. Для этого введите, пожалуйста, длину периметра");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("Сторона                       Площадь");
            double storona = p/3;
            double pp = p/2;
            double square = Math.Sqrt(pp*(pp-storona)* (pp - storona)* (pp - storona));
            Console.WriteLine($"{storona}      {square}");
        }
    }
}
