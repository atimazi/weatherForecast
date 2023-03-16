using NEWAPP.Repositories;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IWfForecastRepository, WForecastRepository>();
var provider = builder.Services.BuildServiceProvider();

//var _configuration = provider.GetRequiredService<IConfiguration>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
//Services.AddControllers(options => options.EnableEndpointRouting = false);
builder.Services.AddControllers(option=>option.EnableEndpointRouting=false);
var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.MapRazorPages();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthorization();
app.UseRouting();
app.UseMvc(routes =>
{
routes.MapRoute(
	name: "default",
	template: "{controller=home}/{action=SearchByCity}/{id?}");
});
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=WeatherForecast}/{action=City}/{id?}");



app.Run();
