FROM mcr.microsoft.com/dotnet/aspnet:7.0 
#From komutu bir image almamýzý saðlar.
WORKDIR /App
#WORKDIR: image içerisinde bir app klasörü ekledik, workdir klasör eklemek için kullanýlmaktadýr.  
COPY bin/Release/net7.0/publish/
#Copy: app klasörümüzün içerisine uygulamamýzdan publish edilmiþ datasýný atacaðýz. benim bilgisayarýmdan imagenin içerisine dosya göndereceðiz. 
#biz bir net core uygulamamýzý build ettiðimizde iki aassembly oluþur 1. .dll(kütüphane, çýktýlarýný program içerisinde görmek istiyorsak.) 2. .exe(hiçbir program kullanmadan çýktýlarýný görürüz)
#dosya yolunu aldýktan sonra bu dosyayý nereye kopyalayacaðýz, image içerisinde oluþturduðumuz app klasörüne kopyala diyoruz.
#komut çalýþtýðýnda datalarý app klasörünün içerisine atacaktýr.  
ENTRYPOINT ["dotnet","DockerApi.dll"]
#ENTRYPOINT : bir imageden bir container ayaðýya kalktýðý zaman çalýþacak olan kodu belirlemektedir. 
#containerler imagelerin çalýþabilen instanceleridir. containerin çalýþabilmesi için ona bir dll vermemiz lazým.
#["dotnet","DockerApi"] dotnet cll komutu çalýþýcak, benim dllim 