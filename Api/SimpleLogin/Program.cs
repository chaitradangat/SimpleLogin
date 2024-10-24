using Microsoft.Extensions.DependencyInjection;
using SimpleLogin.Domain.Constants;
using SimpleLogin.Extensions;



var builder = WebApplication.CreateBuilder(args);

/*Add Services*/

// app configuration
builder.AddConfiguration(args);




// authentication

// cors
builder.Services.AddCors();

// dbcontext 

// logging
builder.Services.AddLogging();



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();





var app = builder.Build();




// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
