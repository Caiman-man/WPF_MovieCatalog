CREATE TABLE Actors
(
	[actor_id]		  [int]			  IDENTITY primary key,
	[name]			  [varchar] (60)  NULL,
	[age]			  [varchar] (3)   NULL,
	[birthdate]	      [datetime]	  NULL,
	[a_country]	      [varchar] (20)  NULL
)

CREATE TABLE Movies
(
	[movie_id]		  [int]			  IDENTITY primary key,
	[title]			  [varchar] (60)  NULL,
	[m_year]		  [varchar] (4)   NULL,
	[budget]	      [money]		  NULL,
	[m_country]	      [varchar] (20)  NULL,
	[description]	  [varchar] (200) NULL
)

CREATE TABLE ActorMovie
(
    [actor_id]	[int] REFERENCES actors(actor_id),
    [movie_id]	[int] REFERENCES movies(movie_id)


   CONSTRAINT UPKCL_taind PRIMARY KEY CLUSTERED([actor_id], [movie_id])
)

CREATE TABLE ActorMovie
(
    [actor_id]	[int],
    [movie_id]	[int]


   CONSTRAINT UPKCL_taind PRIMARY KEY CLUSTERED([actor_id], [movie_id])
)

select * from actors
select * from movies
select * from actormovie

delete from actors
where actor_id = 84

delete from movies
where movie_id = 58

insert into actormovie values(84, 58)

insert into actors(name, age, birthdate, a_country, photo)
values 
('Omniman', '999', 'January 1, 1900', 'Viltrum', 'Images\Actors\omniman.png')


insert into movies(title, m_year, budget, m_country, description, poster)
values 
('Invincible', '2021', $10, 'USA', 'superhero film', 'Images\Movies\invincible.jpg')




create function ShowAllActorsAndMovies()
return table
as
return
	select * from Actors where actor_id in
	(select actor_id from ActorMovie where movie_id in
	(select movie_id from Movies))
 
drop proc ShowAllActorsAndMovies

exec ShowAllActorsAndMovies'2021'



insert into actormovie values(1, 1)
insert into actormovie values(1, 3)
insert into actormovie values(1, 6)
insert into actormovie values(1, 7)
insert into actormovie values(1, 9)
insert into actormovie values(1, 11)
insert into actormovie values(1, 13)
insert into actormovie values(1, 16)
insert into actormovie values(1, 19)
insert into actormovie values(1, 22)
insert into actormovie values(2, 2)
insert into actormovie values(3, 4)
insert into actormovie values(3, 6)
insert into actormovie values(3, 8)
insert into actormovie values(3, 9)
insert into actormovie values(3, 11)
insert into actormovie values(3, 17)
insert into actormovie values(3, 19)
insert into actormovie values(3, 22)
insert into actormovie values(4, 4)
insert into actormovie values(4, 6)
insert into actormovie values(4, 8)
insert into actormovie values(4, 11)
insert into actormovie values(4, 13)
insert into actormovie values(4, 17)
insert into actormovie values(4, 19)
insert into actormovie values(5, 5)
insert into actormovie values(5, 6)
insert into actormovie values(5, 9)
insert into actormovie values(5, 11)
insert into actormovie values(5, 13)
insert into actormovie values(5, 19)
insert into actormovie values(5, 22)
insert into actormovie values(6, 6)
insert into actormovie values(6, 11)
insert into actormovie values(6, 17)
insert into actormovie values(6, 19)
insert into actormovie values(6, 22)
insert into actormovie values(7, 6)
insert into actormovie values(7, 11)
insert into actormovie values(7, 13)
insert into actormovie values(7, 19)
insert into actormovie values(7, 22)
insert into actormovie values(8, 4)
insert into actormovie values(8, 6)
insert into actormovie values(8, 11)
insert into actormovie values(8, 13)
insert into actormovie values(8, 19)
insert into actormovie values(8, 22)
insert into actormovie values(9, 1)
insert into actormovie values(9, 6)
insert into actormovie values(9, 11)
insert into actormovie values(9, 13)
insert into actormovie values(9, 16)
insert into actormovie values(9, 19)
insert into actormovie values(9, 21)
insert into actormovie values(9, 22)
insert into actormovie values(9, 23)
insert into actormovie values(10, 9)
insert into actormovie values(10, 13)
insert into actormovie values(10, 19)
insert into actormovie values(10, 22)
insert into actormovie values(11, 9)
insert into actormovie values(11, 13)
insert into actormovie values(11, 19)
insert into actormovie values(11, 22)
insert into actormovie values(12, 10)
insert into actormovie values(12, 15)
insert into actormovie values(12, 19)
insert into actormovie values(12, 22)
insert into actormovie values(13, 10)
insert into actormovie values(13, 15)
insert into actormovie values(13, 19)
insert into actormovie values(13, 22)
insert into actormovie values(14, 10)
insert into actormovie values(14, 15)
insert into actormovie values(14, 19)
insert into actormovie values(14, 22)
insert into actormovie values(15, 10)
insert into actormovie values(15, 15)
insert into actormovie values(15, 19)
insert into actormovie values(15, 22)
insert into actormovie values(16, 10)
insert into actormovie values(16, 15)
insert into actormovie values(16, 19)
insert into actormovie values(16, 22)
insert into actormovie values(17, 11)
insert into actormovie values(17, 13)
insert into actormovie values(17, 19)
insert into actormovie values(17, 22)
insert into actormovie values(18, 12)
insert into actormovie values(18, 19)
insert into actormovie values(18, 20)
insert into actormovie values(18, 22)
insert into actormovie values(19, 12)
insert into actormovie values(19, 19)
insert into actormovie values(19, 20)
insert into actormovie values(19, 22)
insert into actormovie values(20, 13)
insert into actormovie values(20, 18)
insert into actormovie values(20, 19)
insert into actormovie values(20, 22)
insert into actormovie values(21, 14)
insert into actormovie values(21, 19)
insert into actormovie values(21, 22)
insert into actormovie values(22, 14)
insert into actormovie values(23, 13)
insert into actormovie values(23, 16)
insert into actormovie values(23, 19)
insert into actormovie values(23, 22)
insert into actormovie values(23, 23)
insert into actormovie values(24, 17)
insert into actormovie values(25, 17)
insert into actormovie values(26, 17)
insert into actormovie values(26, 19)
insert into actormovie values(26, 22)
insert into actormovie values(27, 4)
insert into actormovie values(27, 8)
insert into actormovie values(27, 17)
insert into actormovie values(28, 18)
insert into actormovie values(29, 19)
insert into actormovie values(29, 22)
insert into actormovie values(30, 21)
insert into actormovie values(30, 22)
insert into actormovie values(31, 21)
insert into actormovie values(32, 23)
insert into actormovie values(33, 25)
insert into actormovie values(34, 26)
insert into actormovie values(43, 26)