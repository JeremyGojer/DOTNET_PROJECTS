using Town;

namespace Classroom{
    
    public class Student:Person{
        
        public string Course {get; set;}

        public string Prn {get; set;}

        public Student():base(){
            Course = "PG-DAC";
            Prn = "230301054100";

        }

        public Student(string first, string last, DateTime dob,string course,string prn):base(first,last,dob){
            Course = course;
            Prn = prn;
        }

        public override String ToString(){
            return base.ToString() + " " + Prn + " " + Course ;
        }
    }
}