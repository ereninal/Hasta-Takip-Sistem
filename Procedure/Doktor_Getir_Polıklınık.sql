use SaglikOcagi
GO
drop PROCEDURE if EXISTS DoktorGetirPoliklinik
GO
 CREATE PROCEDURE DoktorGetirPoliklinik(
    @POLIKLINIK_ID INT
 )
 AS
 BEGIN
    SELECT AD,SOYAD FROM KULLANICI WHERE POLIKLINIK_ID =@POLIKLINIK_ID
 END
