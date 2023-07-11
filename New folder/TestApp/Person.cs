namespace Town{
    public class Person{

        public string FirstName {get; set;}

        public string LastName {get; set;}

        public DateTime DOB {get; set;}

        public Person(){
            FirstName = "AA";
            LastName = "BB";
            DOB = new DateTime(2010,8,20);
        }

        public Person(string first, string last, DateTime dob){
            FirstName = first;
            LastName = last;
            DOB = dob;
        }

        public override String ToString(){
            return FirstName + " "+ LastName;
        }
    }
}