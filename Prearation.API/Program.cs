using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Prearation.Domain.Dto;
using Prepration.Repository.Interfaces;
using Prepration.Repository.Services;
using Presentation.Data.Data;
using System.Runtime.Intrinsics.X86;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(
               options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultCon"))
               );
builder.Services.AddIdentity<User, Role>(options => { options.User.RequireUniqueEmail = false; })
           .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
