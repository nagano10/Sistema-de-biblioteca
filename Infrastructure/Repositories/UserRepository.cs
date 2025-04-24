using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Data;
using Application.Interfaces;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly LibraryDbContext _context;

        public UserRepository(LibraryDbContext context)
        { 
        
            _context = context;
        
        }

        public async Task AddUserAsync(User user)
        { 
        
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

        }

        public async Task<User?> GetByEmailAsync(string email)
        { 
        
            return await _context.Users.FirstOrDefaultAsync(u  => u.Email == email);

        }

    }
}
