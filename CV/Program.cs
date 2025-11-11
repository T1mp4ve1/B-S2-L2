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
        foreach (var exp in cv.GetUserStudy)
        {
            Console.WriteLine($"Qualifica: {exp.Qual}");
            Console.WriteLine($"Istituto: {exp.Institute}");
            Console.WriteLine($"Tipo: {exp.TypeOfInst}");
            Console.WriteLine($"Dal/Al: {exp.FromToStud}\n");
        }


        Console.WriteLine("\nESPERIENZE:");
        foreach (var exp in cv.GetUserExp)
        {
            Console.WriteLine($"Esperienza presso: {exp.Agency}");
            Console.WriteLine($"Ruolo: {exp.JobTitle}");
            Console.WriteLine($"Periodo: {exp.FromToEsp}\n");
        }

    }
}