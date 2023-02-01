namespace BLL;
using BOL;
using DAL;

public class RoleManager{
    public static RoleManager instance = null;
    private RoleIOManager roleIOManager= new RoleIOManager();
    
    private RoleManager(){

    }
    public static RoleManager GetRoleManager(){
        
        if(instance==null){
            instance = new RoleManager();
        }
        return instance;
    }

    public List<Role> GetAll(){
        return roleIOManager.GetAll();
    }

    public bool AddRole(Role Role){
        return roleIOManager.AddRole(Role);
    }

    
    public bool RemoveRole(Role Role){
        return RoleIOManager.RemoveRole(Role);
    }

}