namespace DAL;
using BOL;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
public class RoleIOManager
{
    private string path=@"..\MyEComApp\wwwroot\files\Roles.json";
    //In case we need to get data from a different file pass it through the constructor
    public RoleIOManager(string path)
    {
        this.path = path;
    }

    public RoleIOManager()
    {
    }

    public List<Role> GetAll()
    {
        
        List<Role> roles = Load(this.path);
        if (roles == null)
        {
            roles = new List<Role>();
            roles.Add(new Role{Id=1,Title="Admin"});
            roles.Add(new Role{Id=2,Title="Customer"});
            roles.Add(new Role{Id=3,Title="Seller"});
        }
        return roles;
    }

    public bool Save(string path, List<Role> roles)
    {
        
        bool status = false;
        string jsonString = JsonSerializer.Serialize(roles);
        File.WriteAllText(path, jsonString);
        return true;
    }

    public List<Role> Load(string path)
    {
        string json = File.ReadAllText(path);
        List<Role> roles = JsonSerializer.Deserialize<List<Role>>(json);
        return roles;
    }

    public bool AddRole(Role role)
    {
        bool status = false;
        
        try
        {
            List<Role> roles = Load(this.path);
            Roles.Add(role);
            Save(this.path, roles);
            status = true;
            return status;
        }
        catch (Exception e)
        {
            return status;
        }

    }

    
    
}