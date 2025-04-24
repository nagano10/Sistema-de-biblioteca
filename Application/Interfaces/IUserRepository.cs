using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IUserRepository
    {

        Task<User?> GetByEmailAsync(string email);
        Task AddUserAsync(User user);

    }
}
