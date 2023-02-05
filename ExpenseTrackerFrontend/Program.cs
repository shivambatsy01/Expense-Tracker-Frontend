using ExpenseTrackerFrontend.DataProviders.CategoryDataProvider;
using ExpenseTrackerFrontend.DataProviders.ExpenseDataProvider;
using ExpenseTrackerFrontend.DataProviders.UserDataProvider;
using ExpenseTrackerFrontend.Global;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IExpenseDataProvider, ExpenseDataProvider>();
builder.Services.AddScoped<ICategoryDataProvider, CategoryDataProvider>();
builder.Services.AddScoped<IUserDataProvider, UserDataProvider>();
builder.Services.AddSingleton<ICustomSessionStore, SessionStore>();

//builder.Services.AddDistributedMemoryCache();
//builder.Services.AddSession(options =>
//{
//    options.IdleTimeout = TimeSpan.FromSeconds(10000);
//    options.Cookie.HttpOnly = true;
//    options.Cookie.IsEssential = true;
//});

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

app.UseSession();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
