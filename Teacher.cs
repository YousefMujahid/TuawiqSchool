using Human;




//Teachers and students classes must inherint from Course class

namespace School
{

    public class Teacher : Person
    {

       

        /* ------- Variables -------*/

        string field ;
        int teacherID ;


        /* ------- Constructor -------*/
        /*public Teacher(string field,int teacherID){

        this.field = field;
        this.teacherID = teacherID;
        }*/

        /* ------- Setters and Getters ------- */
       
        
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
        

}
}
