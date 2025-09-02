CREATE DATABASE movie;
GO

USE movie;
GO

CREATE TABLE actor (
	act_id INT PRIMARY KEY,
	act_fname CHAR(20),
	act_lname CHAR(20),
	act_gender CHAR(1)
	);
GO

CREATE TABLE director (
	dir_id INT PRIMARY KEY,
	dir_fname CHAR(20),
	dir_lname CHAR(20)
	);
GO 


CREATE TABLE movie (
	mov_id INT PRIMARY KEY,
	mov_title CHAR(50),
	mov_year INT,
	mov_time INT,
	mov_lang CHAR(50),
	mov_dt_rel DATE,
	mov_rel_country CHAR(5)
	);
GO
CREATE TABLE movie_direction (
	dir_id INT,
	mov_id INT,
	PRIMARY KEY (dir_id, mov_id),
	FOREIGN KEY (dir_id) REFERENCES director(dir_id),
	FOREIGN KEY (mov_id) REFERENCES movie(mov_id)
	);
GO 

CREATE TABLE movie_cast (
	act_id INT ,
	mov_id INT,
	role CHAR(30),
	PRIMARY KEY(act_id, mov_id),
	FOREIGN KEY (act_id) REFERENCES actor(act_id),
	FOREIGN KEY (mov_id) REFERENCES movie(mov_id)
	)
GO

CREATE TABLE reviewer (
	rev_id INT PRIMARY KEY,
	rev_name CHAR(30)
	);
GO

CREATE TABLE genres(
	gen_id int PRIMARY KEY,
	gen_title char(20)
	);
GO

CREATE TABLE movie_genres (
	mov_id int ,
	gen_id int ,
	PRIMARY KEY(mov_id, gen_id),
	FOREIGN KEY (mov_id) REFERENCES movie(mov_id),
	FOREIGN KEY (gen_id) REFERENCES genres(gen_id)
	);
GO

CREATE TABLE rating (
	mov_id int,
	rev_id int,
	rev_stars int,
	num_o_ratings int,
	PRIMARY KEY (mov_id, rev_id),
	FOREIGN KEY (mov_id) REFERENCES movie(mov_id),
	FOREIGN KEY (rev_id) REFERENCES reviewer(rev_id)
	);
GO
