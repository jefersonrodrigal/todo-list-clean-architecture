using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface ITodoRepository
    {
        Task<List<TodoItem>> GetAllAsync();
        Task AddAsync(TodoItem item);
        Task SaveChangesAsync();
    }
}
