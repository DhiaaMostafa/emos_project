USE [estate_database]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sp_login]
		@user_name = N'خليل',
		@user_pass = N'123'

SELECT	'Return Value' = @return_value

GO
