using SigurAPI.tcdbmain;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.Map("/GetPers/{id}", GetPers);

////app.Map("/users/{id}/{name?}", HandleRequest);
////app.Map("/users", () => "Users Page");
app.Map("/", () => "Index Page");

app.Run();

////string HandleRequest(string id, string? name)
////{
////    return $"User Id: {id}   User Name: {name}";
////}


string GetPers(string id)
{
    //return $"User Id: {id}   User Name: {name}";

    using (tcdbmainContext db = new tcdbmainContext())
    {

        var p = db.Personals.Where(p => p.Id == 113).ToList();

        Console.WriteLine(p[0].Name);
    }
    return "";

}



/*
Scaffold-DbContext "server=192.168.1.164;Port=3305;user=root;password=392576;" MySql.EntityFrameworkCore -OutputDir Models -Tables tc-db-main.personal, tc-db-main.devices, tc-db-main.rulebindings, tc-db-main.accessrules, tc-db-main.ruledeps, tc-db-main.deprulebindings, tc-db-main.devbindings, tc-db-main.personal_keys, tc-db-main.devrulebindings, tc-db-main.sideparamvalues, tc-db-main.sideparamtypes, tc-db-main.positions_list, tc-db-log.logs -f



Scaffold-DbContext "server=192.168.1.164;Port=3305;user=root;password=392576;database=tc-db-main;" MySql.EntityFrameworkCore -OutputDir tcdbmain -Tables personal, devices, rulebindings, accessrules, ruledeps, deprulebindings, devbindings, personal_keys, devrulebindings, sideparamvalues, sideparamtypes, positions_list -f

Scaffold-DbContext "server=192.168.1.164;Port=3305;user=root;password=392576;database=tc-db-logs;" MySql.EntityFrameworkCore -OutputDir tcdblogs -Tables logs -f


*/