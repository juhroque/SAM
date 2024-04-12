using SAM.Application.Services;

var builder = WebApplication.CreateBuilder(args);

{
    builder.Services.AddControllers();
    builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
}
var app = builder.Build();

{
    app.UseHttpsRedirection();
    app.MapControllers();
}


app.Run();
