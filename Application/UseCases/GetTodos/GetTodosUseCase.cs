using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCases.GetTodos
{
    public class GetTodosUseCase
    {
        private readonly ITodoRepository _repository;

        public GetTodosUseCase(ITodoRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<TodoItem>> Execute()
        {
            return await _repository.GetAllAsync();
        }
    }
}
