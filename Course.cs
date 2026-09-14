/* Course (i filen Course.cs)
● Fält: Name, en kapacitet MaxSeats (max antal platser), och en lista Students.
● Metod Enroll(student) — anmäler en studerande till kursen, om det finns plats.
● Metod Remove(student) — tar bort en studerande ur kursen.
● Metod RollCall() — skriver ut alla studerande i kursen.
● En ToString() som t.ex. ger "Matematik (2/5 platser)".
*/

public class Course
{
    public string Name; //Kursens namn
    public int MaxSeats;// Max antal platser i kursen
    public List<Student> Students = new List<Student>();// Lista över anmälda studenter 

    public Course(string name, int maxSeats)//Skapar en kurs med kurs namn och platsantal
    {
        Name = name;
        MaxSeats = maxSeats;
    }
}

    