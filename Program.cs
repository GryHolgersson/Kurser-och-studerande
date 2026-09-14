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
List<Student> allaStudenter = new List<Student>();

bool fortsatt = true;//Bool som gör att while loopen fortsätter

while (fortsatt)//While loop som gör att man kan fortsätta
{
    Console.WriteLine();
    Console.WriteLine("Enter a student name (or 'stop' to finish):");
    string namn = Console.ReadLine();

    if (namn.ToLower() == "stop")//Kollar om man vill sluta, om ja så avslutas loopen
    {
        fortsatt = false;//Stänger av loopen
        continue;//Hoppar över resten av loopen
    }

    Console.WriteLine("Would you like to join or leave a course? (join/leave)");//Låter användaren välja om de vill gå med i eller lämna en kurs
    string val = Console.ReadLine();

    Console.WriteLine("Which course? (english/programming)");//Låter användaren välja kurs
    string kursval = Console.ReadLine();

    Course vaildKurs;//Skapar en variabel som ska innehålla kursen användaren valt
    switch (kursval.ToLower())//Kollar vilken kurs användaren valt
    {
        case "english"://Om användaren valt english, sätt vaildKurs till english
            vaildKurs = english;
            break;
        case "programming"://Om användaren valt programming, sätt vaildKurs till programming
            vaildKurs = programming;
            break;
        default://Om användaren valt något annat än english eller programming, skriv ut ett felmeddelande och fortsätt loopen
            Console.WriteLine("Unknown course, please try again.");
            continue;
    }

    //Letar efter en redan skapad student med samma namn
    Student student = null;//Skapar en variabel som ska innehålla studenten användaren valt
    foreach (Student s in allaStudenter)//Kollar igenom alla studenter som skapats
    {
        if (s.Name == namn) //Om en student med samma namn hittas, sätt student till den studenten och bryt loopen
        {
            student = s;
            break;
        }
    }

    if (val.ToLower() == "join")//Om användaren valt att gå med i en kurs
    {
        if (student == null)//Om studenten inte finns, skapa en ny student och lägg till den i listan över alla studenter
        {
            student = new Student(namn);
            allaStudenter.Add(student);
        }
        student.Join(vaildKurs);
    }
    else if (val.ToLower() == "leave")//Om användaren valt att lämna en kurs
    {
        if (student == null)//Om studenten inte finns, skriv ut ett felmeddelande
        {
            Console.WriteLine(namn + " isn't enrolled in any course yet.");//Skriver ut att studenten inte är med i någon kurs
        }
        else//Om studenten finns, ta bort studenten från kursen
        {
            student.Leave(vaildKurs);
        }
    }
    else//Om användaren valt något annat än join eller leave, skriv ut ett felmeddelande
    {
        Console.WriteLine("Unknown option, please write 'join' or 'leave'.");
    }
}

Console.WriteLine();//Skriver ut en tom rad för att separera resultatet från inputen
Console.WriteLine("--- Resultat ---");

Console.WriteLine(english);//Skriver ut kursens namn, antal studenter och max antal platser
english.RollCall();

Console.WriteLine();//Skriver ut en tom rad för att separera resultatet från inputen
Console.WriteLine(programming);
programming.RollCall();