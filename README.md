# Car-Shop-Website
 
things to do to check:

change servername from DESKTOP-OJ4FU91\\VICTORSERVER to youre local mssql server name ,in appsettings.json

to create the DB: go to tools in VS studio>nuget package manager>package manager console>write: "Update-Database"

to add the cars and user to the database execute the next query:

Cars:
INSERT INTO Cars (Name, Category, Price, UnitsInStock, ModelYear, ImageSrc)
VALUES ('Toyota Camry', 'Family', 25000.00, 10, 2022,'Car-1.jpg');

INSERT INTO Cars (Name, Category, Price, UnitsInStock, ModelYear, ImageSrc)
VALUES ('Honda Civic', 'Mini', 22000.00, 5, 2022, 'Car-2.jpg');

INSERT INTO Cars (Name, Category, Price, UnitsInStock, ModelYear, ImageSrc)
VALUES ('Ford F-150', 'Truck', 35000.00, 15, 2022, 'Car-3.jpg');

INSERT INTO Cars (Name, Category, Price, UnitsInStock, ModelYear, ImageSrc)
VALUES ('Tesla Model S', 'Luxury', 80000.00, 2, 2022 ,'Car-4.jpg');

INSERT INTO Cars (Name, Category, Price, UnitsInStock, ModelYear, ImageSrc)
VALUES ('Chevrolet Corvette', 'Sports', 65000.00, 3, 2022 ,'Car-5.jpg');

INSERT INTO Cars (Name, Category, Price, UnitsInStock, ModelYear, ImageSrc)
VALUES ('Jeep Wrangler', 'SUV', 30000.00, 8, 2022 ,'Car-6.jpg');

INSERT INTO Cars (Name, Category, Price, UnitsInStock, ModelYear, ImageSrc)
VALUES ('Audi A4', 'Luxury', 45000.00, 4, 2022 ,'Car-7.jpg');

INSERT INTO Cars (Name, Category, Price, UnitsInStock, ModelYear, ImageSrc)
VALUES ('BMW X5', 'SUV', 55000.00, 6, 2022 ,'Car-8.jpg');

INSERT INTO Cars (Name, Category, Price, UnitsInStock, ModelYear, ImageSrc)
VALUES ('Mercedes-Benz S-Class', 'Luxury', 90000.00, 1, 2022 ,'Car-9.jpg');

INSERT INTO Cars (Name, Category, Price, UnitsInStock, ModelYear, ImageSrc)
VALUES ('Lamborghini Huracan', 'Sports', 300000.00, 1, 2022 ,'Car-10.jpg');

Users:

INSERT INTO Users (Name, Password, LastLogin)
VALUES ('Shlomi Mendel', 'HappyDuckFeet300', '2022-01-01 12:00:00');

INSERT INTO Users (Name, Password, LastLogin)
VALUES ('Victor Rutskin', 'BigBruhMomentPerformer', '2022-01-03 18:30:00');



change environment angular variables to your local api blah blah


upload button code taken from:https://code-maze.com/upload-files-dot-net-core-angular/


safe resource copied code
