namespace People;

public class Employee:Person{
    public int Id{get;set;}
    public string Desgination{get;set;}
    public string Department{get;set;}
    public double Salary{get;set;}

    public Employee():base(){
        this.Id = 0;
        this.Desgination = "test";
        this.Department = "test";
        this.Salary = 10000;
    }

    public Employee(Employee e){
        this.Id = e.Id;
        this.Desgination = e.Desgination;
        this.Department = e.Department;
        this.Salary = e.Salary;
    }

    public Employee(string fname ,string lname, DateTime dob,int id, string desc, string dept, double salary):base(fname,lname,dob){
        this.Id = id;
        this.Desgination = desc;
        this.Department = dept;
        this.Salary = salary;
    }

    public Employee(Person p,int id, string desc, string dept, double salary):base(p){
        this.Id = id;
        this.Desgination = desc;
        this.Department = dept;
        this.Salary = salary;
    } 

    public override string ToString(){
        return base.ToString() + " " + this.Id + " " + this.Desgination + " " + this.Department;
    }

    public virtual double GetSalary(){
        return this.Salary;
    }


}