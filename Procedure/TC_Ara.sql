use SaglikOcagi
GO

drop PROCEDURE IF EXISTS TCAra
GO

CREATE PROCEDURE TCAra(

    @TC NVARCHAR(11)
    
)
AS
BEGIN
    SELECT * FROM HASTA WHERE  HASTA.TCKIMLIK_NO LIKE '%'+@TC +'%' 
END