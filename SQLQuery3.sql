Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

Select * from Customers where City = 'Berlin'

select * from Products where CategoryId=1 or CategoryId=3 --1 numaralı kategoriye ait ürünleri getir

select * from Products where CategoryId = 1 and UnitPrice>=10

select * from Products order by ProductName -- bütün ürünleri seç ProductName e göre sırala

select * from Products order by UnitPrice asc --bütün ürünleri UnitPrice a göre sırala

select * from Products order by UnitPrice desc --descending azalan  asc ascending artan

select * from Products where categoryId= 1 order by UnitPrice desc

select COUNT(*) Adet from Products where CategoryID=2  -- tüm satırların sayısı product tablosunda kaç satır var

select CategoryID,COUNT(*) from Products where 
UnitPrice>20 group by CategoryID having COUNT (*) <10 --içerisinde 10 taneden az ürün çeşidi olanları getir


select  Products.ProductID, Products.ProductName,Products.UnitPrice,Categories.CategoryName
from Products inner join Categories
on Products.CategoryID= Categories.CategoryID
where Products.UnitPrice>10

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID


select * from Customers c left join Orders o --bir inner yaptık bir left
on c.CustomerID=o.CustomerID
where o.CustomerID is null







