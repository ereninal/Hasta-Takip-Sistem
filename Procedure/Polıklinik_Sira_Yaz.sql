USE SaglikOcagi
GO

DROP PROCEDURE IF EXISTS PoliklinikSiraYaz
GO

CREATE PROCEDURE PoliklinikSiraYaz(
    @DOKTOR_KOD NVARCHAR(5),
    @SIRA_NO INT,
    @TARIH DATE

)
AS
BEGIN
    IF @SIRA_NO = 1
        BEGIN
            INSERT INTO POLIKLINIK_SIRA (K_KODU,SIRA_NO,TARIH)
            VALUES(@DOKTOR_KOD,@SIRA_NO,@TARIH)
        END

        IF @SIRA_NO > 1
        BEGIN
            UPDATE POLIKLINIK_SIRA 
            SET SIRA_NO = @SIRA_NO
            WHERE K_KODU = @DOKTOR_KOD
            AND TARIH = @TARIH
        END
END
