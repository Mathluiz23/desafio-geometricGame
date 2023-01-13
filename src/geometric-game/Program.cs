namespace diamond_game;
public class Program
{

  public static void Main()
  {
    Console.WriteLine("Digite uma letra de A a Z");
    var letter = Console.ReadLine();

    if (letter.Length > 1)
    {
      Console.WriteLine("Você digitou mais de uma letra, por favor digite apenas uma letra de A a Z");
      letter = Console.ReadLine();
    }
    DiamondGame.GenerateDiamond(letter);

    Console.WriteLine("Você deseja transformar o diamante em um triangulo? S/N");
    var transform = Console.ReadLine();

    if (transform == "S" || transform == "s")
    {
      Triangle.TransformTriangle(letter);
    }
    else
    {
      Console.WriteLine("Obrigado por utilizar o programa!");
    }
  }
}
