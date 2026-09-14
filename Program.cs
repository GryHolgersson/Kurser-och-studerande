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
Course english = new Course("English", 5);
Course Programming = new Course("Programming, 3");

//Skapar studenter 
Student simon = new Student ("Simon");
Student eric = new Student ("Eric");
Student lennita = new Student("Lennita");
Student jonna = new Student ("Jonna");

//Studenter går med i kurser


