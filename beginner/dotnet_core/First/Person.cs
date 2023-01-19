namespace People;

public class Person{
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public DateTime Dob{get;set;}

    public Person(){
        this.FirstName = "Jeremy";
        this.LastName = "Gojer";
        this.Dob = new(1996,02,25);
    } 

    public Person(string fname, string lname, DateTime dob){
        this.FirstName = fname;
        this.LastName = lname;
        this.Dob = dob;
    }

    public Person(Person p){
        this.FirstName = p.FirstName;
        this.LastName = p.LastName;
        this.Dob = p.Dob;
    }

    public override string ToString(){
        return base.ToString()+ " " +this.FirstName + " " + this.LastName + " " + this.Dob;
    }

}