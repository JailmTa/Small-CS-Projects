create procedure SP_ADDFINALLTEST(@Cul1 int output , @Cul2 int , @Cul3 int  ) as begin insert into FinallTest(Cul2 , Cul3  ) values (@Cul2 , @Cul3  ); set @Cul1= Scope_Identity(); end ;


create procedure SP_DELETEFINALLTEST(@Cul1 int)  as begin delete from FinallTest where @Cul1=Cul1 end ;


create procedure SP_UPDATEFINALLTEST(@Cul1 int , @Cul2 int , @Cul3 int   ) as begin update FinallTest set @Cul2=Cul2 , @Cul3=Cul3   where @Cul1=Cul1 end ;


create procedure SP_FINDFINALLTEST(@Cul1 int) as begin select * from FinallTest where @Cul1=Cul1 end ;


create function dbo.GETALLFINALLTEST() returns table as return(select * from FinallTest);


