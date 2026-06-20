using Microsoft.EntityFrameworkCore;
using MVC_CodeFirstApproch.EFMVCORMDB;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

//var constring = "Server=.;Database=Db_MVCCore_2016;Trusted_Connection=True;TrustServerCertificate=True;";

var constring = builder.Configuration.GetConnectionString("ConMVCDATABASE");
builder.Services.AddDbContext<ORMCLASSFORDB>(L => L.UseSqlServer(constring));



var app = builder.Build();




app.UseRouting();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
