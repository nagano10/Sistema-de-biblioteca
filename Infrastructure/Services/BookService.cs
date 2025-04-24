using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Infrastructure.Services
{
    public class BookService
    {

        private readonly IBookRepository _repository;
        private readonly IMapper _mapper;

        public BookService(IBookRepository repository, IMapper mapper)
        {

            _repository = repository;
            _mapper = mapper;

        }

        public async Task<List<BookDTO>> GetAllAsync()
        {

            var books = await _repository.GetAllAsync();
            return _mapper.Map<List<BookDTO>>(books);

        }

        public async Task<BookDTO?> GetByIdAsync(int id)
        {

            var book = await _repository.GetByIdAsync(id);

            return book != null ? _mapper.Map<BookDTO>(book) : null;
        }

        public async Task<BookDTO> CreateAsync(CreateBookDTO dto)
        {

            var book = _mapper.Map<Book>(dto);
            var created = await _repository.AddAsync(book);
            return _mapper.Map<BookDTO>(created);

        }

        public async Task<BookDTO?> UpdateAsync(int id, CreateBookDTO dto)
        {

            var book = await _repository.GetByIdAsync(id);
            if (book == null) return null;

            _mapper.Map(dto, book);
            var updated = await _repository.UpdateAsync(book);
            return _mapper.Map<BookDTO>(updated);

        }

        public async Task<bool> DeleteAsync(int id)
        {

            var existing = await _repository.GetByIdAsync(id);
            if (existing == null) return false;

            await _repository.DeleteAsync(id);
            return true;

        }

    }
}
