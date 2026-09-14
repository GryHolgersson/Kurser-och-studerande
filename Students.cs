/*Student (i filen Student.cs)
● Fält: Name och en lista Courses.
● Metod Join(course) — går med i en kurs.
● Metod Leave(course) — lämnar en kurs.
● Metod Schedule() — skriver ut vilka kurser den studerande går.
● En ToString() med den studerandes namn.
● Reglerna som gör uppgiften — det är här logiken sitter:*/

public class Student
{
    public string Name;
    public List<Course> Courses = new List<Course>();

    public Student (string name)
    {
        Name = name;
    }
    public void Join(Course course)//Kallar på Course metoden
    {
        course.Enroll(this);
    }
}