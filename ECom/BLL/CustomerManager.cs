namespace BLL;
using BOL;
using DAL;

public class CustomerManager{
    public static CustomerManager instance = null;
    private CustomerIOManager customerIOManager= new CustomerIOManager();
    
    private CustomerManager(){

    }
    public static CustomerManager GetCustomerManager(){
        
        if(instance==null){
            instance = new CustomerManager();
        }
        return instance;
    }

    public List<Customer> GetAll(){
        return customerIOManager.GetAll();
    }

    public bool AddCustomer(Customer customer){
        return customerIOManager.AddCustomer(customer);
    }

    
    public bool RemoveCustomer(Customer customer){
        return customerIOManager.RemoveCustomer(customer);
    }

}