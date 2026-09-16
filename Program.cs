
 //Hårdkodad version: 

Course english = new Course ("English", 2);
Course programming = new Course ("Programming", 3);

Student simon = new Student("Simon");
Student eric = new Student("Eric");
Student lennita = new Student("Lennita");
Student jonna = new Student("Jonna");



/*
//Skapar kurser
Course english = new Course("English", 2);
Course programming = new Course("Programming", 3);

//Lista över alla skapade studenter, så vi kan hitta dem igen
List<Student> allStudents = new List<Student>();

bool KeepGoing = true;//Bool som gör att while loopen fortsätter

while (KeepGoing)//While loop som gör att man kan fortsätta
{
    Console.WriteLine();
    Console.WriteLine("Enter a student name (or 'stop' to finish):");
    string? name = Console.ReadLine();

    if (name?.ToLower() == "stop")//Kollar om man vill sluta, om ja så avslutas loopen
    {
        KeepGoing = false;//Stänger av loopen
        continue;//Hoppar över resten av loopen
    }

    Student? student = null;//Skapar en student variabel som är null, så vi kan kolla om studenten finns i listan

    foreach(Student s in allStudents)//Kollar om studenten redan finns i listan, om ja så sätter vi student variabeln till den studenten
    {
        if (s. Name == name)
        {
            student = s;
            break;
        }
    }
Console.WriteLine("Would you like to join, leave or see schedule?");//Frågar vad studenten vill göra
Console.WriteLine("Write: join / leave / schedule");//Skriver ut alternativen
string? choice = Console.ReadLine();

string action = choice?.ToLower() ?? " ";//Gör om valet till små bokstäver, så vi kan jämföra det med våra alternativ

if (action == "join")//Kollar om studenten vill gå med i en kurs
    {
        if (student == null)
    {
            student = new Student(name!);
            allStudents.Add(student);
        }
        Console.WriteLine("Which course? (english/programming)");//Frågar vilken kurs studenten vill gå med i
        string? courseChoice = Console.ReadLine();

        Course validCourse;

        switch (courseChoice?.ToLower())//Gör om kurs valet till små bokstäver, så vi kan jämföra det med våra alternativ
        {
            case "english":
            validCourse = english;
            break;
            
            case "programming":
            validCourse = programming;
            break;
            
            default://Om kursen inte finns, skriv ut ett meddelande och fortsätt loopen
            Console.WriteLine("Unknown course, please try again.");
            continue;

    }

    student.Join(validCourse);//Kallar på studentens Join metod, som i sin tur kallar på kursens Enroll metod {}
    
}
        else if (action == "leave")//Kollar om studenten vill lämna en kurs
        {
            if (student == null)
            {
                Console.WriteLine(name + " is not enrolled in any course yet.");
                continue;
            }
        {
            if (student == null)
            {
                Console.WriteLine(name + " is not enrolled in any course yet.");
                continue;
            }
 

            Console.WriteLine("Which course? (english/programming)");//Frågar vilken kurs studenten vill lämna
            string? courseChoice = Console.ReadLine();

            Course validCourse;

            switch (courseChoice?.ToLower())//Gör om kurs valet till små bokstäver, så vi kan jämföra det med våra alternativ
        {
            case "english":
            validCourse = english;
            break;

            case "programming":
            validCourse = programming;
            break;

            default:
            Console.WriteLine("Course unknown, please try again");
            continue;

        }
      
        student.Leave(validCourse);//Kallar på studentens Leave metod, som i sin tur kallar på kursens Remove metod
        }
        else if (action == "schedule")
        {
            if (student == null)
            
        {
        Console.WriteLine(name + "is not enrolled in any course");
        }
        else
        {
            student.Schedule();
        }
    }
    
else//Om valet inte är join, leave eller schedule, skriv ut ett meddelande
{
    Console.WriteLine("Option unknown, please write 'join', 'leave' or 'schedule' .");
}
}
Console.WriteLine();
Console.WriteLine("----Result----");

Console.WriteLine(english);
english.RollCall();

Console.WriteLine();

Console.WriteLine(programming);
programming.RollCall();
*/
