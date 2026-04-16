using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly AppDbContext _context;

        public TodoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<TodoItem>> GetAllAsync()
            => await _context.TodoItems.ToListAsync();

        public async Task AddAsync(TodoItem item)
            => await _context.TodoItems.AddAsync(item);

        public async Task SaveChangesAsync()
            => await _context.SaveChangesAsync();
    }
}
