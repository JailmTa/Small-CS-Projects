create procedure SP_ADDTEST2(@Cul1 int output , @Cul2 int , @Cul3 int  ) as begin insert into Test2(Cul2 , Cul3  ) values (@Cul2 , @Cul3  ); set @Cul1= Scope_Identity(); end ;


create procedure SP_DELETETEST2(@Cul1 int)  as begin delete from Test2 where @Cul1=Cul1 end ;


create procedure SP_UPDATETEST2(@Cul1 int , @Cul2 int , @Cul3 int   ) as begin update Test2 set @Cul2=Cul2 , @Cul3=Cul3   where @Cul1=Cul1 end ;


create procedure SP_FINDTEST2(@Cul1 int) as begin select * from Test2 where @Cul1=Cul1 end ;


create function dbo.GETALLTEST2() returns table as return(select * from Test2);


