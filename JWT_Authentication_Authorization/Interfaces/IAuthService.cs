using JWT_Authentication_Authorization.Models;
using Microsoft.AspNetCore.Identity.Data;

namespace JWT_Authentication_Authorization.Interfaces
{
    public interface IAuthService
    {
        User AddUser(User user);
        string Login(LoginReq loginRequest);
        Role AddRole(Role role);
        bool AssignRoleToUser(AddUserRole obj);

    }
}