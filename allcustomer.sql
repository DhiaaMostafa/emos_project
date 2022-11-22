USE [estate_database]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[all_customer]

SELECT	'Return Value' = @return_value

GO
