use SaglikOcagi
GO
drop PROCEDURE if EXISTS PoliklinikGetir
go

CREATE PROCEDURE PoliklinikGetir(

    @POLIKLINIK_AD NVARCHAR(25)
)
AS
BEGIN
    SELECT * FROM POLIKLINIK
    WHERE (@POLIKLINIK_AD IS NULL OR POLIKLINIK_AD=@POLIKLINIK_AD)
END
