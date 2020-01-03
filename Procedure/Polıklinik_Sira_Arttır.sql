USE SaglikOcagi
GO

DROP PROCEDURE IF EXISTS PoliklinikSiraArttır
GO

CREATE PROCEDURE PoliklinikSiraArttır(
    @DOKTOR_KOD NVARCHAR(5),
    @SIRA_NO INT,
    @TARIH DATE

)
AS
BEGIN
    SET @SIRA_NO = (SELECT COUNT(*) FROM POLIKLINIK_SIRA
        WHERE TARIH = @TARIH
        AND K_KODU = @DOKTOR_KOD)

        IF @SIRA_NO = 0
        BEGIN
            SELECT 1 AS SIRA_NO
        END
        
        IF @SIRA_NO = 1
        BEGIN
            SELECT SIRA_NO + 1 AS SIRA_NO FROM POLIKLINIK_SIRA
            WHERE TARIH = @TARIH
            AND K_KODU = @DOKTOR_KOD
        END
END
