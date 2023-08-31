using System;




namespace Human
{



    public class Person
    {
        

        /* ------- Variables -------*/
        string name ;
        string DoB ;
        int nationalID ;
        string gender ;
        string homeTown ;
        

        
        /* ------- Constructor -------*/
     /*  public Person (string name,  string DoB,  int nationalID , string gender, string homeTown, ){ 
        this.name=name;
        this.DoB=DoB;
        this.nationalID=nationalID;
        this.gender=gender;
        this.homeTown=homeTown;

       }*/
      
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

       

}
}