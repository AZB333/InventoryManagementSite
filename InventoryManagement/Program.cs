using InventoryManagement.Data;
using InventoryManagement.Services;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Configuration.AddJsonFile("appsettings.json");
builder.Services.AddRazorPages();

///////////////Contexts/////////////////////////////////

//////LeftShelves////////
builder.Services.AddDbContext<LeftShelf6Context>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("LeftShelf6Connection")));

builder.Services.AddScoped<LeftShelf6Service>();

builder.Services.AddDbContext<LeftShelf5Context>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("LeftShelf5Connection")));

builder.Services.AddScoped<LeftShelf5Service>();

builder.Services.AddDbContext<LeftShelf4Context>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("LeftShelf4Connection")));

builder.Services.AddScoped<LeftShelf4Service>();

builder.Services.AddDbContext<LeftShelf3Context>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("LeftShelf3Connection")));

builder.Services.AddScoped<LeftShelf3Service>();

builder.Services.AddDbContext<LeftShelf2Context>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("LeftShelf2Connection")));

builder.Services.AddScoped<LeftShelf2Service>();

builder.Services.AddDbContext<LeftShelf1Context>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("LeftShelf1Connection")));

builder.Services.AddScoped<LeftShelf1Service>();

builder.Services.AddDbContext<LeftFloorContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("LeftFloorConnection")));

builder.Services.AddScoped<LeftFloorService>();


//////RightShelves//////
builder.Services.AddDbContext<RightShelf6Context>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("RightShelf6Connection")));

builder.Services.AddScoped<RightShelf6Service>();

builder.Services.AddDbContext<RightShelf5Context>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("RightShelf5Connection")));

builder.Services.AddScoped<RightShelf5Service>();

builder.Services.AddDbContext<RightShelf4Context>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("RightShelf4Connection")));

builder.Services.AddScoped<RightShelf4Service>();

builder.Services.AddDbContext<RightShelf3Context>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("RightShelf3Connection")));

builder.Services.AddScoped<RightShelf3Service>();

builder.Services.AddDbContext<RightShelf2Context>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("RightShelf2Connection")));

builder.Services.AddScoped<RightShelf2Service>();

builder.Services.AddDbContext<RightShelf1Context>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("RightShelf1Connection")));

builder.Services.AddScoped<RightShelf1Service>();

builder.Services.AddDbContext<RightFloorContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("RightFloorConnection")));

builder.Services.AddScoped<RightFloorService>();




////////Center///////
builder.Services.AddDbContext<CenterContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("CenterConnection")));

builder.Services.AddScoped<CenterService>();

/////////////////////////////////////////////////////////

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
app.UseAuthorization();

app.MapRazorPages();

// Fallback for unknown paths (Render)
app.MapFallback(context =>
{
    context.Response.Redirect("/"); // Redirect to home
    return Task.CompletedTask;
});
