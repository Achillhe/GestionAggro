namespace GestionAggro.Services.RoleService
{
    public interface IRoleService
    {
        Task<List<Role>> GetAllRoles();
        Task<Role>? GetSingleRole(int Id);
        Task<List<Role>> AddRole(Role role);
        Task<List<Role>?> UpdateRole(int Id, Role request);
        Task<List<Role>?> DeleteRole(int Id);
    }
}
