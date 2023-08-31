using System;




namespace Human
{


    public class Person
    {

        /* ------- Variables -------*/
        string name = "";
        string DoB = "";
        int nationalID = 0;
        string gender = "";
        string homeTown = "";
        string occupation = "";
        int teacherID = 0; 
        /* ------- Variables -------*/

        /* ------- Setters and Getters ------- */
        public string getName()
        {
            return name;
        }
        public string void setName(string name)
        {
            this.name = name;
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

        public string getOccupation()
        {
            return occupation;
        }
        public string void setOccupation(string occupation)
        {
            this.occupation = occupation;
        }

        public int getTeacherID(){
            return teacherID;
        }
        public void setTeacherID(int teacherID){
            this.teacherID = teacherID;

        }
        /* ------- Setters and Getters ------- */




    }

}