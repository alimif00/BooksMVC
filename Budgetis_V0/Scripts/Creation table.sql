Create table Tache(
 ID int identity(1,1) primary key,
 description nvarchar(200),
 cout numeric(38,0) ,
 isFinished int)


 Create table CategorieDepense(
 ID int identity(1,1) primary key,
 libelle nvarchar(200))

 
 Create table Depense(
 ID int identity(1,1) primary key,
 libelle nvarchar(200),
 CategorieDepense int,
 cout numeric(38,0)
 --, TacheId int
 )

  

