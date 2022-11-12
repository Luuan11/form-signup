CREATE PROCEDURE PROC_UserRegistration
(
	@FirstName NVARCHAR(MAX),
	@LastName NVARCHAR(MAX),
	@Email NVARCHAR(MAX),
	@Cellphone NVARCHAR(11),
	@Password NVARCHAR(MAX),
	@IsActive BIT,

	@FullName NVARCHAR(MAX)
)
AS
BEGIN

	SET @FullName = @FirstName + @LastName;

	IF EXISTS (@FullName OR @Email)
	BEGIN
		
	END

	BEGIN TRAN
		INSERT INTO Registration (Name, Password, Email, PhoneNumber, IsActive) VALUES (@FullName, @Password, @Email, @Cellphone, @IsActive)


END