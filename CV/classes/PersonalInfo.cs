namespace CV.classes
{
    public class PersonalInfo
    {
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Tel { get; set; }
        public string? Email { get; set; }

        public void personalInfoRequest()
        {
            Console.WriteLine("""
                Inserisci i tuoi dati personali:

                """);
            Console.Write("Nome: ");
            Name = infoRequest.infoString();
            Console.Write("Congome: ");
            LastName = infoRequest.infoString();
            Console.Write("Telefono: ");
            Tel = infoRequest.infoString();
            Console.Write("email: ");
            Email = infoRequest.infoString();
        }
    }
}
