

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});
builder.Services.AddIdentity<SiteIdentity, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedEmail = true;
})
  .AddEntityFrameworkStores<ApplicationDbContext>()
  .AddRoles<IdentityRole>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.UseStaticFiles();
app.UseRouting();

app.MapDefaultControllerRoute();
app.Run();
