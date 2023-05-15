var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


/*
 * 1.adým:
 api projesinde sað týklayýp add dediðinde docker support týklayýp linux çýkýnca entere basýnca bir 
bir docker file dosyasý açýkmaktadýr.
docker fileye git. 

2.adým
bizim bir iþletim sistemi lazým onun üzerinde aspmet core uygulamamýzý console uygulamamýzý çalýþtýracak
gerekli kütüphanelerin bulunduðu bir iþletim sistemi lazým. 
biz bunu microsoftun docker hub tarafýnda orjinal imageler var onlardan alacaðýz. 
bize öyle bir image lazýmki, biz runtime ile çalýþtýralým, sdk ile geliþtirme yaparýz, biz publish edeceðimiz ve geliþtirmelerimizi localde yapacaðýmýz için runtime yeterli
Docker hubdan runtime kodunu alalým, mcr.microsoft.com/dotnet/aspnet:7.0 buradaki :7.0 dagdýr versiyondur. eðer : olmasa en son versiyonunu çeker.
ilgili imageyi aldýk (mcr.microsoft.com/dotnet/aspnet:7.0 )docker.file git.

 */