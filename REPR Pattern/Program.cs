using FastEndpoints;
using REPR_Pattern.Repository;
using REPR_Pattern.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddFastEndpoints();
builder.Services.AddControllers();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseFastEndpoints();
app.Run();
