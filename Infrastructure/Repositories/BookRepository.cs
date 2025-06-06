﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {

        private readonly LibraryDbContext _context;

        public BookRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetAllAsync()
        {

            return await _context.Books.ToListAsync();

        }

        public async Task<Book?> GetByIdAsync(int id)
        {

            return await _context.Books.FindAsync(id);

        }

        public async Task<Book> AddAsync(Book book)
        {

            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return book;

        }

        public async Task<Book> UpdateAsync(Book book)
        {

            _context.Books.Update(book);
            await _context.SaveChangesAsync();
            return book;

        }

        public async Task DeleteAsync(int id)
        {

            var book = await _context.Books.FindAsync(id);
            if (book != null)
            {

                _context.Books.Remove(book);
                await _context.SaveChangesAsync();

            }
        }


    }
}
