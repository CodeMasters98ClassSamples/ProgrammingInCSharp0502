/*CRUD*/
/*200 record*/
/*Search by like*/
/*Query with Pagination*/
/*Group by*/
/*Top 150*/
/*Distinc*/
/*Sort*/
/*CTE*/
/*Aggregate Function*/
/*SP in Sql server*/
/*Function VS SP*/
/*View*/
/*Join*/

/*Model Creation Base on your project*/

SELECT * FROM Student

INSERT INTO Student(FirstName, LastName,Phone,NationalCode, CreatedAt,IsDeleted, DeletedAt, Code)
VALUES('Parham','Darvishi','09129564205','0020000000',GETDATE(),0,null,'ASDfhasg427kjbdsa')

UPDATE Student SET NationalCode = '0020000001' WHERE Id = 1

DELETE Student where id = 2


/* Database Health check*/
/* Retry Management to connect DB*/
/* Connection time out*/


/* * as service */