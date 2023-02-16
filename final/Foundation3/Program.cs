using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Lectures lecture = new Lectures("General Conference", "Is the worldwide gathering of The Church of Jesus Christ of Latter-day Saints. Church leaders share messages focused on Jesus Christ and His gospel.", "April 1, 2023", "10:00 AM", "Russel M. Nelson", 21000);
        EventAddress lectureAddress = new EventAddress("60 N W Temple St, Salt Lake City, UT 84150");
        lecture.ShortDetails.Add(lecture.ToString());
        
        Receptions receptions = new Receptions("Rodizio", "Our traditional Brazilian Steakhouse (churrascaria) is the perfect place for a night out.", "February 25, 2023", "7:00 pm", "edisson.ruiz21@gmail.com");
        EventAddress receptionAddress = new EventAddress("4801 N University Ave, Ste 710, Provo, UT 84604");
        receptions.ShortDetails.Add(receptions.ToString());

        Outdoor outdoor = new Outdoor("Thanksgiving Point", "Spring at Thanksgiving Point means the Tulip Festival Race Series is finally here!", "April 29, 2023", "7:30 am - 11:59 pm", "Sunny, 70°");
        EventAddress outdoorAddress = new EventAddress("3003 Thanksgiving Wy, Lehi, UT 84043");
        outdoor.ShortDetails.Add(outdoor.ToString());

        Event eventMain = new Event();

        int userMenuChoice = 0;
        List<string> menu = new List<string>()
        {
            "Event Agenda: ",
            "What kind of event do you want to see?: ",
            "   1. Lectures",
            "   2. Receptions",
            "   3. Outdoor",
            "   4. Quit" 
        };

        while (userMenuChoice != 4)
        {   
            Console.WriteLine();
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            Console.WriteLine("Selet a choice from menu: ");
            userMenuChoice = int.Parse(Console.ReadLine());
            
            switch (userMenuChoice)
            {
                case 1:
                    eventMain.DisplayMenu();
                    int userChoiceCase1 = int.Parse(Console.ReadLine());
                    if (userChoiceCase1 == 1)
                    {
                        lecture.GetStandardDetails(lectureAddress.Address);
                    }
                    else if (userChoiceCase1 == 2)
                    {
                        lecture.GetFullDetails(lectureAddress.Address);            
                    }
                    else if (userChoiceCase1 == 3)
                    {
                        lecture.GetShortDetails();
                    }
                    break;
                    
                case 2:
                    eventMain.DisplayMenu();
                    int userChoiceCase2 = int.Parse(Console.ReadLine());
                    if (userChoiceCase2 == 1)
                    {
                        receptions.GetStandardDetails(receptionAddress.Address);
                    }
                    else if (userChoiceCase2 == 2)
                    {
                        receptions.GetFullDetails(receptionAddress.Address);            
                    }
                    else if (userChoiceCase2 == 3)
                    {
                        receptions.GetShortDetails();
                    }
                    break;

                case 3:
                    eventMain.DisplayMenu();
                    int userChoiceCase3 = int.Parse(Console.ReadLine());
                    if (userChoiceCase3 == 1)
                    {
                        outdoor.GetStandardDetails(outdoorAddress.Address);
                    }
                    else if (userChoiceCase3 == 2)
                    {
                        outdoor.GetFullDetails(outdoorAddress.Address);            
                    }
                    else if (userChoiceCase3 == 3)
                    {
                        outdoor.GetShortDetails();
                    }
                    break;
            }
        } 
    }
}