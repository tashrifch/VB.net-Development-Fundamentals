SELECT object_ID AS ObjectID, COUNT(*) AS NumberOfRows
FROM sys.columns
GROUP BY object_ID


SELECT object_ID AS ObjectID, COUNT(*) AS NumberOfRows
FROM sys.columns
GROUP BY object_ID
having count(*)>=10


SELECT object_ID AS ObjectID, COUNT(*) AS NumberOfRows
FROM sys.columns
GROUP BY object_ID
having count(*)>=10
order by NumberOfRows desc, ObjectID


