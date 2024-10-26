using FastEndpoints;
using REPR_Pattern.Repository;
using REPR_Pattern.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddFastEndpoints();
builder.Services.AddControllers();

var app = builder.Build();
app.UseFastEndpoints();
app.Run();
