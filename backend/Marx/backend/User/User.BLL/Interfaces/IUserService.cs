using System.Collections.Generic;
using System.Threading.Tasks;
using MarxDtos.Dtos.User;
using User.DAL.Entities;

namespace User.BLL.Interfaces
{
    public interface IUserService
    {
        public Task<UserDto> GetUserById(int id);
        public Task<IEnumerable<UserDto>> GetAllUsers();
        public Task<UserDto> AddUser(UserDto user);
        public Task<UserDto> UpdateUser(UserRecord user);
        public Task<UserDto> DeleteUser(int id);
    }
}