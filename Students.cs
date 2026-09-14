/*Student (i filen Student.cs)
● Fält: Name och en lista Courses.
● Metod Join(course) — går med i en kurs.
● Metod Leave(course) — lämnar en kurs.
● Metod Schedule() — skriver ut vilka kurser den studerande går.
● En ToString() med den studerandes namn.
● Reglerna som gör uppgiften — det är här logiken sitter:*/

public class Student
{
    public string Name;//Namn på studenten
    public List<Course> Courses = new List<Course>();//Lista av elever i kursen 

    public Student (string name)
    {
        Name = name;
    }
    public void Join(Course course)//Kallar på Course metoden
    {
        course.Enroll(this);//Lägger till student
    }
    public void Leave(Course course)//Samma här, kallar på Course metoden 
    {
        course.Remove(this);//Tar bort student 
    }
    public void Schedule()//Skriver ut alla kurser studenten går 
    {
        foreach (Course course in Courses)
        {
            Console.WriteLine(course);
        }
    }
    public override string ToString()//Gör så att samma student inte kan skrivas in två gånger 
    {
        return Name;
    }
    
}