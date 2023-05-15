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
 * 1.ad�m:
 api projesinde sa� t�klay�p add dedi�inde docker support t�klay�p linux ��k�nca entere bas�nca bir 
bir docker file dosyas� a��kmaktad�r.
docker fileye git. 

2.ad�m
bizim bir i�letim sistemi laz�m onun �zerinde aspmet core uygulamam�z� console uygulamam�z� �al��t�racak
gerekli k�t�phanelerin bulundu�u bir i�letim sistemi laz�m. 
biz bunu microsoftun docker hub taraf�nda orjinal imageler var onlardan alaca��z. 
bize �yle bir image laz�mki, biz runtime ile �al��t�ral�m, sdk ile geli�tirme yapar�z, biz publish edece�imiz ve geli�tirmelerimizi localde yapaca��m�z i�in runtime yeterli
Docker hubdan runtime kodunu alal�m, mcr.microsoft.com/dotnet/aspnet:7.0 buradaki :7.0 dagd�r versiyondur. e�er : olmasa en son versiyonunu �eker.
ilgili imageyi ald�k (mcr.microsoft.com/dotnet/aspnet:7.0 )docker.file git.

 */