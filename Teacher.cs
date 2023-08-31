using Human;




//Teachers and students classes must inherint from Course class

namespace School
{

    public class Teacher : Course
    {

        /* ------- Arrays TO Store Teachers Info ------- */
        string[] teachersName = new string[50];
        string[] teachersDob = new string[50];
        int[] teachersNationalID = new int[50];
        string[] teachersGender = new string[50];
        string[] teachersHomeTown = new string[50];
        string[] teachersOccupation = new string[50];
        string[] teachersName = new string[50];
        int[] teachersID = new int[50];

        public int teachersCount = 0;
        /* ------- Arrays TO Store Teachers Info ------- */

        /* ------- Variables -------*/
        string name = "";
        string DoB = "";
        int nationalID = 0;
        string gender = "";
        string homeTown = "";
        string field = "";
        int teacherID = 0;
        /* ------- Variables -------*/

        /* ------- Setters and Getters ------- */
        public string getName()
        {
            return name;
        }
        public string setName(string name)
        {
            this.name = name;
            teachersName = teachersName.Append(name).ToArray();

            return teachersName;

        }

        public string void setDoB(string doB)
        {
            this.doB = doB;
        }

        public string getDoB()
        {
            return DoB;
        }

        public int getNationalID()
        {
            return nationalID;
        }
        partial void void setNationalID()
        {
            this.nationalID = nationalID;

        }
        public string getGender()
        {
            return gender;

        }
        public string void setGender(string gender)
        {
            this.gender = gender;
        }
        public string getHomeTown()
        {
            return homeTown;

        }
        public string void setHomeTown(string homeTown)
        {
            this.homeTown = homeTown;

        }

        public string getField()
        {
            return occupation;
        }
        public string void setField(string field)
        {
            this.field = field;
        }

        public int getTeacherID()
        {
            return teacherID;
        }
        public void setTeacherID(int teacherID)
        {
            this.teacherID = teacherID;

        }
        /* ------- Setters and Getters ------- */



        /* ------- Main Methods Of The Class ------- */

        /*
            name, DoB, nationalID, gender,
             homeTown, field, teacherID. 

        */
        public void addTeacher(string name, string DoB, int nationalID,
        string gender, string homeTown, string field, int teacherID)
        {


            teachersCount++;

        }

        public string printTeacherInfo(int teacherID)
        {

        }

        public void deleteTeacher(int teacherID)
        {

        }

        /* ------- Main Methods Of The Class ------- */

    }



}
