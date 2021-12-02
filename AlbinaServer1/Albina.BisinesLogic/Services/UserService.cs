using Albina.BisinesLogic.Interfaces;
using Albina.BisinesLogic.Models;
using Albina.DataAccess.Core.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albina.BisinesLogic.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IContext _context;

        public UserService(IMapper mapper, IContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public Task<UserInformationBlo> Auth(UserIdentityBlo userIdentityBlo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DoesExist(int numberPrefix, int number)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Get(int userId)
        {
            _context.Users.Fin
        }

        public Task<UserInformationBlo> Register(UserIdentityBlo userIdentityBlo)
        {
            throw new NotImplementedException();
        }

        public Task<UserUpdateBlo> Update(UserIdentityBlo userIdentityBlo, UserUpdateBlo userUpdateBlo)
        {
            throw new NotImplementedException();
        } 
    }
}
