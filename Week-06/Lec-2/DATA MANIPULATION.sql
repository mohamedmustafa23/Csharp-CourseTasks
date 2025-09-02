--1.Create a new database named "CompanyDB."
CREATE DATABASE CompanyDB
GO

USE CompanyDB;
GO

--2.Create a schema named "Sales" within the "CompanyDB" database.
CREATE SCHEMA Sales;
GO

CREATE SEQUENCE Sales.em_seq
	START WITH 1
	INCREMENT BY 1;
GO

--3.Create a table named "employees" with columns: 
CREATE TABLE Sales.employees(
	employee_id INT PRIMARY KEY DEFAULT NEXT VALUE FOR Sales.em_seq,
	first_name VARCHAR(30),
	last_name VARCHAR(30),
	salary DECIMAL(8,2)
	);
GO

--4.Alter the "employees" table to add a new column named "hire_date" with the data type DATE.
ALTER TABLE Sales.employees
ADD hire_date DATE;
GO

--5.Add mock data to this table using Mockaroo.
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Sheffie', 'Norsister', 2692.46, '8/31/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Loria', 'Barbrook', 96691.21, '3/20/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Maurene', 'Culcheth', 98081.8, '11/13/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Melba', 'McCorley', 31436.89, '10/29/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Nita', 'Ecles', 21344.0, '11/28/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Malvina', 'Broadbear', 47342.37, '6/12/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Alanah', 'Maior', 35306.97, '12/7/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Roxane', 'Sprowell', 34955.69, '12/29/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Martha', 'Paschke', 56928.72, '5/9/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Henderson', 'Antao', 51185.55, '10/27/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Raleigh', 'Straun', 41327.42, '4/21/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Edy', 'Spinage', 1888.87, '3/10/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Gracie', 'Kighly', 47276.75, '6/1/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Hunter', 'Palk', 80547.96, '5/9/2030');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Ileana', 'Daunay', 41775.04, '6/2/2030');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Carmelia', 'Robbins', 36352.39, '10/21/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Terrel', 'Rablen', 73036.32, '11/16/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Charleen', 'Aaronsohn', 24798.98, '2/4/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Salomon', 'Sara', 90499.01, '8/26/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Jameson', 'Kunkel', 27565.51, '6/1/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Chicky', 'Assel', 12549.62, '8/20/2030');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Eleanor', 'Herche', 64901.68, '3/21/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Baudoin', 'Orrin', 82381.26, '1/14/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Annalise', 'Feely', 33827.72, '2/7/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Marshal', 'Drabble', 36660.74, '4/9/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Marianne', 'Klimek', 8914.02, '2/7/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Davy', 'Dyte', 84917.57, '3/13/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Rodolph', 'Boden', 80196.19, '4/15/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Mayer', 'Cock', 53024.14, '12/21/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Allsun', 'Bullar', 54877.95, '3/9/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Raeann', 'Gosson', 21405.25, '8/5/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Lenette', 'Dank', 9860.71, '8/8/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Stephani', 'Djordjevic', 58615.56, '5/11/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Kacie', 'Scarsbrick', 78852.65, '10/29/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Monah', 'Birdis', 94029.15, '2/6/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Reinald', 'Willox', 14810.83, '12/29/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Shandeigh', 'Vaudin', 31576.93, '10/10/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Vina', 'Rohmer', 14265.2, '10/8/2030');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Kaylee', 'Babe', 10902.73, '9/5/2030');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Cristi', 'Caldwall', 66781.15, '10/20/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Reggi', 'Ehlerding', 86108.53, '1/4/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Sol', 'Pawel', 86968.29, '8/15/2030');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Bruno', 'Izkoveski', 11096.54, '5/1/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Emili', 'Borel', 64693.84, '3/4/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Arturo', 'Cholonin', 75554.92, null);
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Bradney', 'Haxbie', 76489.09, '2/13/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Valentino', 'Bartalot', 49907.55, '6/21/2030');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Velma', 'Dolley', 58713.9, '10/1/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Ware', 'Ivy', 56467.82, '4/26/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Izzy', 'Baldoni', 47761.96, '8/20/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Constancia', 'Shayes', 73973.75, '11/16/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Worden', 'Pietrowski', 24513.44, null);
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Gregory', 'Oakly', 46372.81, '4/2/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Jeremias', 'Figg', 92245.78, '8/23/2030');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Sapphire', 'Landrean', 19691.46, '11/16/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Guido', 'Micco', 8040.42, '5/12/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Breena', 'Drysdell', 3420.41, '2/7/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Rudd', 'Tolfrey', 43233.71, null);
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Allayne', 'Madrell', 31186.28, '10/26/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Allison', 'Green', 87952.62, null);
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Nessie', 'Poon', 64277.08, '3/29/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Jose', 'Drayn', 92584.73, '5/16/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Constance', 'McAdam', 94519.28, '7/10/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Cleo', 'Pimm', 33834.52, '8/26/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Clareta', 'Froud', 42414.02, '12/4/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Kirsti', 'Secrett', 98716.28, '2/26/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Rafaello', 'Stabbins', 53857.69, '12/3/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Dani', 'Breward', 19060.75, '12/20/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Melli', 'Mossom', 34744.62, '2/12/2030');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Jarrid', 'Rowter', 63324.63, '8/3/2030');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Suellen', 'Cammiemile', 95594.72, '1/25/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Rici', 'Hargreaves', 26165.28, '6/15/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Tracey', 'Malter', 60948.2, '7/28/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Carmine', 'Thexton', 24549.7, '3/8/2030');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Ross', 'Talton', 98659.59, '9/18/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Jeff', 'Bruni', 12725.18, '9/13/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Agnesse', 'Presslie', 88605.4, '7/5/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Hogan', 'Mayho', 94429.22, '10/6/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Gale', 'Dowtry', 69590.86, '3/23/2030');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Coletta', 'Tibbs', 38453.33, '3/13/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Merrel', 'Kiera', 78158.98, '9/24/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Ebeneser', 'Hammant', 25271.27, '6/4/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Fancy', 'Lathy', 57438.64, '3/4/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Hatty', 'Magog', 64570.37, null);
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Myranda', 'Smartman', 5579.07, '3/10/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Kendell', 'Champney', 72748.05, '6/20/2030');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Dniren', 'Boissier', 19412.95, '1/12/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Vic', 'Grigs', 40968.41, '8/21/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Henka', 'Knifton', 66782.49, null);
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Wendie', 'Mallabon', 97854.9, '3/14/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Marlowe', 'Meric', 18114.43, '7/10/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Fonz', 'Kendrew', 60938.97, null);
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Wendy', 'Lett', 18725.74, '10/20/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Leonanie', 'Mc Cahey', 62825.6, '5/8/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Crichton', 'Reasce', 36530.28, '5/12/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Cornelia', 'Eaglesham', 42286.64, null);
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Eustacia', 'Melbert', 40907.06, '3/31/2030');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Olin', 'Reynault', 28265.89, null);
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Bernetta', 'McAnalley', 9955.31, '8/17/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Ive', 'Cropton', 45962.41, '8/4/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Joelie', 'Showt', 1333.44, '4/24/2030');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Tessy', 'Blenkinsop', 78591.04, '11/14/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Sollie', 'Totterdell', 86680.33, '2/20/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Bianca', 'Whitrod', 68210.32, '4/4/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Wilden', 'Bitterton', 37306.12, '6/2/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Gina', 'Denziloe', 8311.42, '9/11/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Jaquenetta', 'Ribbens', 27645.98, '6/3/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Aube', 'Duffyn', 23869.3, '4/22/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Dionis', 'Latty', 81723.13, '1/16/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Tammi', 'Beceril', 62432.93, '6/13/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Krispin', 'Smouten', 97181.85, '8/16/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Lemmy', 'Docker', 49688.03, '6/2/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Vinni', 'Shadrach', 2115.35, '6/4/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Shem', 'Sotworth', 59210.67, '8/29/2030');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Felicle', 'Eliyahu', 70360.13, '9/2/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Sybila', 'Tarver', 56174.19, '8/7/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Clayton', 'Omar', 38426.31, '8/31/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Alvan', 'Starrs', 19031.24, '2/18/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Kevon', 'Tieraney', 13297.95, '3/5/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Alberta', 'Ayto', 91357.23, '4/12/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Orton', 'Coysh', 97895.55, '2/13/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Ike', 'Alexandersen', 75693.82, '12/31/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Shandy', 'Van Haeften', 50801.4, '4/30/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Leupold', 'Tucsell', 59188.74, '5/19/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Agathe', 'Doerrling', 92761.32, '7/6/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Eddie', 'Fleisch', 75523.0, '9/18/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Leila', 'Izak', 581.89, null);
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Clem', 'Aldis', 7010.64, '5/19/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Lynnelle', 'Boothebie', 60918.49, '2/6/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Stafford', 'Churchman', 54440.24, '8/26/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Anne-corinne', 'McGinnell', 40684.08, '6/6/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Ambrosio', 'Cattanach', 65661.8, '4/5/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Elliot', 'Penfold', 94958.88, '1/8/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Kipp', 'Tinman', 9660.25, '8/31/2030');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Bernardina', 'Creagh', 70299.25, '5/1/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Johna', 'Coldwell', 99402.08, '3/23/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Iago', 'Baudouin', 59442.38, '1/27/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Pamela', 'Hartles', 55003.15, '8/4/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Elisabet', 'Lyfield', 44929.77, '6/12/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Lucia', 'Goodluck', 32784.09, '9/18/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Dominik', 'Cyster', 26313.83, '5/15/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Lazaro', 'Usborn', 52076.22, '7/2/2030');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Celine', 'Curreen', 68855.91, '3/10/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Rafaela', 'McKomb', 11323.74, '5/22/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Washington', 'Miche', 79472.58, '9/22/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Eliot', 'Yakolev', 55430.46, '7/18/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Alain', 'MacKeig', 17617.19, '10/1/2030');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Danyelle', 'Shallow', 83914.65, '3/12/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Arturo', 'Conville', 583.17, '1/23/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Son', 'Leathes', 3253.08, '9/8/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Jakie', 'Fullerd', 30871.26, '5/18/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Sue', 'Rait', 10275.5, '2/28/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Mary', 'Carrick', 37231.96, '7/4/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Paco', 'Walklett', 21132.81, '6/8/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Tanney', 'Blowick', 13197.75, '4/19/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Maggi', 'Scottesmoor', 24034.8, '1/23/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Maryl', 'Jouhandeau', 94283.55, '6/19/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Blanche', 'Szepe', 79511.72, '9/16/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Dalia', 'Halladey', 29046.76, '10/29/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Loni', 'Wenger', 52142.88, '11/18/2030');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Philip', 'MacMillan', 27186.53, '8/26/2030');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Nana', 'Grute', 77921.17, '12/20/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Clair', 'Farreil', 11706.6, '4/6/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Elmira', 'Batchelour', 15244.35, '10/9/2030');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Christie', 'Bridge', 16973.09, '7/11/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Donaugh', 'Malcher', 79669.69, '1/31/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Zabrina', 'Melley', 13875.39, '10/27/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Chick', 'Pococke', 82505.32, '6/21/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Paddy', 'Kruschov', 49972.06, '11/28/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Tamera', 'Burnsides', 6161.82, null);
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Zonda', 'Rourke', 55648.05, '5/24/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Gerick', 'Casbolt', 17050.62, null);
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Pieter', 'Gilkison', 36780.14, '9/18/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Kathryne', 'Hartness', 59087.02, '11/28/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Correy', 'MacCrossan', 94800.52, '7/25/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Zachary', 'Adlington', 7260.88, '7/21/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Reyna', 'Shade', 60230.08, '7/15/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Worden', 'Palke', 42348.18, '5/22/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Maryanne', 'Jeaycock', 26841.14, '9/28/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Valery', 'Yurasov', 83261.37, '6/30/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Linea', 'Melley', 78843.16, '8/20/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Jewell', 'Stanbrooke', 13126.65, '11/24/2030');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Allister', 'Paskerful', 46809.31, '1/20/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Aurora', 'Phippen', 82165.32, '1/27/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Donnajean', 'Ormston', 93716.43, null);
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Costa', 'Callard', 41303.27, '8/15/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Valina', 'Palay', 8753.99, '10/24/2027');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Germain', 'Wynch', 18914.27, '7/4/2030');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Izaak', 'McKmurrie', 1937.82, '7/1/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Clarine', 'Van Ross', 46743.27, '10/6/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Wadsworth', 'Philpots', 9939.91, null);
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Algernon', 'Dybell', 14000.17, '1/4/2025');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Fallon', 'Lewer', 59950.53, '3/30/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Neddy', 'Fatscher', 27075.11, '6/26/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Evangeline', 'Petrushka', 34751.66, '11/3/2028');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Angelika', 'Hyatt', 64303.86, '6/30/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Kenny', 'Donson', 19561.91, '7/25/2026');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Devi', 'Oake', 41816.6, '6/11/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Joeann', 'Stanluck', 97752.73, '1/28/2029');
insert into Sales.employees (first_name, last_name, salary, hire_date) values ('Arabelle', 'Cressor', 90649.62, '3/20/2030');

--DATA MANIPULATION Exercises:

--1.Select all columns from the "employees" table.
SELECT *
FROM Sales.employees;

--2.Retrieve only the "first_name" and "last_name" columns from the "employees" table.
SELECT first_name , last_name 
FROM Sales.employees

--3.Retrieve "full name" as a one column from "first_name" and "last_name" columns from the "employees" table.
SELECT first_name +' '+ last_name "Full Name"
FROM Sales.employees

--4.Show the average salary of all employees. (Use AVG() function)
SELECT AVG(salary) AS average_salary
FROM Sales.employees;

--5.Select employees whose salary is greater than 50000.
SELECT *
FROM Sales.employees
WHERE salary > 50000;

--6.Retrieve employees hired in the year 2020.
SELECT *
FROM Sales.employees
WHERE YEAR(hire_date) = 2025;

--7.List employees whose last names start with 'S'.
SELECT *
FROM Sales.employees
where last_name LIKE 'S%';

--8.Display the top 10 highest-paid employees.
SELECT TOP 10 *
FROM Sales.employees
ORDER BY salary DESC;

--9.Find employees with salaries between 40000 and 60000.
SELECT *
FROM Sales.employees
WHERE salary BETWEEN 4000 AND 6000;

--10.Show employees with names containing the substring 'man'.
SELECT *
FROM Sales.employees
WHERE first_name LIKE '%man%'

--11.Display employees with a NULL value in the "hire_date" column.
SELECT *
FROM Sales.employees
WHERE hire_date is NULL;

--12.Select employees with a salary in the set (40000, 45000, 50000).
SELECT*
FROM Sales.employees
WHERE salary IN(40000, 45000, 50000);

--13.Retrieve employees hired between '2020-01-01' and '2021-01-01'.
SELECT *
FROM Sales.employees
WHERE hire_date BETWEEN '2020-01-01' AND '2021-01-01';

--14.List employees with salaries in descending order.
SELECT *
FROM Sales.employees
ORDER BY salary desc;

--15.Show the first 5 employees ordered by "last_name" in ascending order.
SELECT TOP 5 *
FROM Sales.employees
ORDER BY last_name asc;

--16.Display employees with a salary greater than 55000 and hired in 2020.
SELECT *
FROM Sales.employees
WHERE salary > 55000 AND YEAR(hire_date) = 2020;

--17.Select employees whose first name is 'John' or 'Jane'.
SELECT*
FROM Sales.employees
WHERE first_name = 'john' OR last_name = 'jana';

--18.List employees with a salary = 55000 and a hire date after '2022-01-01'.
SELECT *
FROM Sales.employees
WHERE salary <= 55000 AND hire_date > '2022-01-01';

--19.Retrieve employees with a salary greater than the average salary.
SELECT *
FROM Sales.employees
WHERE salary > 
(SELECT AVG(salary)
 FROM Sales.employees);

 --20.Display the 3rd to 7th highest-paid employees. (Use OFFSET and FETCH)
 SELECT *
 FROM Sales.employees
 ORDER BY salary DESC
 OFFSET 2 ROWS    
 FETCH NEXT 5 ROWS ONLY;

 --21.List employees hired after '2021-01-01' in alphabetical order.
SELECT *
FROM Sales.employees
WHERE hire_date > '2021-01-01'
ORDER BY last_name ASC, first_name ASC;

--22.Retrieve employees with a salary > 50000 and last name not starting with 'A'.
SELECT *
FROM Sales.employees
WHERE salary > 50000 AND last_name NOT LIKE 'a%'

--23.Display employees with a salary that is not NULL.
SELECT *
FROM Sales.employees
WHERE salary IS NOT NULL;

--24.Show employees with names containing 'e' or 'i' and a salary > 45000.
SELECT *
FROM Sales.employees
WHERE (first_name LIKE '%i%' OR last_name LIKE '%i%'
OR first_name LIKE '%e%' OR last_name LIKE '%e%') AND salary > 45000 ;

--JOIN-RELATED EXERCISES

--25.Create a new table named "departments" with columns:
CREATE TABLE Sales.departments(
department_id INT primary KEY,
department_name VARCHAR(50),
manager_id INT,
CONSTRAINT FK_Manager FOREIGN KEY (manager_id) 
REFERENCES Sales.employees(employee_id)
);

--26.Assign each employee to a department by creating a "department_id" column in "employees" and making it a foreign key referencing "departments".department_id.
ALTER TABLE Sales.employees
ADD department_id INT;

ALTER TABLE Sales.employees
ADD CONSTRAINT FK_Department
FOREIGN KEY (department_id) REFERENCES Sales.departments(department_id);

--27.Retrieve all employees with their department names (Use INNER JOIN).
SELECT *
FROM Sales.employees SE
INNER JOIN Sales.departments SD
ON SE.department_id = SD.department_id;

--28.Retrieve employees who don’t belong to any department (Use LEFT JOIN and check for NULL).
SELECT *
FROM Sales.employees e
LEFT JOIN Sales.departments d 
ON e.department_id = d.department_id
WHERE d.department_id IS NULL;

--29.Show all departments and their employee count (Use JOIN and GROUP BY).
SELECT d.department_id, d.department_name, COUNT(e.employee_id) AS employee_count
FROM Sales.departments d
LEFT JOIN Sales.employees e
ON d.department_id = e.department_id
GROUP BY d.department_id, d.department_name;

--30.Retrieve the highest-paid employee in each department (Use JOIN and MAX(salary)).
SELECT d.department_name, MAX(e.salary) AS max_salary
FROM Sales.departments d
JOIN Sales.employees e 
ON d.department_id = e.department_id
GROUP BY d.department_name;


