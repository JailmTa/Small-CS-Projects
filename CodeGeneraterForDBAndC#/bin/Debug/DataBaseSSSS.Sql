create procedure SP_ADDSSSS(@A a output , @a a , @a a  ) as begin insert into SSSS(a , a  ) values (@a , @a  ); set @A= Scope_Identity(); end ;


create procedure SP_DELETESSSS(@A a     )  as begin delete from SSSS where @A=A end ;


create procedure SP_UPDATESSSS(@A a , @a a , @a a   ) as begin update SSSS set @a=a , @a=a   where @A=A end ;


create procedure SP_FINDSSSS(@A a , @a a output , @a a output   ) as begin select @a=a , @a=a   from SSSS where @A=A end ;


create function dbo.GetAllSSSS() returns table as return(select * from SSSS);


