using menukort.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();


/*
 * Indsætter een PizzaRepository
 */
builder.Services.AddSingleton<PizzaRepository>(new PizzaRepository(true));
/*
 * Indsætter een BurgerRepository
 */
builder.Services.AddSingleton<BurgerRepository>(new BurgerRepository(true));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
