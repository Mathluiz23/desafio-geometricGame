
namespace diamond_game;
public class DiamondGame
{

  public static void GenerateDiamond(string letter)
  {
    letter = letter.ToUpper();

    var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    var letterIndex = alphabet.IndexOf(letter);


    var diamond = "";

    for (var i = 0; i <= letterIndex; i++)
    {
      var line = new string(' ', letterIndex - i);
      line += alphabet[i];
      if (i > 0)
      {
        line += new string(' ', i * 2 - 1);
        line += alphabet[i];
      }
      diamond = diamond + line + Environment.NewLine;
      Console.WriteLine(line);
    }
    for (var i = letterIndex - 1; i >= 0; i--)
    {
      var line = new string(' ', letterIndex - i);
      line += alphabet[i];
      if (i > 0)
      {
        line += new string(' ', i * 2 - 1);
        line += alphabet[i];
      }
      diamond = diamond + line + Environment.NewLine;
      Console.WriteLine(line);

    }
    Console.WriteLine("Sua figura é um diamante");
  }
}



