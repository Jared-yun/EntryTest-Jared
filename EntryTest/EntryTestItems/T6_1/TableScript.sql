  if exists (select * from dbo.sysobjects where id = object_id(N'[Staff]') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table [Staff]
  create table [Staff] (
       Id INT IDENTITY NOT NULL,
       Salary DECIMAL(19,5) null,
       Name NVARCHAR(255) null,
       SocialNumber NVARCHAR(255) null,
       Company NVARCHAR(255) null,
       primary key (Id)
    )