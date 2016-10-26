--find all company which have more than 100 staffs
SELECT Company,COUNT(*)
FROM [Staff]
GROUP BY Company HAVING COUNT(Id)>100;


--find how the table [Staff] created
SHOW CREATE TABLE [Staff];