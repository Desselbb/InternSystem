using Blazored.LocalStorage;
using InternSystemCore.Data;
using InternSystemCore.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDbContext<SystemDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SystemDbContext"));
}
);
builder.Services.AddTransient<DepartmentService>();
builder.Services.AddTransient<InternProjectService>();
builder.Services.AddTransient<InternService>();
builder.Services.AddTransient<PersonalDetailsService>();
builder.Services.AddTransient<ProjectCommentService>();
builder.Services.AddTransient<ProjectService>();
builder.Services.AddBlazoredLocalStorage();



var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
