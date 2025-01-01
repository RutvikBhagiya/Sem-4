Create database CSE_4A_233
--Part – A
--1. Retrieve a unique genre of songs.
	Select Distinct Genre From Songs
--2. Find top 2 awlbums released before 2010.
	Select Top 2 Album_title From Albums Where Release_year<2010 
--3. Insert Data into the Songs Table. (1245, ‘Zaroor’, 2.55, ‘Feel good’, 1005)
	Insert Into Songs Values (1245,'Zaroor',2.55,'Feel good',1005) 
--4. Change the Genre of the song ‘Zaroor’ to ‘Happy’
	Update Songs Set Song_title='Happy' Where Song_title='Zaroor'
--5. Delete an Artist ‘Ed Sheeran’
	Delete From Artists Where Artist_name='Ed Sheeran'
--6. Add a New Column for Rating in Songs Table. [Ratings decimal(3,2)]
	Alter Table Songs Add Ratings decimal(3,2) 
--7. Retrieve songs whose title starts with 'S'.
	Select Song_title From Songs Where Song_title Like 'S%'
--8. Retrieve all songs whose title contains 'Everybody'.
	Select Song_title From Songs Where Song_title Like '%Everybody%'
--9. Display Artist Name in Uppercase.
	Select UPPER(Artist_name) From Artists
--10. Find the Square Root of the Duration of a Song ‘Good Luck’
	Select SQRT(Duration) From Songs Where Song_title='Good Luck'
--11. Find Current Date.
	Select GETDATE()
--12. Find the number of albums for each artist.
	Select Count(Album_id), Artist_name
	From Albums
	Inner Join Artists
	On Albums.Artist_id = Artists.Artist_id
	Group By Artist_name
--13. Retrieve the Album_id which has more than 5 songs in it.
	Select Albums.Album_id, Count(Song_title)
	From Albums
	Inner Join Songs
	On Albums.Album_id = Songs.Album_id
	Group By Albums.Album_id
	Having COUNT(Song_title)>5
--14. Retrieve all songs from the album 'Album1'. (using Subquery)
	Select Song_title From Songs Where Album_id=
	(Select Album_id From Albums Where Album_title='Album1')
--15. Retrieve all albums name from the artist ‘Aparshakti Khurana’ (using Subquery)
	Select Album_title From Albums Where Artist_id=
	(Select Artist_id From Artists Where Artist_name='Aparshakti Khurana')
--16. Retrieve all the song titles with its album title.
	Select Song_title,Album_title 
	From Albums 
	Inner Join Songs 
	On Albums.Album_id = Songs.Album_id
--17. Find all the songs which are released in 2020.
	Select Song_title,Release_year 
	From Albums 
	Inner Join Songs 
	On Albums.Album_id = Songs.Album_id 
	Where Release_year=2020
--18. Create a view called ‘Fav_Songs’ from the songs table having songs with song_id 101-105.
	Create View Fav_Songs 
	As
	Select Song_id,Song_title From Songs Where Song_id Between 101 And 105
--19. Update a song name to ‘Jannat’ of song having song_id 101 in Fav_Songs view.
	Update Fav_Songs Set  Song_title='Jannat' Where Song_id = 101
--20. Find all artists who have released an album in 2020.
	Select Song_title,Artist_id 
	From Albums 
	Inner Join Songs 
	On Albums.Album_id = Songs.Album_id
	Inner Join Artists
	On Artists.Artist_id = Songs.Artist_id
	Where Release_year = 2020
--21. Retrieve all songs by Shreya Ghoshal and order them by duration. 
	Select Song_title,Duration 
	From Albums 
	Inner Join Songs 
	On Albums.Album_id = Songs.Album_id
	Inner Join Artists
	On Artists.Artist_id = Artists.Artist_id
	Where Artist_name = 'Shreya Ghoshal'
	Group By Duration

--Part – B
--22. Retrieve all song titles by artists who have more than one album. 
	Select Distinct Songs.Song_title,Count(Albums.Album_id)
	From Songs
	Inner Join Albums
	On Albums.Album_id = Songs.Album_id
	Inner Join Artists
	On Artists.Artist_id = Artists.Artist_id
	Where Artists.Artist_id in(
		Select Artist_id From Albums
		Group By Artist_id
		Having Count(Album_id)>1
	)
	Group By Songs.Song_title
	
--23. Retrieve all albums along with the total number of songs.
	Select Albums.Album_title,COUNT(Songs.Song_id) 
	FROM Albums 
	Inner JOIN Songs 
	ON Albums.Album_id=Songs.Song_id
	GROUP BY Albums.Album_title;
--24. Retrieve all songs and release year and sort them by release year. 
	SELECT Songs.Song_title, Albums.Release_year
	FROM Songs
	Inner JOIN Albums 
	ON Songs.Album_id=Albums.Album_id
	ORDER BY Albums.Release_year
--25. Retrieve the total number of songs for each genre, showing genres that have more than 2 songs.
	SELECT g.name AS genre_name, COUNT(s.Song_id) AS total_songs
	FROM genres g
	JOIN Songss   ON g.id = s.genre_id
	GROUP BY g.name
	HAVING COUNT(s.Song_id) > 2;
--26. List all artists who have albums that contain more than 3 songs.
	SELECT Artists.Artist_name
	FROM Artists 
	JOIN Albums  ON Artists.Artist_id=Albums.Artist_id
	JOIN Songs ON Albums.Album_id=Songs.Album_id
	GROUP BY Artists.Artist_name
	HAVING COUNT(Songs.Song_id) > 3;
--Part – C
--27. Retrieve albums that have been released in the same year as 'Album4'
	SELECT a2.Album_title
	FROM Albums a1
	JOIN Albums a2 ON a1.Release_year = a2.Release_year
	WHERE a1.Album_title = 'Album4' AND a2.Album_title != 'Album4';
--28. Find the longest song in each genre
	SELECT g.name AS genre_name, Songs.Song_title, MAX(Songs.duration) AS longest_duration
	FROM genres g
	JOIN songs s ON g.id = s.genre_id
	GROUP BY g.name, s.title
	ORDER BY g.name, longest_duration DESC;
--29. Retrieve the titles of songs released in albums that contain the word 'Album' in the title.
	SELECT Songs.Song_title
	FROM Songs 
	JOIN Albums ON Songs.Album_id = Albums.Album_id
	WHERE Albums.Album_title LIKE '%Album%';
--30. Retrieve the total duration of songs by each artist where total duration exceeds 15 minutes.
	SELECT Artists.Artist_name , SUM(Songs.Duration)
	FROM Artists 
	JOIN Albums ON Artists.Artist_id=Albums.Artist_id
	JOIN Songs ON Albums.Album_id=Songs.Album_id
	GROUP BY Artists.Artist_name
	HAVING SUM(Songs.Duration) > 900;