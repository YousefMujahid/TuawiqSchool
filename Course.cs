public class Course
{
    //Teacher teacher;
    string teacher;
    string courseName;

    public Course()
    {
    }

    public void addCourse(string name, string teacherName)
    {
        Course c = new Course();
        c.name = name;
        c.teacher = teacherName;
    }

}