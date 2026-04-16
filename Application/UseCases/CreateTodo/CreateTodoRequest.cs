using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCases.CreateTodo
{
    public class CreateTodoRequest
    {
        public string Title { get; set; } = string.Empty;
    }
}
