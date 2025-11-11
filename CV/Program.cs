namespace CV;
public class Program
{
    public static void Main()
    {
        CV newCV = new CV();
        newCV.startInfo();
        StampaDettagliCVSuSchermo(newCV);
    }

    public static void StampaDettagliCVSuSchermo(CV cv)
    {
        Console.Clear();
        Console.WriteLine("\n=========== CURRICULUM VITAE ===========\n");

        Console.WriteLine("INFORMAZIONI PERSONALI:");
        Console.WriteLine($"Nome: {cv.GetPersonalInfo.Name}");
        Console.WriteLine($"Cognome: {cv.GetPersonalInfo.LastName}");
        Console.WriteLine($"Telefono: {cv.GetPersonalInfo.Tel}");
        Console.WriteLine($"Email: {cv.GetPersonalInfo.Email}");

        Console.WriteLine("\nSTUDI EFFETTUATI:");
        Console.WriteLine($"Qualifica: {cv.GetUserStudy.Qual}");
        Console.WriteLine($"Istituto: {cv.GetUserStudy.Institute}");
        Console.WriteLine($"Tipo: {cv.GetUserStudy.TypeOfInst}");
        Console.WriteLine($"Dal/Al: {cv.GetUserStudy.FromToStud}");

        Console.WriteLine("\nESPERIENZE:");
        Console.WriteLine($"Esperienza presso: {cv.GetUserExp.Agency}");
        Console.WriteLine($"Ruolo: {cv.GetUserExp.JobTitle}");
        Console.WriteLine($"Periodo: {cv.GetUserExp.FromToEsp}");

    }
}