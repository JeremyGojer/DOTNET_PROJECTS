namespace People;

public class SalesEmployee:Employee{
    public double Bonus{get;set;}
    public double Target{get;set;}
    public double Revenue{get;set;}

    public SalesEmployee():base(){
        this.Bonus = 0;
        this.Target = 100000;
        this.Revenue = 100000;
    }

    public SalesEmployee(Employee e, double bonus, double target, double revenue):base(e){
        this.Bonus = bonus;
        this.Target = target;
        this.Revenue = revenue;
    }

    public override string ToString()
    {
        return base.ToString() + " " + this.GetSalary();
    }

    public override double GetSalary(){
        double total = base.GetSalary();
        if(this.Target >= this.Revenue)
            total = this.Bonus + base.GetSalary();
        return total;
    }
}