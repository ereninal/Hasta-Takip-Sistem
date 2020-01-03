use SaglikOcagi
go

drop procedure if exists BDoktorGetir
go

create PROCEDURE BDoktorGetir(

    @DOKTOR_KOD NVARCHAR(5)
)
AS
BEGIN
    SELECT AD,SOYAD,UNVAN FROM KULLANICI WHERE K_KODU =@DOKTOR_KOD
END