using biblioteca.Model.Connection;
using biblioteca.Routes;

var builder = WebApplication.CreateBuilder(args);

// Conexão com o banco de dados
builder.Services.AddNpgsql<DatabaseConnection>(builder.Configuration["DatabaseConnection:Npgsql"]);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");


app.MapMethods(UserGetSingle.Template, UserGetSingle.Methods, UserGetSingle.Handle);
app.MapMethods(UserGet.Template, UserGet.Methods, UserGet.Handle);
app.MapMethods(UserPost.Template, UserPost.Methods, UserPost.Handle);
app.MapMethods(UserPut.Template, UserPut.Methods, UserPut.Handle);
app.MapMethods(UserDelete.Template, UserDelete.Methods, UserDelete.Handle);

app.MapMethods(BookGetSingle.Template, BookGetSingle.Methods, BookGetSingle.Handle);
app.MapMethods(BookGet.Template, BookGet.Methods, BookGet.Handle);
app.MapMethods(BookPost.Template, BookPost.Methods, BookPost.Handle);
app.MapMethods(BookPut.Template, BookPut.Methods, BookPut.Handle);
app.MapMethods(BookDelete.Template, BookDelete.Methods, BookDelete.Handle);


app.Run();

