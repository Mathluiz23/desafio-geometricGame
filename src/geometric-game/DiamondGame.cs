
namespace diamond_game;
public class DiamondGame
{

  public static void GenerateDiamond(string letter)
  {
    letter = letter.ToUpper();

    var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    int letterIndex = 0;

    if (letter == "A" || letter == "B")
    {
      DiamondRepeatLetter(letter);
    }

    else
    {
      letterIndex = alphabet.IndexOf(letter);
    }

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
    Report.GenerateReport(diamond, letter);
  }

  private static void DiamondRepeatLetter(string letter)

  {
    var diamond = "";
    if (letter == "A")
    {
      for (var i = 0; i <= 2; i++)
      {
        var line = new string(' ', 2 - i);
        line += "A";
        if (i > 0)
        {
          line += new string(' ', i * 2 - 1);
          line += "A";
        }
        diamond = diamond + line + Environment.NewLine;
        Console.WriteLine(line);
      }

      for (var i = 1; i >= 0; i--)
      {
        var line = new string(' ', 2 - i);
        line += "A";
        if (i > 0)
        {
          line += new string(' ', i * 2 - 1);
          line += "A";
        }
        diamond = diamond + line + Environment.NewLine;

        Console.WriteLine(line);
      }
    }
    else
    {
      for (var i = 0; i <= 3; i++)
      {
        var line = new string(' ', 3 - i);
        line += "B";
        if (i > 0)
        {
          line += new string(' ', i * 2 - 1);
          line += "B";
        }
        diamond = diamond + line + Environment.NewLine;
        Console.WriteLine(line);
      }

      for (var i = 2; i >= 0; i--)
      {
        var line = new string(' ', 3 - i);
        line += "B";
        if (i > 0)
        {
          line += new string(' ', i * 2 - 1);
          line += "B";
        }
        diamond = diamond + line + Environment.NewLine;
        Console.WriteLine(line);
      }
    }
    Console.WriteLine("Sua figura é um diamante");
    Report.GenerateReport(diamond, letter);
  }
}



