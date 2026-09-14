/* Course (i filen Course.cs)
● Fält: Name, en kapacitet MaxSeats (max antal platser), och en lista Students.
● Metod Enroll(student) — anmäler en studerande till kursen, om det finns plats.
● Metod Remove(student) — tar bort en studerande ur kursen.
● Metod RollCall() — skriver ut alla studerande i kursen.
● En ToString() som t.ex. ger "Matematik (2/5 platser)".
*/

public class Course
{
    public string Name
    {
        get => CourseName;// läser/hämtar värdet
        set => CourseName = value;//"=>" gör detta. Value representerar kommande värde och i detta fall sparar det i CourseName
    }
}