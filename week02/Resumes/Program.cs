using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job Job1 = new Job();
        Job1._company = "Transamigos Transport SA";
        Job1._jobTitle = "Accounting Assistent";
        Job1._startYear = 2021;
        Job1._endYear = 2025;

       

        Job Job2 = new Job();
        Job2._company = "Microsoft";
        Job2._jobTitle = "Enginner";
        Job2._startYear = 2019;
        Job2._endYear = 2024;

        

        Resume myResume = new Resume();
        myResume._name = "Willian Ramos";

        // Adicionando os jobs ao currículo
        myResume._jobs.Add(Job1);
        myResume._jobs.Add(Job2);

        myResume.GetDisplay();

       



          
            
        
        
    }
}