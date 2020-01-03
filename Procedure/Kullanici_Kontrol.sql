
use SaglikOcagi
GO

drop PROCEDURE IF EXISTS PoliklinikGetir
GO

CREATE PROCEDURE KullaniciKontrol(
    @username nvarchar(25),
    @sifre NVARCHAR(25)
)
AS
BEGIN 
    SELECT * FROM KULLANICI where USERNAME =@username and SIFRE =@sifre 
END    
