using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MarxDtos.Dtos.User;
using User.BLL.Interfaces;
using User.DAL.Entities;
using User.DAL.Interfaces.Repositories;

namespace User.BLL.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;
        private  readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
        }
        public Task<UserDto> GetUserById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<UserDto>> GetAllUsers()
        {
            throw new System.NotImplementedException();
        }

        public Task<UserDto> AddUser(UserDto user)
        {
            throw new System.NotImplementedException();
        }

        public Task<UserDto> UpdateUser(UserRecord user)
        {
            throw new System.NotImplementedException();
        }

        public Task<UserDto> DeleteUser(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}