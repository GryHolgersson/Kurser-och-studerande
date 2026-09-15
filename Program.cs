/*Del B — Kurser och studerande (klasser och objekt)
Skriv ett litet system för kurser och studerande, som modellerar hur de hör ihop åt båda hållen: en
kurs har flera studerande, och en studerande kan gå flera kurser.
Det här är ett C#-projekt (skapat med dotnet new console, se instruktionerna i samlingsartikeln från
första lektionen i kursen). Varje klass ligger i en egen fil, och du "provkör" dem genom att skapa
objekt och anropa metoder i Program.cs.
Du ska ha (minst) två klasser:
Course (i filen Course.cs)
● Fält: Name, en kapacitet MaxSeats (max antal platser), och en lista Students.
● Metod Enroll(student) — anmäler en studerande till kursen, om det finns plats.
● Metod Remove(student) — tar bort en studerande ur kursen.
● Metod RollCall() — skriver ut alla studerande i kursen.
● En ToString() som t.ex. ger "Matematik (2/5 platser)".
Student (i filen Student.cs)
● Fält: Name och en lista Courses.
● Metod Join(course) — går med i en kurs.
● Metod Leave(course) — lämnar en kurs.
● Metod Schedule() — skriver ut vilka kurser den studerande går.
● En ToString() med den studerandes namn.
● Reglerna som gör uppgiften — det är här logiken sitter:
Båda hållen ska alltid stämma: Anmäler du en studerande till en kurs (oavsett om du gör det via
kursens Enroll eller den studerandes Join) ska studeranden hamna i kursens Students och kursen i
studerandens Courses. Samma sak vid borttagning.
Inga dubletter. Samma studerande får inte hamna två gånger i en kurs, hur många gånger man än
anmäler.
Kapacitet. En kurs kan inte ta in fler än MaxSeats studerande — säg till (t.ex. "Kursen är full") i stället
för att lägga till.
Ingen krasch får ske om man försöker ta bort en studerande som inte är anmäld.
I Program.cs: Skapa några kurser och några studerande, anmäl och avanmäl dem åt olika håll, och
skriv ut med RollCall() och Schedule() så att det syns att båda hållen hänger ihop och att reglerna
ovan fungerar (t.ex. att en full kurs säger nej, och att dubbelanmälan inte ger dubbletter).*/

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

    Console.WriteLine("Would you like to join, leave, schedule or list a course? (join/leave/list)");
    //Låter användaren välja om de vill gå med i eller lämna en kurs samt om de vill få upp en lista på alla studenter i kursen 
    // och en lista på alla kurser studenten går
    string? choice = Console.ReadLine();

    Console.WriteLine("Which course? (english/programming)");//Låter användaren välja kurs
    string? CourseChoice = Console.ReadLine();

    Course vaildCourse;//Skapar en variabel som ska innehålla kursen användaren valt
    switch (CourseChoice?.ToLower())//Kollar vilken kurs användaren valt
    {
        case "english"://Om användaren valt english, sätt vaildKurs till english
            vaildCourse = english;
            break;
        case "programming"://Om användaren valt programming, sätt vaildKurs till programming
            vaildCourse = programming;
            break;
        default://Om användaren valt något annat än english eller programming, skriv ut ett felmeddelande och fortsätt loopen
            Console.WriteLine("Unknown course, please try again.");
            continue;
    }
    {
        if (choice?.ToLower() == "list")//Om användaren valt att lista alla studenter i kursen
        {
            vaildCourse.RollCall();//Skriver ut alla studenter i kursen
            continue;//Hoppar över resten av loopen
        }
        {
            if (choice?.ToLower() == "schedule")
            {
                validCourse.Schedule();//Skriver ut alla kurser studenten går
                continue;//Hoppar över resten av loopen
            }
        }
    }
    //Letar efter en redan skapad student med samma namn
    Student? student = null;//Skapar en variabel som ska innehålla studenten användaren valt
    foreach (Student s in allStudents)//Kollar igenom alla studenter som skapats
    {
        if (s.Name == name) //Om en student med samma namn hittas, sätt student till den studenten och bryt loopen
        {
            student = s;
            break;
        }
    }

    if (choice?.ToLower() == "join")//Om användaren valt att gå med i en kurs
    {
        if (student == null)//Om studenten inte finns, skapa en ny student och lägg till den i listan över alla studenter
        {
            student = new Student(name!);
            allStudents.Add(student);
        }
        student.Join(vaildCourse);
    }
    else if (choice?.ToLower() == "leave")//Om användaren valt att lämna en kurs
    {
        if (student == null)//Om studenten inte finns, skriv ut ett felmeddelande
        {
            Console.WriteLine(name + " isn't enrolled in any course yet.");//Skriver ut att studenten inte är med i någon kurs
        }
        else//Om studenten finns, ta bort studenten från kursen
        {
            student.Leave(vaildCourse);
        }
    }
    else//Om användaren valt något annat än join eller leave, skriv ut ett felmeddelande
    {
        Console.WriteLine("Unknown option, please write 'join' or 'leave'.");
    }
}

Console.WriteLine();//Skriver ut en tom rad för att separera resultatet från inputen
Console.WriteLine("--- Result ---");

Console.WriteLine(english);//Skriver ut kursens namn, antal studenter och max antal platser
english.RollCall();

Console.WriteLine();//Skriver ut en tom rad för att separera resultatet från inputen
Console.WriteLine(programming);
programming.RollCall();