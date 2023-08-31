public class Course
{
    //Teacher teacher;
    string teacher;
    string courseName;
    int level; //1-12
    Course courses = new Course[50];
    int numberOfCourses = 0;

    public Course()
    {
    }

    public void addCourse(string name, string teacherName, int level)
    {
        Course c = new Course();
        c.name = name;
        c.teacher = teacherName;
        c.level = level;
        courses[numberOfCourses++] = c;
    }

    public void showCourses(int level)
    {
        for( int i = 0 ; i < numberOfCourses ; i++ )
        {
            if ( string.equals(courses[i].level, level) )
            Console.WriteLine(courses[i].name);
        }

    }

    pubplic Course findCourse(string courseName)
    {
         for( int i = 0 ; i < numberOfCourses ; i++ )
        {
            if ( string.equals(courses[i].name, courseName) )
                return courses[i];
        }
}

