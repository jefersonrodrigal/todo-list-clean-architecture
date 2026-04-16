using Application.UseCases.CreateTodo;
using Application.UseCases.GetTodos;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly CreateTodoUseCase _createTodoUseCase;
        private readonly GetTodosUseCase _getTodosUseCase;

        public TodoController(
            CreateTodoUseCase createTodoUseCase,
            GetTodosUseCase getTodosUseCase)
        {
            _createTodoUseCase = createTodoUseCase;
            _getTodosUseCase = getTodosUseCase;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var todos = await _getTodosUseCase.Execute();
            return Ok(todos);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateTodoRequest request)
        {
            await _createTodoUseCase.Execute(request.Title);
            return Ok();
        }
    }
}
