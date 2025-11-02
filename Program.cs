using revisedGymMembership.Settings;
using revisedGymMembership.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Bind SmtpSettings to the "Smtp" section in appsettings.json
builder.Services.Configure<SmtpSettings>(
    builder.Configuration.GetSection("Smtp")
);

// Register EmailService for dependency injection
builder.Services.AddTransient<EmailService>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();