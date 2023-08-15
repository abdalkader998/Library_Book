﻿    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using WebApplication6.Data;
    using WebApplication6.Services;

    var builder = WebApplication.CreateBuilder(args);
    builder.Services.AddDbContext<WebApplication6Context>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("WebApplication6Context") ?? throw new InvalidOperationException("Connection string 'WebApplication6Context' not found.")));

// Add services to the container.
builder.Services.AddControllers();
    builder.Services.AddControllersWithViews();
    builder.Services.AddScoped<LibraryService>();
     

    var app = builder.Build();


    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseRouting();

    app.UseAuthorization();

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

// Map API controllers
app.MapControllers();
app.Run();
