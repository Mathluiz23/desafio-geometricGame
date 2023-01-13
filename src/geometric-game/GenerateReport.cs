namespace diamond_game;
public class Report
{

  public static void GenerateReport(string geometric, string letter)
  {
    Console.WriteLine("Deseja gerar um relatório no formato pdf? (S/N)");
    var generatePDF = Console.ReadLine();

    if (generatePDF == "S" || generatePDF == "s")
    {
      PDFService.GeneratePDF(geometric);
      Console.WriteLine(geometric);
    }

    Console.WriteLine("Deseja enviar o resultado por email ? (S/N)");
    var sendEmail = Console.ReadLine();

    if (sendEmail == "S" || sendEmail == "s")
    {
      Console.WriteLine("Digite o email para o envio do relatório");
      var emailRecipient = Console.ReadLine();

      _ = EmailService.EnviarEmail(emailRecipient, "Relatório da figura geométrica", "Segue em anexo o relatório da figura \n" + geometric, "");

      Console.WriteLine("Obrigado por utilizar o programa!");
    }
    else
    {
      Console.WriteLine("Obrigado por utilizar o programa!");
    }
  }
}
