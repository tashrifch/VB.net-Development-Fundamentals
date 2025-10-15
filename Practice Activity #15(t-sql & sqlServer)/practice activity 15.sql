SELECT object_id AS ObjectID, name AS ObjectName, column_id AS ColumnID
FROM sys.columns
Where column_id = 1

SELECT object_id AS ObjectID, name AS ObjectName, column_id AS ColumnID
FROM sys.columns
Where column_id >= 10

SELECT object_id AS ObjectID, name AS ObjectName, column_id AS ColumnID
FROM sys.columns
Where  [name] like 'n%'


select object_id as ObjectID , count(*) as NumberOfRows
from sys.columns
group by object_id

