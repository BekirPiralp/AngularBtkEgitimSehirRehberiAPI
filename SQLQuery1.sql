use SehirRehberi;

Create table Users(
	Id int identity(1,1) not null,
	PasswordHash varbinary(max) null,
	PasswordSalt varbinary(max) null,
	UserName nvarchar(max) null
);

Create table Cities(
	Id int identity(1,1) not null,
	Description nvarchar(max) null,
	Name nvarchar(max) null,
	UserId int not null,
);

Create table Photos(
	Id int identity(1,1) not null,
	CityId int not null,
	DateAdded DateTime2(7) not null,
	Description nvarchar(max) null,
	IsMain bit not null,
	Url nvarchar(max) null,
	PublicId nvarchar(250) null
);