using Microsoft.EntityFrameworkCore;
using SurveyApp .Data; // kendi namespace'inle değiştir (örnek: MvcApp.Data)

var builder = WebApplication.CreateBuilder(args);

// ✅ SQL Server connection string'i al
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// ✅ EF Core DbContext'i servislere ekle
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

// MVC servisini ekle
builder.Services.AddControllersWithViews();

var app = builder.Build();

// ✅ HTTP pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ✅ Default route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
