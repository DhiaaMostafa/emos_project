USE [estate_database]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[Get_build_info]
		@Id = 1

SELECT	'Return Value' = @return_value

GO
