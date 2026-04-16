using Application.Interfaces;
using Application.UseCases.CreateTodo;
using Application.UseCases.GetTodos;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=todolist.db"));

builder.Services.AddScoped<ITodoRepository, TodoRepository>();
builder.Services.AddScoped<CreateTodoUseCase>();
builder.Services.AddScoped<GetTodosUseCase>();
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapControllers();


app.Run();
