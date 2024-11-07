//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddRazorPages();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//}
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapRazorPages();

//app.Run();

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Map("/users/{id}/{name?}", HandleRequest);
app.Map("/users", () => "Users Page");
app.Map("/", () => "Index Page");

app.Run();

string HandleRequest(string id, string? name)
{
    return $"User Id: {id}   User Name: {name}";
}




/*
 * Scaffold-DbContext "server=192.168.1.164;Port=3305;user=root;password=392576;" MySql.EntityFrameworkCore -OutputDir Models -Tables tc-db-main.personal, tc-db-main.devices, tc-db-log.logs -f
 * 
 */
