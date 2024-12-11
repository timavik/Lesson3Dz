namespace Lesson3DzOne
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Введите свой возраст");
      var a = Convert.ToInt32(Console.ReadLine());
      var anwer = "Столько не живут :)";
      if (a <= 2) { Console.WriteLine("Вы млоденец"); }
      else if (a <= 12) { anwer = "Вы ребёнок"; }
      else if (a <= 17) { anwer = "Вы подросток"; }
      else if (a <= 59) { anwer = "Вы взрослый"; }
      else if (a >= 60 && a <= 499) { anwer = "Вы пожилой"; }
      
      var cht = (a % 2 == 0) ? "чётный" : "нечётный";

      Console.WriteLine($"Ваш возраст: {a}");
      Console.WriteLine(anwer);
      Console.WriteLine($"Ваш возраст является {cht} числом");
    }
  }
}
