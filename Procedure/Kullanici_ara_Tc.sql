use SaglikOcagi
go
drop PROCEDURE if EXISTS KullaniciAraTC
go

CREATE PROCEDURE KullaniciAraTC(

    
    @KULLANICI_TCKIMLIKNO NVARCHAR(11)
)
AS
BEGIN
    SELECT * from KULLANICI 
    WHERE TCKIMLIK_NO = @KULLANICI_TCKIMLIKNO
END