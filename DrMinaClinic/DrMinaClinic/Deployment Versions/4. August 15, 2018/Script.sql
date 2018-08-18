use [DrMinaClinic]
go
create table [dbo].[ExaminationDetails]
(
	[Id] [int] identity(1,1) not null,
	[ExaminationId] [int] not null,
	[Living] [bit] not null,
	[AF] [nvarchar](max) null,
	[Sex] [bit] not null,
	[Placenta] [nvarchar](max) null,
	[Weight] [float] null,
	[Presentation] [nvarchar](max) null,
	[Other] [nvarchar](max) null,
	constraint [PK_ExaminationDetails] primary key clustered 
	(
		[Id] asc
	)with (pad_index = off, statistics_norecompute = off, ignore_dup_key = off, allow_row_locks = on, allow_page_locks = on) on [PRIMARY]
) on [PRIMARY] textimage_on [PRIMARY]
go
alter table [dbo].[ExaminationDetails] with check add  constraint [FK_ExaminationDetails_Examinations] foreign key([ExaminationId])
references [dbo].[Examinations] ([Id])
go
alter table [dbo].[ExaminationDetails] check constraint [FK_ExaminationDetails_Examinations]
go
/*******************************************************************************************/
declare @pregnancyId int
declare @living bit
declare @af nvarchar(max)
declare @sex bit
declare @placenta nvarchar(max)
declare @weight float
declare @presentation nvarchar(max)
declare @other nvarchar(max)
declare @examinationId int

declare DetailsCursor cursor
for select PregnancyId, Living, AF, Sex, Placenta, Weight, Presentation, Other from PregnancyDetails
open DetailsCursor
fetch next from DetailsCursor into @pregnancyId, @living, @af, @sex, @placenta, @weight, @presentation, @other
while @@fetch_status = 0
begin
	set @examinationId = (select min(Id) from Examinations where PregnancyId = @pregnancyId)
	if @examinationId is not null
		insert into ExaminationDetails values (@examinationId, @living, @af, @sex, @placenta, @weight, @presentation, @other)
	fetch next from DetailsCursor into @pregnancyId, @living, @af, @sex, @placenta, @weight, @presentation, @other
end
close DetailsCursor
deallocate DetailsCursor
go
/*******************************************************************************************/
drop table PregnancyDetails
go
/*******************************************************************************************/
alter table Pregnancies add MalesCount int null, FemalesCount int null, LivingCount int null, DeadCount int NULL
go