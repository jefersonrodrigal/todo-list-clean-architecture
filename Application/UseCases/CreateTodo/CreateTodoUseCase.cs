using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCases.CreateTodo
{
    public class CreateTodoUseCase
    {
        private readonly ITodoRepository _repository;

        public CreateTodoUseCase(ITodoRepository repository)
        {
            _repository = repository;
        }

        public async Task Execute(string title)
        {
            var todo = new TodoItem(title);

            await _repository.AddAsync(todo);
            await _repository.SaveChangesAsync();
        }
    }
}
