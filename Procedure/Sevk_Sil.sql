USE SaglikOcagi
GO
drop procedure if EXISTS SevkSil
GO

CREATE PROCEDURE SevkSil(
    @SEVK_ID INT

)
AS
BEGIN
    DELETE FROM SEVK WHERE SEVK_ID =@SEVK_ID
   
END