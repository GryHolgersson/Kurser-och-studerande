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
    public void Enroll(Student student)//Meddelar att det finns plats
    {
        if (Students.Contains(student))// kollar om studenten redan finns 
        {
            Console.WriteLine(student.Name + " is already in the class");
            return;
        }
        if (Students.Count >= MaxSeats)//Kollar om kursen är full
        {
            Console.WriteLine("Kursen är full");
            return;
        }
        Students.Add(student);//Lägger till studenter i kursen
        student.Courses.Add(this); //Lägger till kursen hos studenten
    }
    public void Remove(Student student)//Tar bort student ur kursen
    {
        if (!Students.Contains(student))// Om studenten inte finns, gör inget
        {
            return;
        }
        Students.Remove(student);
        student.Courses.Remove(this); //Tar bort kursen hos studenten
    }
    public void RollCall()//Skriver ut alla studenter i kursen
    {
        foreach (Student student in Students)
        {
            Console.WriteLine(student);
        }
    }
    public override string ToString()
    {
        return Name + " (" + Students.Count + "/" + MaxSeats + " seats)";//Skriver ut kursens namn, antal studenter och max antal platser 
    }   // "/" = string concatenation så det blir ex 2/5 plater är tagna
}

    