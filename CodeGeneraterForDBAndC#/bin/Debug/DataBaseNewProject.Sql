create procedure SP_ADDNEWPROJECT(@Cul1 Typ1 output , @Cul2 Typ2 , @Cul3 Typ3  ) as begin insert into NewProject(Cul2 , Cul3  ) values (@Cul2 , @Cul3  ); set @Cul1= Scope_Identity(); end ;


create procedure SP_DELETENEWPROJECT(@Cul1 Typ1     )  as begin delete from NewProject where @Cul1=Cul1 end ;


create procedure SP_UPDATENEWPROJECT(@Cul1 Typ1 , @Cul2 Typ2 , @Cul3 Typ3   ) as begin update NewProject set @Cul2=Cul2 , @Cul3=Cul3   where @Cul1=Cul1 end ;


create procedure SP_FINDNEWPROJECT(@Cul1 Typ1 , @Cul2 Typ2 output , @Cul3 Typ3 output   ) as begin select @Cul2=Cul2 , @Cul3=Cul3   from NewProject where @Cul1=Cul1 end ;


create function dbo.GetAllNewProject() returns table as return(select * from NewProject);


