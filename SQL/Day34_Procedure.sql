create procedure SqlAddressBookDetails
(
@FirstName varchar(255),
@LastNames varchar(255), 
@Address varchar(255), 
@City varchar(255),
@State varchar(255),
@Zip int, 
@PhoneNumber varchar(15),
@Email varchar(100)
)

as

begin

Insert into AddressBook_Day34 values(@FirstName,@LastNames,@Address,@City,@State,@Zip,@PhoneNumber,@Email);

end