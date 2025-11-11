namespace CV.classes
{
    public class Study
    {
        public string? Qual { get; set; }
        public string? Institute { get; set; }
        public string? TypeOfInst { get; set; }
        public string? FromToStud { get; set; }

        public void studyInfoRequest()
        {
            Console.Clear();
            Console.WriteLine("""

                Inserisci i tuoi studi:

                """);
            Console.Write("Qualifica: ");
            Qual = infoRequest.infoString();
            Console.Write("Istituto: ");
            Institute = infoRequest.infoString();
            Console.Write("Tipo: ");
            TypeOfInst = infoRequest.infoString();
            Console.Write("Dal al: ");
            FromToStud = infoRequest.infoString();
        }
    }
}
