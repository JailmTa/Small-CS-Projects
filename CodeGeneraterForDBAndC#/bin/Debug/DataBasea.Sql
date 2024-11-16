create procedure SP_ADDA(@a a output , @a a , @a a  ) as begin insert into a(a , a  ) values (@a , @a  ); set @a= Scope_Identity(); end ;


create procedure SP_DELETEA(@a a     )  as begin delete from a where @a=a end ;


create procedure SP_UPDATEA(@a a , @a a , @a a   ) as begin update a set @a=a , @a=a   where @a=a end ;


create procedure SP_FINDA(@a a , @a a output , @a a output   ) as begin select @a=a , @a=a   from a where @a=a end ;


create function dbo.GetAlla() returns table as return(select * from a);


