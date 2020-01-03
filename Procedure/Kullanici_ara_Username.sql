use SaglikOcagi
go
drop PROCEDURE if EXISTS KullaniciAraUsername
go

CREATE PROCEDURE KullaniciAraUsername(

    
    @USERNAME NVARCHAR(50)
)
AS
BEGIN
    SELECT * from KULLANICI 
    WHERE USERNAME = @USERNAME
END