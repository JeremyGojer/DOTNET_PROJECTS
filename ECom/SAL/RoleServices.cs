namespace SAL;
using System.Collections.Generic;
using BOL;
using BLL;

public class RoleServices{
    private RoleManager roleManager = new RoleManager();

    public List<Role> GetAllRoles(){
        return roleManager.GetAll();
    }

    public bool AddToRole(Role Role){
        return roleManager.AddToRole(Role);
    }


    public Role GetRoleById(int id){
        var Roles = roleManager.GetAll();
        foreach(var Role in Roles){
            if(Role.Id==id){
                return Role;
            }
        }
        return null;
    }

    

}