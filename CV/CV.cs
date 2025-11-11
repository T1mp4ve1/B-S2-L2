using CV.classes;

namespace CV
{
    public class CV
    {
        public PersonalInfo GetPersonalInfo { get; set; }
        public Study GetUserStudy { get; set; }
        public Experiences GetUserExp { get; set; }
        public void startInfo()
        {
            //INFORMAZIONI PERSONALI
            PersonalInfo newUserPersonalInfo = new PersonalInfo();
            newUserPersonalInfo.personalInfoRequest();
            GetPersonalInfo = newUserPersonalInfo;

            //STUDI
            Study newUserStudy = new Study();
            newUserStudy.studyInfoRequest();
            GetUserStudy = newUserStudy;

            //ESPERIENZA
            Experiences newUserExp = new Experiences();
            newUserExp.expInfoRequest();
            GetUserExp = newUserExp;
        }
    }
}
