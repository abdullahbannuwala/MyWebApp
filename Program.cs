using FastEndpoints;
using FastEndpoints.Security;

var bld = WebApplication.CreateBuilder();
bld.Services.AddFastEndpoints();

var app = bld.Build();
app.UseFastEndpoints();
app.Run();
