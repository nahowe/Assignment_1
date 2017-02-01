DROP TABLE [PROJECTS1732].[dbo].[enroll];
DROP TABLE [PROJECTS1732].[dbo].[class];
DROP TABLE [PROJECTS1732].[dbo].[instructor];
DROP TABLE [PROJECTS1732].[dbo].[student];

CREATE TABLE [PROJECTS1732].[dbo].[student] (
	s_id SMALLINT PRIMARY KEY,
	s_name CHAR(10),
	s_major CHAR(5),
	s_gradelvl CHAR(2),
	s_age SMALLINT);

CREATE TABLE [PROJECTS1732].[dbo].[instructor] (
	i_id SMALLINT PRIMARY KEY,
	i_name CHAR(10));

CREATE TABLE [PROJECTS1732].[dbo].[class] (
	c_name CHAR(8) PRIMARY KEY,
	c_time CHAR(5),
	c_room CHAR(5),
	i_id SMALLINT FOREIGN KEY REFERENCES [PROJECTS1732].[dbo].[instructor]);

CREATE TABLE [PROJECTS1732].[dbo].[enroll] (
	section_num SMALLINT,
	c_name  CHAR(8) FOREIGN KEY REFERENCES [PROJECTS1732].[dbo].[class],
	s_id SMALLINT FOREIGN KEY REFERENCES [PROJECTS1732].[dbo].[student]);


INSERT INTO [PROJECTS1732].[dbo].[student] 
	(s_id, s_name, s_major, s_gradelvl, s_age) VALUES
	(100, 'M. JONES',	'ISYS',	'GR', 21),
	(150, 'J. PARKS', 'ACCT', 'SO', 19),
	(200, 'R. BAKER', 'MGMT', 'GR', 50),
	(250, 'P.J. GLASS', 'MKTT', 'SN', 18),
	(300, 'A. BAKER', 'ISYS', 'SN', 41),
	(350, 'W. RUSSELL', 'MIS', 'JR', 20),
	(400, 'O. RYE',	'ACCT',	'FR', 18),
	(450, 'M. JONES', 'HIST', 'SN', 24);

INSERT INTO [PROJECTS1732].[dbo].[instructor] 
	(i_id, i_name) VALUES
	(9423, 'R. Wilson'),
	(9455, 'B. Adams'),
	(9456, 'E.E. Fred'),
	(9563, 'M. Law'),
	(9622, 'A. Jones'),
	(9678, 'P. Purt'),
	(9777, 'K. Odum'),
	(9790, 'T. Smith'),
	(9792, 'T. Long'),
	(9795, 'A. Smith'),
	(9798, 'M. Wood');

INSERT INTO [PROJECTS1732].[dbo].[class] 
	(c_name, c_time, c_room, i_id) VALUES
	('WCOB1023', 'M-F9', 'SC110', 9798),
	('ISYS4213', 'MWF3', 'SC213', 9563),
	('WCOB1003', 'MWF8', 'SC213', 9798),
	('ISYS2263', 'MWF3', 'EA304', 9792),
	('ISYS450V', 'MWF12', 'EB210', 9795);

INSERT INTO [PROJECTS1732].[dbo].[enroll] 
	(section_num, c_name, s_id) VALUES
	(1, 'ISYS4213', 100),		
	(1, 'WCOB1023', 150),		
	(2, 'ISYS4213', 200),		
	(1, 'ISYS450V', 200),			
	(1, 'ISYS2263', 300),			
	(2, 'WCOB1023', 400),		
	(1, 'WCOB1003', 400),	
	(2, 'ISYS450V', 400),
	(3, 'WCOB1023', 450);


SELECT e.section_num, c.c_name, s.s_id
FROM enroll e 
JOIN class c ON e.c_name = c.c_name
JOIN student s ON e.s_id = s.s_id;

select * from class;