select 11*12 as MyAnswer
select 11*12 as "My Answer"
select * from sys.columns

select OBJECT_ID as ObjectID, 
	name as ObjectName,
	column_id as ColumnID
	from sys.columns