using SigurAPI.tcdbmain;
using SigurAPI.tcdblogs;
using System.Text.Json;
using System.Text.Json.Serialization;


using Microsoft.EntityFrameworkCore;
using System.Text.Encodings.Web;
using System.Text;
using Org.BouncyCastle.Utilities;
using System.Net.Http.Json;
using System.Security.Cryptography;


JsonSerializerOptions jsonoptions = new JsonSerializerOptions
{
    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
    WriteIndented = true
};


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.Map("/GetPers/{id:int?}", GetPers);
app.Map("/GetPersTabid/{tabid?}", GetPersTabid);

////app.Map("/users/{id}/{name?}", HandleRequest);
////app.Map("/users", () => "Users Page");
//app.Map("/", () => "Index Page");
app.Map("/", GetPersTabid);

app.Run();

////string HandleRequest(string id, string? name)
////{
////    return $"User Id: {id}   User Name: {name}";
////}


object GetPers(int? id = 0)
{
    if (id != 0)
    {
        using (tcdbmainContext db = new tcdbmainContext())
        {
            var p = db.Personals.Where(p => p.Id == id).ToList();
            var json = JsonSerializer.Serialize(p, jsonoptions);
            Console.WriteLine(json);
            return json;
        }
    }

    return false;

}

object GetPersTabid(string tabid = "хотп-00017")
{
    if (tabid != "")
    {
        
        using (tcdbmainContext db = new tcdbmainContext())
        {
            //var p = db.Personals
            //    .Where(p => p.Tabid == tabid && p.Status == "AVAILABLE")

            //    .Select(p => new { p.Id, p.Name, p.Pos, p.ParentId, p.Codekey })
            //    .ToList();

            //var p = db.Personals.Join(db.Personals,

            //    pid => pid.ParentId,
            //    id => id.Id,
            //    (pid,id) => new { 
            //        Name = pid.Name,
            //        Otd = id.Name,
            //        TabId = pid.Tabid
            //    }

            //    ).Where(a => a.TabId == tabid && a. == "AVAILABLE" );


            var p = from u in db.Personals
                    
                    join o in db.Personals on u.ParentId equals o.Id into grouping
                    from r in grouping.DefaultIfEmpty()
                    where u.Tabid == tabid && u.Status == "AVAILABLE"
                    select new { name = u.Name, otdel = r.Name, tabid = u.Tabid, pos = u.Pos }
                        ;

            //string Codekeyb64 = Convert.ToBase64String(p[0].Codekey);
            //Console.WriteLine(Codekeyb64);

            //byte[] bytes = System.Convert.FromBase64String(Codekeyb64);
            //Console.WriteLine(Convert.ToHexString(bytes));

            var json = JsonSerializer.Serialize(p, jsonoptions);
            
            //Console.WriteLine(json);


            return json;
        }
    }

    return false;

}




/*
Scaffold-DbContext "server=192.168.1.164;Port=3305;user=root;password=392576;" MySql.EntityFrameworkCore -OutputDir Models -Tables tc-db-main.personal, tc-db-main.devices, tc-db-main.rulebindings, tc-db-main.accessrules, tc-db-main.ruledeps, tc-db-main.deprulebindings, tc-db-main.devbindings, tc-db-main.personal_keys, tc-db-main.devrulebindings, tc-db-main.sideparamvalues, tc-db-main.sideparamtypes, tc-db-main.positions_list, tc-db-log.logs -f



Scaffold-DbContext "server=192.168.1.164;Port=3305;user=root;password=392576;database=tc-db-main;" MySql.EntityFrameworkCore -OutputDir tcdbmain -Tables personal, devices, rulebindings, accessrules, ruledeps, deprulebindings, devbindings, personal_keys, devrulebindings, sideparamvalues, sideparamtypes, positions_list -f

Scaffold-DbContext "server=192.168.1.164;Port=3305;user=root;password=392576;database=tc-db-logs;" MySql.EntityFrameworkCore -OutputDir tcdblogs -Tables logs -f


*/