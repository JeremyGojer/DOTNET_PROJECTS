namespace BLL;
using BOL;
using DAL;

public class RoleManager{
    public static RoleManager instance = null;
    private RoleIOManager roleIOManager= new RoleIOManager();
    
    public static RoleManager GetRoleManager(){
        
        if(instance==null){
            instance = new RoleManager();
        }
        return instance;
    }

    public List<Role> GetAll(){
        return roleIOManager.GetAll();
    }

    public bool AddToRole(Role Role){
        return roleIOManager.AddRole(Role);
    }

    
    public Role GetRoleById(int id){
        List<Role> roles = GetAll();
        Role role = roles.FirstOrDefault(role => role.Id == id);
        return role;

    }

}