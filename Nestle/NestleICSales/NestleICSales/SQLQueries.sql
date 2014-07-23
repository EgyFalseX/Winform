--vProductWithNoActiveCase

SELECT ProductBaseId, ProductBase,
(SELECT COUNT(*) FROM Product WHERE ProductBaseId = ProductBase.ProductBaseId) AS Counting
 FROM ProductBase
 where (SELECT COUNT(*) FROM Product WHERE ProductBaseId = ProductBase.ProductBaseId and ActiveCase = 1) = 0
 
 SELECT * FROM Product WHERE
(SELECT COUNT(*) FROM Product AS TBL WHERE ProductBaseId = Product.ProductBaseId AND ActiveCase = 1) = 0
--______________________________________________________________________________________________________________
--update product take make 1 acitve product per baseproduct
update Product set ActiveCase = 1
where
Quantity = (select max(Quantity) from Product as tbl1 where ProductBaseId = Product.ProductBaseId) AND
(SELECT count(*) FROM Product as tbl2 where ProductBaseId = Product.ProductBaseId and ActiveCase = 1) = 0

select ProductBaseId, count(*) as counting, (select count(*) from product as tbl1 where ProductBaseId = Product.ProductBaseId and ActiveCase = 1) as activecount from Product 
group by ProductBaseId
--______________________________________________________________________________________________________________
--remove change log file to 10M
ALTER DATABASE Nestle SET RECOVERY SIMPLE WITH NO_WAIT
DBCC SHRINKFILE(Nestle_log, 10)
ALTER DATABASE Nestle SET RECOVERY FULL WITH NO_WAIT
GO  
-- change db mode from single user to multiuser
alter database Nestle set multi_user with rollback immediate