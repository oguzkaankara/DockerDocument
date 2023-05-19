FROM mcr.microsoft.com/dotnet/aspnet:7.0 
WORKDIR /app
COPY . .
# . ile asp net mvc içerisindeki tüm klasörleri ki projemiz aspnet mvc projesidir. 
#  . dediðimiz zaman docker file içerisindeki tüm klasörleri ve dosyalarý ifade eder.
# ikinci nokta image içerisindeki o anki  çalýþma dosyasý yani weokdir nerede ise o dosya
# kopyy ile beraber bütün dosyalar app komutunun içerine geldi. 
RUN dotnet restore 
# restorenin yapmýþ olduðu iþlem publish iþleminde eðer güncellenicek bir library var ise  veya bu library eklenmiþtir ama nudget manage packeden çekilmemiþtir. 
RUN dotnet publish DockerApi.csproj -c Realese -o out
#dockerfiledeki .csproju publish edeceðiz.  -c Realese modda publish edeceksin.-o nereye publish edeceksin out klasörünün içerisine 
# eðer /out dersek yeni bir kasör oluþturur fakat, appin içerisinde out klasörü oluþturmak istiyorsak sadece out yazarýz. 
#ve bu klasörün içerisine publish edilmiþ dosyalarý atacak. 
WORKDIR out 
#workdirimizi out olarak belirttik.
ENV ASPNETCORE_URLS=
#Bu environment localhost 5000 olarak default ayaðýya kaldýrýldýðýndan dolayý, uygulamayý sdk içerisinde çalýþtýrdýðýmýzda,
#localhost 5000 olarak ayaðýya kaldýrýrý.
#Sen http de çalýþ, biz portu bilmiyoruz yýldýz ile ne gelirse onu al default olarak 4500 de çalýþ. 
ENTRYPOINT ["dotnet","DockerApi.dll"]