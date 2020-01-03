USE SaglikOcagi
GO

DROP PROCEDURE IF EXISTS HastaEkle
GO

CREATE PROCEDURE HastaEkle(
    @TCKIMLIK_NO NVARCHAR(11),
    @DOSYA_NO NVARCHAR(5),
    @AD NVARCHAR(15),
    @SOYAD NVARCHAR(15),
    @DOGUM_YERI NVARCHAR(15),
    @DOGUM_TARIHI DATE,
    @BABA_AD NVARCHAR(15),
    @ANNE_AD NVARCHAR(15),
    @CINSIYET NVARCHAR(6),
    @KAN_GRUBU NVARCHAR(10),
    @MEDENI_HAL NVARCHAR(10),
    @ADRES NVARCHAR(255),
    @TEL NVARCHAR(11),
    @KURUM_SICIL_NO NVARCHAR(15),
    @KURUM_AD NVARCHAR(50),
    @YAKIN_TEL NVARCHAR(11),
    @YAKIN_KURUM_SICIL_NO NVARCHAR(15),
    @YAKIN_KURUM_AD NVARCHAR(50)

)
AS
BEGIN
INSERT INTO HASTA (
        TCKIMLIK_NO,
        DOSYA_NO,
        AD,
        SOYAD,
        DOGUM_YERI,
        DOGUM_TARIHI,
        BABA_ADI,
        ANNE_ADI,
        CINSIYET,
        KAN_GRUBU,
        MEDENI_HAL,
        ADRES,
        TEL,
        KURUM_SICIL_NO,
        KURUM_ADI,
        YAKIN_TEL,
        YAKIN_KURUM_SICIL_NO,
        YAKIN_KURUM_ADI)
        VALUES (
               @TCKIMLIK_NO,
               @DOSYA_NO,
               @AD,
               @SOYAD,
               @DOGUM_YERI,
               @DOGUM_TARIHI,
               @BABA_AD,
               @ANNE_AD,
               @CINSIYET,
               @KAN_GRUBU,
               @MEDENI_HAL,
               @ADRES,
               @TEL,
               @KURUM_SICIL_NO,
               @KURUM_AD,
               @YAKIN_TEL,
               @YAKIN_KURUM_SICIL_NO,
               @YAKIN_KURUM_AD)
END