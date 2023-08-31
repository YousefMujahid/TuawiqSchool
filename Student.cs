using System;
public class Student
{
    String name;
    int nID;
    int ID = 0; //as count
    int level;
    String DoB;
    String homeTown;
    int grade; 
    Course courses = new Course[5];
    int numberOfCourses=0;

    public Student ()
    {
    }

    public void register(String n, int id, int l, String dob, String ht)
    {
        name = n;
        ID = id;
        level = l;
        DoB = dob;
        homeTown = ht;
        ID = ++ID;
    }

    public addCourse()
    {
        // check if #c < 5 >> ok
        if (numberOfCourses <= 5 )
            Console.WriteLine("sorry you cant add more classes!");

        else
        {
            //String name, int yourLevel
            int yourLevel = Control.Read("Enter your level:");
            //Search ,, show list
            Course.showCourses(yourLevel); // for level

            //input course name 
            Console.WriteLine("Enter Course name based on list appeared:");
            string courseName = Console.ReadLine();
    
            // assign course 
            courses[numberOfCourses] = findCourse(courseName);
            Console.WriteLine("A course have been added successfully");
        }
    }

    


}


// Person : Student >> inherent from 