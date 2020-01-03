USE [SaglikOcagi]
GO
/****** Object:  Table [dbo].[CIKIS]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CIKIS](
	[DOSYA_NO] [nvarchar](5) NULL,
	[SEVK_TARIHI] [date] NULL,
	[CIKIS_SAATI] [datetime] NULL,
	[ODEME] [nvarchar](20) NULL,
	[TOPLAM_TUTAR] [nvarchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HASTA]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HASTA](
	[TCKIMLIK_NO] [nvarchar](11) NOT NULL,
	[DOSYA_NO] [nvarchar](5) NULL,
	[AD] [nvarchar](15) NULL,
	[SOYAD] [nvarchar](15) NULL,
	[DOGUM_YERI] [nvarchar](15) NULL,
	[DOGUM_TARIHI] [date] NULL,
	[BABA_ADI] [nvarchar](15) NULL,
	[ANNE_ADI] [nvarchar](15) NULL,
	[CINSIYET] [nvarchar](6) NULL,
	[KAN_GRUBU] [nvarchar](10) NULL,
	[MEDENI_HAL] [nvarchar](10) NULL,
	[ADRES] [nvarchar](255) NULL,
	[TEL] [nvarchar](11) NULL,
	[KURUM_SICIL_NO] [nvarchar](15) NULL,
	[KURUM_ADI] [nvarchar](50) NULL,
	[YAKIN_TEL] [nvarchar](11) NULL,
	[YAKIN_KURUM_SICIL_NO] [nvarchar](10) NULL,
	[YAKIN_KURUM_ADI] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ISLEM]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ISLEM](
	[ISLEM_ID] [int] NOT NULL,
	[ISLEM_ADI] [nvarchar](50) NULL,
	[BIRIM_FIYAT] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ISLEM_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KULLANICI]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KULLANICI](
	[K_KODU] [nvarchar](5) NOT NULL,
	[AD] [nvarchar](20) NULL,
	[SOYAD] [nvarchar](20) NULL,
	[SIFRE] [nvarchar](20) NULL,
	[YETKİ] [nvarchar](5) NULL,
	[EV_TEL] [nvarchar](11) NULL,
	[CEP_TEL] [nvarchar](11) NULL,
	[ADRES] [nvarchar](255) NULL,
	[UNVAN] [nvarchar](15) NULL,
	[ISE_BASLAMA] [date] NULL,
	[MAAS] [nvarchar](15) NULL,
	[DOGUM_YERI] [nvarchar](20) NULL,
	[ANNE_ADI] [nvarchar](20) NULL,
	[BABA_ADI] [nvarchar](20) NULL,
	[CINSIYET] [nvarchar](5) NULL,
	[KAN_GRUBU] [nvarchar](10) NULL,
	[MEDENI_HAL] [nvarchar](10) NULL,
	[DOGUM_TARIHI] [date] NULL,
	[TCKIMLIK_NO] [nvarchar](11) NULL,
	[USERNAME] [nvarchar](50) NULL,
	[POLIKLINIK_ID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[POLIKLINIK]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[POLIKLINIK](
	[POLIKLINIK_ID] [int] IDENTITY(1,1) NOT NULL,
	[POLIKLINIK_AD] [nvarchar](50) NOT NULL,
	[DURUM] [nvarchar](5) NULL,
	[ACIKLAMA] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[POLIKLINIK_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[POLIKLINIK_SIRA]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[POLIKLINIK_SIRA](
	[K_KODU] [nvarchar](5) NULL,
	[SIRA_NO] [int] NULL,
	[TARIH] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SEVK]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SEVK](
	[SEVK_TARİHİ] [date] NOT NULL,
	[DOSYA_NO] [nvarchar](5) NULL,
	[POLIKLINIK_ID] [int] NULL,
	[SAAT] [time](7) NULL,
	[YAPILAN_ISLEM] [nvarchar](50) NULL,
	[DOKTOR_KOD] [nvarchar](5) NULL,
	[MIKTAR] [char](3) NULL,
	[BIRIM_FIYAT] [nvarchar](20) NULL,
	[SIRA] [int] NULL,
	[TOPLAM_TUTAR] [nvarchar](50) NULL,
	[TABURCU] [nvarchar](50) NULL,
	[SEVK_ID] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[CIKIS] ([DOSYA_NO], [SEVK_TARIHI], [CIKIS_SAATI], [ODEME], [TOPLAM_TUTAR]) VALUES (N'00001', CAST(N'2019-12-16' AS Date), CAST(N'1900-01-01T22:01:30.157' AS DateTime), N'Nakit', N'120 TL')
INSERT [dbo].[CIKIS] ([DOSYA_NO], [SEVK_TARIHI], [CIKIS_SAATI], [ODEME], [TOPLAM_TUTAR]) VALUES (N'00001', CAST(N'2019-12-16' AS Date), CAST(N'1900-01-01T22:02:29.620' AS DateTime), N'Nakit', N'120 TL')
INSERT [dbo].[HASTA] ([TCKIMLIK_NO], [DOSYA_NO], [AD], [SOYAD], [DOGUM_YERI], [DOGUM_TARIHI], [BABA_ADI], [ANNE_ADI], [CINSIYET], [KAN_GRUBU], [MEDENI_HAL], [ADRES], [TEL], [KURUM_SICIL_NO], [KURUM_ADI], [YAKIN_TEL], [YAKIN_KURUM_SICIL_NO], [YAKIN_KURUM_ADI]) VALUES (N'32419122936', N'00001', N'EREN', N'İNAL', N'Erzincan', CAST(N'2019-12-18' AS Date), N'', N'qwewqe', N'Bay', N'A Rh+', N'Evli', N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[HASTA] ([TCKIMLIK_NO], [DOSYA_NO], [AD], [SOYAD], [DOGUM_YERI], [DOGUM_TARIHI], [BABA_ADI], [ANNE_ADI], [CINSIYET], [KAN_GRUBU], [MEDENI_HAL], [ADRES], [TEL], [KURUM_SICIL_NO], [KURUM_ADI], [YAKIN_TEL], [YAKIN_KURUM_SICIL_NO], [YAKIN_KURUM_ADI]) VALUES (N'12312312312', N'00002', N'adasd', N'asdsadsa', N'', CAST(N'2019-12-18' AS Date), N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[ISLEM] ([ISLEM_ID], [ISLEM_ADI], [BIRIM_FIYAT]) VALUES (1, N'Muayane', N'50')
INSERT [dbo].[ISLEM] ([ISLEM_ID], [ISLEM_ADI], [BIRIM_FIYAT]) VALUES (2, N'Röntgen', N'70')
INSERT [dbo].[ISLEM] ([ISLEM_ID], [ISLEM_ADI], [BIRIM_FIYAT]) VALUES (3, N'Emar', N'100')
INSERT [dbo].[ISLEM] ([ISLEM_ID], [ISLEM_ADI], [BIRIM_FIYAT]) VALUES (4, N'Kanal Tedavisi', N'300')
INSERT [dbo].[ISLEM] ([ISLEM_ID], [ISLEM_ADI], [BIRIM_FIYAT]) VALUES (5, N'Check-Up', N'1000')
INSERT [dbo].[KULLANICI] ([K_KODU], [AD], [SOYAD], [SIFRE], [YETKİ], [EV_TEL], [CEP_TEL], [ADRES], [UNVAN], [ISE_BASLAMA], [MAAS], [DOGUM_YERI], [ANNE_ADI], [BABA_ADI], [CINSIYET], [KAN_GRUBU], [MEDENI_HAL], [DOGUM_TARIHI], [TCKIMLIK_NO], [USERNAME], [POLIKLINIK_ID]) VALUES (N'00001', N'EREN', N'INAL', N'12345', N'EVET', N'', N'', N'şarköy', N'Doktor', CAST(N'2019-12-14' AS Date), N'', N'İstanbul', N'', N'', N'Bay', N'A Rh+', N'Evli', CAST(N'1994-10-14' AS Date), N'32419122934', N'ereninal@hastane.com', 2)
INSERT [dbo].[KULLANICI] ([K_KODU], [AD], [SOYAD], [SIFRE], [YETKİ], [EV_TEL], [CEP_TEL], [ADRES], [UNVAN], [ISE_BASLAMA], [MAAS], [DOGUM_YERI], [ANNE_ADI], [BABA_ADI], [CINSIYET], [KAN_GRUBU], [MEDENI_HAL], [DOGUM_TARIHI], [TCKIMLIK_NO], [USERNAME], [POLIKLINIK_ID]) VALUES (N'00002', N'ONUR', N'GENC', N'123', N'HAYIR', N'', N'', N'', N'Hizmetli', CAST(N'2019-12-26' AS Date), N'2324', N'', N'', N'', N'', N'', N'', CAST(N'1980-12-31' AS Date), N'32419122936', N'onur@hastane.com', NULL)
INSERT [dbo].[KULLANICI] ([K_KODU], [AD], [SOYAD], [SIFRE], [YETKİ], [EV_TEL], [CEP_TEL], [ADRES], [UNVAN], [ISE_BASLAMA], [MAAS], [DOGUM_YERI], [ANNE_ADI], [BABA_ADI], [CINSIYET], [KAN_GRUBU], [MEDENI_HAL], [DOGUM_TARIHI], [TCKIMLIK_NO], [USERNAME], [POLIKLINIK_ID]) VALUES (N'00003', N'SABRI', N'EKREM', N'12345', N'HAYIR', N'', N'', N'', N'', CAST(N'2019-12-26' AS Date), N'', N'', N'AYŞE', N'EKREM', N'', N'', N'', CAST(N'1980-12-31' AS Date), N'20785853806', N'sabri@hastane.com', NULL)
SET IDENTITY_INSERT [dbo].[POLIKLINIK] ON 

INSERT [dbo].[POLIKLINIK] ([POLIKLINIK_ID], [POLIKLINIK_AD], [DURUM], [ACIKLAMA]) VALUES (1, N'DİŞ HEKİMİ', N'AKTİF', N'GENEL')
INSERT [dbo].[POLIKLINIK] ([POLIKLINIK_ID], [POLIKLINIK_AD], [DURUM], [ACIKLAMA]) VALUES (2, N'DAHİLİYE', N'AKTİF', N'+65 YAŞ VE ÜSTÜ HASTALAR')
INSERT [dbo].[POLIKLINIK] ([POLIKLINIK_ID], [POLIKLINIK_AD], [DURUM], [ACIKLAMA]) VALUES (6, N'CİLDİYE', N'PATİF', N'ASDASD')
SET IDENTITY_INSERT [dbo].[POLIKLINIK] OFF
INSERT [dbo].[POLIKLINIK_SIRA] ([K_KODU], [SIRA_NO], [TARIH]) VALUES (N'00001', 22, CAST(N'2019-12-16' AS Date))
INSERT [dbo].[POLIKLINIK_SIRA] ([K_KODU], [SIRA_NO], [TARIH]) VALUES (N'00001', 1, CAST(N'2019-12-17' AS Date))
INSERT [dbo].[POLIKLINIK_SIRA] ([K_KODU], [SIRA_NO], [TARIH]) VALUES (N'00001', 1, CAST(N'2019-12-19' AS Date))
INSERT [dbo].[POLIKLINIK_SIRA] ([K_KODU], [SIRA_NO], [TARIH]) VALUES (N'00001', 1, CAST(N'2020-01-01' AS Date))
INSERT [dbo].[POLIKLINIK_SIRA] ([K_KODU], [SIRA_NO], [TARIH]) VALUES (N'00001', 1, CAST(N'2019-12-22' AS Date))
INSERT [dbo].[POLIKLINIK_SIRA] ([K_KODU], [SIRA_NO], [TARIH]) VALUES (N'00001', 6, CAST(N'2020-01-03' AS Date))
INSERT [dbo].[POLIKLINIK_SIRA] ([K_KODU], [SIRA_NO], [TARIH]) VALUES (N'00001', 1, CAST(N'2020-01-18' AS Date))
INSERT [dbo].[POLIKLINIK_SIRA] ([K_KODU], [SIRA_NO], [TARIH]) VALUES (N'00001', 1, CAST(N'2020-01-17' AS Date))
INSERT [dbo].[POLIKLINIK_SIRA] ([K_KODU], [SIRA_NO], [TARIH]) VALUES (N'00001', 1, CAST(N'2020-01-11' AS Date))
INSERT [dbo].[POLIKLINIK_SIRA] ([K_KODU], [SIRA_NO], [TARIH]) VALUES (N'00001', 1, CAST(N'2020-01-29' AS Date))
INSERT [dbo].[POLIKLINIK_SIRA] ([K_KODU], [SIRA_NO], [TARIH]) VALUES (N'00001', 1, CAST(N'2020-01-19' AS Date))
INSERT [dbo].[POLIKLINIK_SIRA] ([K_KODU], [SIRA_NO], [TARIH]) VALUES (N'00001', 1, CAST(N'2020-01-16' AS Date))
INSERT [dbo].[POLIKLINIK_SIRA] ([K_KODU], [SIRA_NO], [TARIH]) VALUES (N'00001', 1, CAST(N'2020-01-09' AS Date))
INSERT [dbo].[POLIKLINIK_SIRA] ([K_KODU], [SIRA_NO], [TARIH]) VALUES (N'00001', 1, CAST(N'2020-01-30' AS Date))
ALTER TABLE [dbo].[KULLANICI]  WITH CHECK ADD  CONSTRAINT [FK_KULLANICI_POLIKLINIK] FOREIGN KEY([POLIKLINIK_ID])
REFERENCES [dbo].[POLIKLINIK] ([POLIKLINIK_ID])
GO
ALTER TABLE [dbo].[KULLANICI] CHECK CONSTRAINT [FK_KULLANICI_POLIKLINIK]
GO
/****** Object:  StoredProcedure [dbo].[BDoktorGetir]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[BDoktorGetir](

    @DOKTOR_KOD NVARCHAR(5)
)
AS
BEGIN
    SELECT AD,SOYAD,UNVAN FROM KULLANICI WHERE K_KODU =@DOKTOR_KOD
END
GO
/****** Object:  StoredProcedure [dbo].[CikisEkle]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CikisEkle](
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
GO
/****** Object:  StoredProcedure [dbo].[DoktorGetir]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[DoktorGetir](

    @DOKTOR_KOD NVARCHAR(5)
)
AS
BEGIN
    SELECT AD,SOYAD,UNVAN FROM KULLANICI WHERE K_KODU =@DOKTOR_KOD
END
GO
/****** Object:  StoredProcedure [dbo].[DoktorGetirPoliklinik]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[DoktorGetirPoliklinik](
    @POLIKLINIK_ID INT
 )
 AS
 BEGIN
    SELECT AD,SOYAD FROM KULLANICI WHERE POLIKLINIK_ID =@POLIKLINIK_ID
 END
GO
/****** Object:  StoredProcedure [dbo].[DosyaNoAra]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DosyaNoAra](

    @DOSYA_NO NVARCHAR(11)
    
)
AS
BEGIN
    SELECT * FROM HASTA WHERE  HASTA.DOSYA_NO LIKE '%'+@DOSYA_NO +'%' 
END
GO
/****** Object:  StoredProcedure [dbo].[GenelHastaArama]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GenelHastaArama](
    @BASLANGİC_TARIH DATE,
    @BITIS_TARIH DATE,
    @DURUM NVARCHAR(5)
)
AS
BEGIN
    SELECT POLIKLINIK.POLIKLINIK_AD ,SEVK.SEVK_TARİHİ,SEVK.DOSYA_NO,
    SEVK.YAPILAN_ISLEM,KULLANICI.AD AS DOKTOR_AD,KULLANICI.SOYAD AS DOKTOR_SOYAD,
    SEVK.MIKTAR,SEVK.BIRIM_FIYAT,SEVK.SIRA,SEVK.TOPLAM_TUTAR,SEVK.TABURCU,HASTA.AD as HASTA_AD,
    HASTA.SOYAD AS HASTA_SOYAD,HASTA.TCKIMLIK_NO FROM SEVK
    INNER JOIN POLIKLINIK ON SEVK.POLIKLINIK_ID= POLIKLINIK.POLIKLINIK_ID 
    INNER JOIN KULLANICI ON KULLANICI.K_KODU = SEVK.DOKTOR_KOD
    INNER JOIN HASTA ON HASTA.DOSYA_NO = SEVK.DOSYA_NO
    WHERE SEVK.SEVK_TARİHİ < @BITIS_TARIH AND SEVK.SEVK_TARİHİ >@BASLANGİC_TARIH
    AND (@DURUM IS NULL OR SEVK.TABURCU =@DURUM) 
END   
GO
/****** Object:  StoredProcedure [dbo].[HastaAraTC]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[HastaAraTC](
    @TC NVARCHAR(11)
)
AS
BEGIN
SELECT TCKIMLIK_NO FROM HASTA WHERE TCKIMLIK_NO =@TC 
END
GO
/****** Object:  StoredProcedure [dbo].[HastaEkle]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[HastaEkle](
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
GO
/****** Object:  StoredProcedure [dbo].[HastaGetir]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[HastaGetir](
    @HASTA_DOSYA_NO NVARCHAR(5)

)
AS
BEGIN
    SELECT * FROM HASTA WHERE DOSYA_NO=@HASTA_DOSYA_NO
END
GO
/****** Object:  StoredProcedure [dbo].[HastaGuncelle]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[HastaGuncelle](
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
UPDATE HASTA
        SET TCKIMLIK_NO = @TCKIMLIK_NO,
            AD = @AD,
            SOYAD = @SOYAD,
            DOGUM_YERI = @DOGUM_YERI,
            DOGUM_TARIHI = @DOGUM_TARIHI,
            BABA_ADI = @BABA_AD,
            ANNE_ADI = @ANNE_AD,
            CINSIYET = @CINSIYET,
            KAN_GRUBU = @KAN_GRUBU,
            MEDENI_HAL = @MEDENI_HAL,
            ADRES = @ADRES,
            TEL = @TEL,
            KURUM_SICIL_NO = @KURUM_SICIL_NO,
            KURUM_ADI = @KURUM_AD,
            YAKIN_TEL = @YAKIN_TEL,
            YAKIN_KURUM_SICIL_NO = @YAKIN_KURUM_SICIL_NO,
            YAKIN_KURUM_ADI = @YAKIN_KURUM_AD WHERE DOSYA_NO =@DOSYA_NO
END
GO
/****** Object:  StoredProcedure [dbo].[HastaSayi]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[HastaSayi]
AS
BEGIN
    SELECT COUNT(*) FROM HASTA
END
GO
/****** Object:  StoredProcedure [dbo].[IsımAra]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[IsımAra](

    @HASTA_AD NVARCHAR(20),
    @HASTA_SOYAD NVARCHAR(20)
)
AS
BEGIN
    SELECT * FROM HASTA WHERE (@HASTA_AD IS NULL OR HASTA.AD LIKE '%'+@HASTA_AD +'%' )
    AND (@HASTA_SOYAD IS NULL OR HASTA.SOYAD LIKE '%' +@HASTA_SOYAD +'%')
END
GO
/****** Object:  StoredProcedure [dbo].[IslemGetir]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[IslemGetir](

    @ISLEM_AD NVARCHAR(30)
)
AS
BEGIN
    SELECT * FROM ISLEM 
    WHERE (@ISLEM_AD IS NULL OR ISLEM_ADI=@ISLEM_AD)
END
GO
/****** Object:  StoredProcedure [dbo].[KullaniciAraTC]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[KullaniciAraTC](

    
    @KULLANICI_TCKIMLIKNO NVARCHAR(11)
)
AS
BEGIN
    SELECT * from KULLANICI 
    WHERE TCKIMLIK_NO = @KULLANICI_TCKIMLIKNO
END
GO
/****** Object:  StoredProcedure [dbo].[KullaniciAraUsername]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[KullaniciAraUsername](

    
    @USERNAME NVARCHAR(50)
)
AS
BEGIN
    SELECT * from KULLANICI 
    WHERE USERNAME = @USERNAME
END
GO
/****** Object:  StoredProcedure [dbo].[KullaniciEkle]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[KullaniciEkle](

    @KULLANICI_KODU NVARCHAR(5),
    @KULLANICI_ADI NVARCHAR(20),
    @KULLANICI_SOYADI NVARCHAR(20),
    @KULLANICI_SIFRE NVARCHAR(10),
    @KULLANICI_YETKI NVARCHAR(5),
    @KULLANICI_EVTEL NVARCHAR(11),
    @KULLANICI_CEPTEL NVARCHAR(11),
    @KULLANICI_ADRES NVARCHAR(255),
    @KULLANICI_UNVAN NVARCHAR(20),
    @KULLANICI_ISEBASLAMATARIHI DATE,
    @KULLANICI_MAAS NVARCHAR(15),
    @KULLANICI_DOGUMYERİ NVARCHAR(15),
    @KULLANICI_ANNEADI NVARCHAR(20),
    @KULLANICI_BABAADI NVARCHAR(20),
    @KULLANICI_CINSIYET NVARCHAR(5),
    @KULLANICI_KANGRUBU NVARCHAR(10),
    @KULLANICI_MEDENIHAL NVARCHAR(10),
    @KULLANICI_DOGUMTARIHI DATE,
    @KULLANICI_TCKIMLIK NVARCHAR(11),
    @KULLANICI_USERNAME NVARCHAR(50),
    @POLIKLINIK_ID INT
)
AS
BEGIN
    
    INSERT INTO 
    KULLANICI(K_KODU,AD,SOYAD,SIFRE,YETKİ,EV_TEL,CEP_TEL,ADRES,UNVAN,ISE_BASLAMA,MAAS,DOGUM_YERI,ANNE_ADI,BABA_ADI,CINSIYET,KAN_GRUBU,MEDENI_HAL,DOGUM_TARIHI,TCKIMLIK_NO,USERNAME,POLIKLINIK_ID)
    VALUES(@KULLANICI_KODU, @KULLANICI_ADI, @KULLANICI_SOYADI,@KULLANICI_SIFRE,@KULLANICI_YETKI,@KULLANICI_EVTEL,@KULLANICI_CEPTEL,@KULLANICI_ADRES,@KULLANICI_UNVAN,@KULLANICI_ISEBASLAMATARIHI,@KULLANICI_MAAS,@KULLANICI_DOGUMYERİ,@KULLANICI_ANNEADI,@KULLANICI_BABAADI,@KULLANICI_CINSIYET,@KULLANICI_KANGRUBU,@KULLANICI_MEDENIHAL,@KULLANICI_DOGUMTARIHI,@KULLANICI_TCKIMLIK,@KULLANICI_USERNAME,@POLIKLINIK_ID)

END
GO
/****** Object:  StoredProcedure [dbo].[KullaniciGetir]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[KullaniciGetir](
    @KULLANICI_AD NVARCHAR(30)
)
AS
BEGIN
    SELECT KULLANICI.K_KODU,KULLANICI.AD,KULLANICI.SOYAD,KULLANICI.SIFRE,KULLANICI.YETKİ,KULLANICI.EV_TEL,KULLANICI.CEP_TEL,KULLANICI.ADRES,
    KULLANICI.UNVAN,KULLANICI.ISE_BASLAMA,KULLANICI.MAAS,KULLANICI.DOGUM_YERI,KULLANICI.ANNE_ADI,
    KULLANICI.BABA_ADI,KULLANICI.CINSIYET,KULLANICI.KAN_GRUBU,KULLANICI.MEDENI_HAL,KULLANICI.DOGUM_TARIHI,KULLANICI.TCKIMLIK_NO,KULLANICI.USERNAME,KULLANICI.POLIKLINIK_ID,POLIKLINIK.POLIKLINIK_AD 
    FROM POLIKLINIK RIGHT JOIN KULLANICI ON POLIKLINIK.POLIKLINIK_ID = KULLANICI.POLIKLINIK_ID 
    WHERE (@KULLANICI_AD IS NULL OR KULLANICI.USERNAME =@KULLANICI_AD)
END
GO
/****** Object:  StoredProcedure [dbo].[KullaniciGuncelle]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[KullaniciGuncelle](

    @KULLANICI_KODU NVARCHAR(5),
    @KULLANICI_ADI NVARCHAR(20),
    @KULLANICI_SOYADI NVARCHAR(20),
    @KULLANICI_SIFRE NVARCHAR(10),
    @KULLANICI_YETKI NVARCHAR(5),
    @KULLANICI_EVTEL NVARCHAR(11),
    @KULLANICI_CEPTEL NVARCHAR(11),
    @KULLANICI_ADRES NVARCHAR(255),
    @KULLANICI_UNVAN NVARCHAR(20),
    @KULLANICI_ISEBASLAMATARIHI DATE,
    @KULLANICI_MAAS NVARCHAR(15),
    @KULLANICI_DOGUMYERİ NVARCHAR(15),
    @KULLANICI_ANNEADI NVARCHAR(20),
    @KULLANICI_BABAADI NVARCHAR(20),
    @KULLANICI_CINSIYET NVARCHAR(5),
    @KULLANICI_KANGRUBU NVARCHAR(10),
    @KULLANICI_MEDENIHAL NVARCHAR(10),
    @KULLANICI_DOGUMTARIHI DATE,
    @KULLANICI_TCKIMLIK NVARCHAR(11), 
    @KULLANICI_USERNAME NVARCHAR(50),
    @POLIKLINIK_ID INT
)
AS
BEGIN
    UPDATE KULLANICI
    SET AD =@KULLANICI_ADI, SOYAD=@KULLANICI_SOYADI, SIFRE=@KULLANICI_SIFRE, YETKİ=@KULLANICI_YETKI, EV_TEL=@KULLANICI_EVTEL,
    CEP_TEL =@KULLANICI_CEPTEL,ADRES=@KULLANICI_ADRES, UNVAN=@KULLANICI_UNVAN, ISE_BASLAMA=@KULLANICI_ISEBASLAMATARIHI,
    MAAS=@KULLANICI_MAAS, DOGUM_YERI=@KULLANICI_DOGUMYERİ, ANNE_ADI=@KULLANICI_ANNEADI,BABA_ADI=@KULLANICI_BABAADI,
    CINSIYET=@KULLANICI_CINSIYET,KAN_GRUBU=@KULLANICI_KANGRUBU,MEDENI_HAL=@KULLANICI_MEDENIHAL,DOGUM_TARIHI=@KULLANICI_DOGUMTARIHI,
    TCKIMLIK_NO=@KULLANICI_TCKIMLIK,USERNAME=@KULLANICI_USERNAME, POLIKLINIK_ID=@POLIKLINIK_ID WHERE K_KODU=@KULLANICI_KODU
END
GO
/****** Object:  StoredProcedure [dbo].[KullaniciKontrol]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[KullaniciKontrol](
    @username nvarchar(25),
    @sifre NVARCHAR(25)
)
AS
BEGIN 
    SELECT * FROM KULLANICI where USERNAME =@username and SIFRE =@sifre 
END    
GO
/****** Object:  StoredProcedure [dbo].[KullaniciSil]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[KullaniciSil](

    @KULLANICI_KODU NVARCHAR(5)
)
AS
BEGIN
    DELETE FROM KULLANICI WHERE K_KODU=@KULLANICI_KODU
END 
GO
/****** Object:  StoredProcedure [dbo].[KurumSicilNoAra]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[KurumSicilNoAra](

    @SICIL_NO NVARCHAR(20)
    
)
AS
BEGIN
    SELECT * FROM HASTA WHERE  HASTA.KURUM_SICIL_NO LIKE '%'+@SICIL_NO +'%' 
END
GO
/****** Object:  StoredProcedure [dbo].[OncekiIslemGetir]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[OncekiIslemGetir](

    @HASTA_DOSYA_NO NVARCHAR(5),
    @DURUM NVARCHAR(5)

)
AS
BEGIN
    SELECT * FROM SEVK where DOSYA_NO = @HASTA_DOSYA_NO AND TABURCU = @DURUM
end
GO
/****** Object:  StoredProcedure [dbo].[OncekiIslemlerTarihDosya]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[OncekiIslemlerTarihDosya](

    @HASTA_DOSYA_NO NVARCHAR(5),
    @HASTA_TARIH date,
    @DURUM NVARCHAR(5)

)
AS
BEGIN
    SELECT SEVK.SEVK_ID,POLIKLINIK.POLIKLINIK_AD,SEVK.SEVK_TARİHİ,SEVK.DOSYA_NO,SEVK.SAAT,SEVK.YAPILAN_ISLEM,
   KULLANICI.AD,KULLANICI.SOYAD,KULLANICI.UNVAN,
    SEVK.MIKTAR,SEVK.BIRIM_FIYAT,SEVK.SIRA,SEVK.TOPLAM_TUTAR,SEVK.TABURCU FROM SEVK
    INNER JOIN KULLANICI ON SEVK.DOKTOR_KOD = KULLANICI.K_KODU
    INNER JOIN POLIKLINIK ON SEVK.POLIKLINIK_ID = POLIKLINIK.POLIKLINIK_ID 
    Where sevk.DOSYA_NO =@HASTA_DOSYA_NO
    AND sevk.SEVK_TARİHİ =@HASTA_TARIH
    AND sevk.TABURCU = @DURUM
end
GO
/****** Object:  StoredProcedure [dbo].[PoliklinikEkle]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PoliklinikEkle](

    @POLIKLINIK_ID INT,
    @POLIKLINIK_AD NVARCHAR(25),
    @DURUM NVARCHAR(30),
    @ACIKLAMA NVARCHAR(255)

)
AS
BEGIN
    INSERT INTO POLIKLINIK(POLIKLINIK_AD,DURUM,ACIKLAMA) VALUES (@POLIKLINIK_AD,@DURUM,@ACIKLAMA)
END
GO
/****** Object:  StoredProcedure [dbo].[PoliklinikGetir]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PoliklinikGetir](

    @POLIKLINIK_AD NVARCHAR(25)
)
AS
BEGIN
    SELECT * FROM POLIKLINIK
    WHERE (@POLIKLINIK_AD IS NULL OR POLIKLINIK_AD=@POLIKLINIK_AD)
END
GO
/****** Object:  StoredProcedure [dbo].[PoliklinikGetirAktif]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PoliklinikGetirAktif](

    @POLIKLINIK_AD NVARCHAR(25)
)
AS
BEGIN
    SELECT * FROM POLIKLINIK
    WHERE DURUM = 'AKTİF'
END
GO
/****** Object:  StoredProcedure [dbo].[PoliklinikGuncelle]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PoliklinikGuncelle](

    @POLIKLINIK_ADESKI NVARCHAR(30),
    @POLIKLINIK_AD NVARCHAR(30),
    @DURUM NVARCHAR(30),
    @ACIKLAMA NVARCHAR(255)

)
AS
BEGIN
    UPDATE POLIKLINIK 
    SET POLIKLINIK_AD=@POLIKLINIK_AD,DURUM=@DURUM,ACIKLAMA=@ACIKLAMA
    WHERE POLIKLINIK_AD = @POLIKLINIK_ADESKI
END
GO
/****** Object:  StoredProcedure [dbo].[PoliklinikSil]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PoliklinikSil](
    @POLIKLINIK_AD NVARCHAR(30)
)
AS
BEGIN
    DELETE FROM POLIKLINIK WHERE POLIKLINIK_AD = @POLIKLINIK_AD
END
GO
/****** Object:  StoredProcedure [dbo].[PoliklinikSiraArttır]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PoliklinikSiraArttır](
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
GO
/****** Object:  StoredProcedure [dbo].[PoliklinikSiraGetir]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PoliklinikSiraGetir](
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
GO
/****** Object:  StoredProcedure [dbo].[PoliklinikSiraYaz]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PoliklinikSiraYaz](
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
GO
/****** Object:  StoredProcedure [dbo].[Sayi]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Sayi] 
AS
BEGIN
    SELECT COUNT(*) from KULLANICI
END
GO
/****** Object:  StoredProcedure [dbo].[SevkCikisGuncelle]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SevkCikisGuncelle](
    @DURUM NVARCHAR(5),
    @DOSYA_NO NVARCHAR(5),
    @SEVK_TARIH DATE
)
AS
BEGIN
    UPDATE SEVK SET TABURCU=@DURUM WHERE DOSYA_NO=@DOSYA_NO AND SEVK_TARİHİ =@SEVK_TARIH 
END
GO
/****** Object:  StoredProcedure [dbo].[SevkEkle]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SevkEkle](
    @POLIKLINIK_ADI NVARCHAR(30),
    @SIRA INT,
    @YAPILAN_ISLEM NVARCHAR(50),
    @DOSYA_NO NVARCHAR(5),
    @DOKTOR_AD NVARCHAR(50),
    @DOKTOR_SOYAD NVARCHAR(50),
    @MIKTAR CHAR(3),
    @BIRIM_FIYAT NVARCHAR(20),
    @TOPLAM_TUTAR NVARCHAR(20),
    @TABURCU NVARCHAR(6),
    @SEVK_TARIH DATE,
    @SAAT TIME

)
AS
BEGIN
    INSERT INTO SEVK (SEVK_TARİHİ,DOSYA_NO,POLIKLINIK_ID,SAAT,YAPILAN_ISLEM,DOKTOR_KOD,
    MIKTAR,BIRIM_FIYAT,SIRA,TOPLAM_TUTAR,TABURCU)

    SELECT @SEVK_TARIH,@DOSYA_NO,POLIKLINIK.POLIKLINIK_ID,@SAAT,@YAPILAN_ISLEM,KULLANICI.K_KODU,
    @MIKTAR,@BIRIM_FIYAT,@SIRA,@TOPLAM_TUTAR,@TABURCU
    FROM POLIKLINIK,KULLANICI WHERE POLIKLINIK.POLIKLINIK_AD =@POLIKLINIK_ADI AND KULLANICI.AD =@DOKTOR_AD
    AND KULLANICI.SOYAD =@DOKTOR_SOYAD
   
END
GO
/****** Object:  StoredProcedure [dbo].[SevkGetir]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SevkGetir](

    @POLIKLINIK_ADI NVARCHAR(30),
    @SIRA INT,
    @YAPILAN_ISLEM NVARCHAR(50),
    @DOSYA_NO NVARCHAR(5),
    @DOKTOR_AD_SOYAD NVARCHAR(50),
    @MIKTAR CHAR(3),
    @BIRIM_FIYAT NVARCHAR(20),
    @TOPLAM_TUTAR NVARCHAR(20),
    @TABURCU NVARCHAR(6),
    @SEVK_TARIH DATE,
    @SAAT TIME

)
AS
BEGIN
    SELECT POLIKLINIK.POLIKLINIK_AD,SEVK.SEVK_TARİHİ,SEVK.DOSYA_NO,SEVK.SAAT,SEVK.YAPILAN_ISLEM,SEVK.DOKTOR_AD_SOYAD,
    SEVK.MIKTAR,SEVK.BIRIM_FIYAT,SEVK.SIRA,SEVK.TOPLAM_TUTAR,SEVK.TABURCU FROM POLIKLINIK INNER JOIN SEVK ON POLIKLINIK.POLIKLINIK_ID = SEVK.POLIKLINIK_ID 
end
GO
/****** Object:  StoredProcedure [dbo].[SevkSil]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SevkSil](
    @SEVK_ID INT

)
AS
BEGIN
    DELETE FROM SEVK WHERE SEVK_ID =@SEVK_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[TCAra]    Script Date: 3.01.2020 06:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[TCAra](

    @TC NVARCHAR(11)
    
)
AS
BEGIN
    SELECT * FROM HASTA WHERE  HASTA.TCKIMLIK_NO LIKE '%'+@TC +'%' 
END
GO
