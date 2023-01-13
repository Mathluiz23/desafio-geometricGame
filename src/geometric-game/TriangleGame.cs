namespace diamond_game;

public class Triangle

{

  internal static void TransformTriangle(string letter)
  {
    var triangle = "";
    var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    int letterIndex = alphabet.IndexOf(letter);

    if (letter == "A" || letter == "B")
    {
      TriangleRepeatLetter(letter);
    }

    else
    {
      letterIndex = alphabet.IndexOf(letter);
    }

    for (var i = 0; i <= letterIndex; i++)
    {
      var line = new string(' ', letterIndex - i);
      line += alphabet[i];
      if (i > 0)
      {
        line += new string(' ', i * 2 - 1);
        line += alphabet[i];
      }
      triangle = triangle + line + Environment.NewLine;
      Console.WriteLine(line);
    }
    Console.WriteLine("Sua figura é um triangulo");
    Report.GenerateReport(triangle, letter);
  }

  private static void TriangleRepeatLetter(string letter)
  {
    var triangle = "";
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
        triangle = triangle + line + Environment.NewLine;
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
        triangle = triangle + line + Environment.NewLine;
        Console.WriteLine(line);
      }
    }
    Console.WriteLine("Sua figura é um triangulo");
    Report.GenerateReport(triangle, letter);
  }
}
