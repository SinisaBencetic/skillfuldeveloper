create database SkillfulDeveloper

create table Tag(
Name nvarchar(100) not null 
constraint Tag_pk primary key clustered (Name)
)

create table Exam(
Id int identity not null
constraint Exam_pk primary key clustered (Id),
Question nvarchar(1000) not null,
Answer nvarchar(1000) not null
)

create table Exam_Tag_map(
Exam_Id int not null
constraint Exam_Tag_map_Exam_fk references Exam(Id),
Tag_Name nvarchar(100) not null
constraint Exam_Tag_map_Tag_fk references Tag(Name),
constraint Exam_Tag_map_pk primary key (Exam_Id,Tag_Name)
)