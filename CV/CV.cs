using CV.classes;

namespace CV
{
    public class CV
    {
        public PersonalInfo GetPersonalInfo { get; set; }
        public List<Study> GetUserStudy { get; set; } = new List<Study>();
        public List<Experiences> GetUserExp { get; set; } = new List<Experiences>();
        public void startInfo()
        {
            //INFORMAZIONI PERSONALI
            PersonalInfo newUserPersonalInfo = new PersonalInfo();
            newUserPersonalInfo.personalInfoRequest();
            GetPersonalInfo = newUserPersonalInfo;

            //STUDI
            bool endStudy = false;
            do
            {
                Study newUserStudy = new Study();
                newUserStudy.studyInfoRequest();
                GetUserStudy.Add(newUserStudy);

                Console.WriteLine("""

                Voi aggiungere altri studi?
                1.No
                2.Si

                """);


                string? input = Console.ReadLine()?.Trim();

                switch (input)
                {
                    case "1":
                        endStudy = true;
                        break;
                    case "2":
                        break;
                    default:
                        Console.WriteLine("Devi inserire 1 o 2");
                        Console.WriteLine("Premi un pulsante");
                        Console.ReadKey();
                        break;
                }
            } while (!endStudy);

            //ESPERIENZA


            bool endExp = false;
            do
            {
                Experiences newUserExp = new Experiences();
                newUserExp.expInfoRequest();
                GetUserExp.Add(newUserExp);
                Console.WriteLine("""

                Voi aggiungere altre esperienze?
                1.No
                2.Si

                """);

                string? input = Console.ReadLine()?.Trim();

                switch (input)
                {
                    case "1":
                        endExp = true;
                        break;
                    case "2":
                        break;
                    default:
                        Console.WriteLine("Devi inserire 1 o 2");
                        Console.WriteLine("Premi un pulsante");
                        Console.ReadKey();
                        break;
                }
            } while (!endExp);
        }
    }
}
