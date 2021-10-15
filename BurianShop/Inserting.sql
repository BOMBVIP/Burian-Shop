
insert into Users (Login,Password) values ('root','root')

insert into ShoppingCards (UserId) values (1)

insert into Categories (Name) values ('Fruits')

insert into Products (Name,Description,Discount,ProductImage,CategoryId,ShoppingCard_Id) 
values ('Banana','Made in USA',1.2,CONVERT(varbinary(max),'C:\Users\vadim_oyanwuw\Desktop\banana.jpg'),1,1)