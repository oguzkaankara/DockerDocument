FROM mcr.microsoft.com/dotnet/aspnet:7.0 
#From komutu bir image almam�z� sa�lar.
WORKDIR /App
#WORKDIR: image i�erisinde bir app klas�r� ekledik, workdir klas�r eklemek i�in kullan�lmaktad�r.  
COPY bin/Release/net7.0/publish/
#Copy: app klas�r�m�z�n i�erisine uygulamam�zdan publish edilmi� datas�n� ataca��z. benim bilgisayar�mdan imagenin i�erisine dosya g�nderece�iz. 
#biz bir net core uygulamam�z� build etti�imizde iki aassembly olu�ur 1. .dll(k�t�phane, ��kt�lar�n� program i�erisinde g�rmek istiyorsak.) 2. .exe(hi�bir program kullanmadan ��kt�lar�n� g�r�r�z)
#dosya yolunu ald�ktan sonra bu dosyay� nereye kopyalayaca��z, image i�erisinde olu�turdu�umuz app klas�r�ne kopyala diyoruz.
#komut �al��t���nda datalar� app klas�r�n�n i�erisine atacakt�r.  
ENTRYPOINT ["dotnet","DockerApi.dll"]
#ENTRYPOINT : bir imageden bir container aya��ya kalkt��� zaman �al��acak olan kodu belirlemektedir. 
#containerler imagelerin �al��abilen instanceleridir. containerin �al��abilmesi i�in ona bir dll vermemiz laz�m.
#["dotnet","DockerApi"] dotnet cll komutu �al���cak, benim dllim 