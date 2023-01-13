namespace diamond_game;
public class Program
{

  public static void Main()
  {
    Console.WriteLine("Digite uma letra de A a Z");
    var letter = Console.ReadLine();

    DiamondGame.GenerateDiamond(letter);

  }
}
