using Microsoft.EntityFrameworkCore;

namespace GestionAggro.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<User>> AddUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return await _context.Users.ToListAsync();
        }

        public async Task<List<User>?> DeleteUser(int Id)
        {
            var user = await _context.Users.FindAsync(Id); ;
            if (user is null)
                return null;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return await _context.Users.ToListAsync();
        }

        public async Task<List<User>> GetAllUsers()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<User?> GetSingleUser(int Id)
        {
            var user = await _context.Users.FindAsync(Id);
            if (user is null)
                return null;

            return user;
        }

        public async Task<List<User>?> UpdateUser(int Id, User request)
        {
            var user = await _context.Users.FindAsync(Id);
            if (user is null)
                return null;

            user.Email = user.Email;
            user.Password = request.Password;

            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }
    }
}
