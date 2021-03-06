use SaglikOcagi
GO

DROP PROCEDURE IF EXISTS CikisEkle
GO

CREATE PROCEDURE CikisEkle(
    @DOSYA_NO NVARCHAR(5),
    @SEVK_TARIHI DATE,
    @CIKIS_SAATİ TIME,
    @ODEME NVARCHAR(20),
    @TOPLAM_TUTAR NVARCHAR(20)
)
AS
BEGIN
    INSERT INTO CIKIS(DOSYA_NO,SEVK_TARIHI,CIKIS_SAATI,ODEME,TOPLAM_TUTAR)
    VALUES(@DOSYA_NO,@SEVK_TARIHI,@CIKIS_SAATİ,@ODEME,@TOPLAM_TUTAR)
END
