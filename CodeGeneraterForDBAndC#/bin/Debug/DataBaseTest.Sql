create procedure SP_ADDTEST(@TestID int output , @TestName nvarchar(100) , ) as begin insert into Test(TestName , ) values (@TestName , ); set @TestID= Scope_Identity(); end ;


create procedure SP_DELETETEST(@TestID int     )  as begin delete from Test where @TestID=TestID end ;


create procedure SP_UPDATETEST(@TestID int , @TestName nvarchar(100) , ) as begin update Test set @TestName=TestName ,  where @TestID=TestID end ;


create procedure SP_FINDTEST(@TestID int , @TestName nvarchar(100) output , ) as begin select @TestName=TestName ,  from Test where @TestID=TestID end ;


create function dbo.GetAllTest() returns table as return(select * from Test);


