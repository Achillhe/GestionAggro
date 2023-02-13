namespace GestionAggro.Services.UserService
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsers();
        Task<User>? GetSingleUser(int Id);
        Task<List<User>> AddUser(User user);
        Task<List<User>?> UpdateUser(int Id, User request);
        Task<List<User>?> DeleteUser(int Id);
    }
}

