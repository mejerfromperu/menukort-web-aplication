using menukort.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();


/*
 * Inds�tter een PizzaRepository
 */
builder.Services.AddSingleton<IPizzaRepository>(new PizzaRepositoryJson());
/*
 * Inds�tter een BurgerRepository
 */
builder.Services.AddSingleton<IBurgerRepository>(new BurgerRepositoryJson());
/*
 * Inds�tter een DrikkevarerRepository
 */
builder.Services.AddSingleton<DrikkevarerRepository>(new DrikkevarerRepository(true));

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
