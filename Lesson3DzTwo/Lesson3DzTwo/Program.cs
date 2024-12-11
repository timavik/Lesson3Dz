namespace Lesson3DzTwo
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Введите первое значение (true/false): ");
      bool a = bool.Parse(Console.ReadLine());

      Console.Write("Введите второе значение (true/false): ");
      bool b = bool.Parse(Console.ReadLine());

      bool andResult = a & b;
      bool orResult = a | b;
      bool xorResult = a ^ b;
      bool andAndResult = a && b;
      bool orOrResult = a || b;
      bool notResultA = !a;
      bool notResultB = !b;

      Console.WriteLine("Результаты логических операций:");
      Console.WriteLine("Операция|Результат");
      Console.WriteLine("a & b    {0}\n", andResult);
      Console.WriteLine("a | b    {0}\n", orResult);
      Console.WriteLine("a ^ b    {0}\n", xorResult);
      Console.WriteLine("a && b    {0}\n", andAndResult);
      Console.WriteLine("a || b    {0}\n", orOrResult);
      Console.WriteLine("!  a    {0}\n", notResultA);
      Console.WriteLine("!  b    {0}\n", notResultB);
    }
  }
}
