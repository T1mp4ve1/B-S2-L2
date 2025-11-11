namespace CV.classes
{
    public class Experiences
    {
        public string? Agency { get; set; }
        public string? JobTitle { get; set; }
        public string? FromToEsp { get; set; }

        public void expInfoRequest()
        {
            Console.WriteLine("""

                Inserisci le tue esperienze:

                """);
            Console.Write("Azienda: ");
            Agency = infoRequest.infoString();
            Console.Write("Tipo: ");
            JobTitle = infoRequest.infoString();
            Console.Write("Dal al: ");
            FromToEsp = infoRequest.infoString();
        }
    }
}
