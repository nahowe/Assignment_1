DROP TABLE [PROJECTS1732].[dbo].[enroll];
DROP TABLE [PROJECTS1732].[dbo].[class];
DROP TABLE [PROJECTS1732].[dbo].[instructor];
DROP TABLE [PROJECTS1732].[dbo].[student];

CREATE TABLE [PROJECTS1732].[dbo].[student] (
	s_id SMALLINT PRIMARY KEY,
	s_fname CHAR(20),
	s_lname CHAR(30),
	s_major CHAR(5),
	s_gradelvl CHAR(2),
	s_age SMALLINT);

CREATE TABLE [PROJECTS1732].[dbo].[instructor] (
	i_id SMALLINT PRIMARY KEY,
	i_fname CHAR(20),
	i_lname CHAR(30));

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
	(s_id, s_fname, s_lname, s_major, s_gradelvl, s_age) VALUES
	(100, 'MIKE', 'JONES',	'ISYS',	'GR', 21),
	(150, 'DAN', 'PARKS', 'ACCT', 'SO', 19),
	(200, 'RON', 'BAKER', 'MGMT', 'GR', 50),
	(250, 'P.J.', 'GLASS', 'MKTT', 'SN', 18),
	(300, 'ALI', 'BAKER', 'ISYS', 'SN', 41),
	(350, 'WILLY', 'RUSSELL', 'MIS', 'JR', 20),
	(400, 'OLIVER', 'RYE',	'ACCT',	'FR', 18),
	(450, 'MICHELLE', 'JONES', 'HIST', 'SN', 24);

INSERT INTO [PROJECTS1732].[dbo].[instructor] 
	(i_id, i_fname, i_lname) VALUES
	(9423, 'RUSSELL', 'WILSON'),
	(9455, 'BRIAN', 'ADAMS'),
	(9456, 'ED', 'FRED'),
	(9563, 'MONICA', 'LAW'),
	(9622, 'ADAM', 'JONES'),
	(9678, 'PATRICIA', 'PURT'),
	(9777, 'LILLY', 'ODUM'),
	(9790, 'TED', 'SMITH'),
	(9792, 'TIM', 'LONG'),
	(9795, 'AMY', 'SMITH'),
	(9798, 'MARVIN', 'WOOD');

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

--Table(Entity) Select
select * from student;
select * from class;
select * from instructor;
select * from enroll;

--Student's Classes	
SELECT s.s_lname AS LastName, c.c_name AS ClassName
FROM student s
JOIN enroll e ON e.s_id = s.s_id
JOIN class c ON c.c_name = e.c_name;

--Instructor's Student's
SELECT i.i_lname AS InstructorLastName, s.s_fname AS StudentFirstName, s.s_lname AS StudentLastName
FROM student s
JOIN enroll e ON e.s_id = s.s_id
JOIN class c ON c.c_name = e.c_name
JOIN instructor i ON i.i_id = c.i_id;

--Class Roster
SELECT c.c_name AS ClassName, s.s_fname AS Student_FirstName, s.s_lname AS Student_LastName
FROM student s
JOIN enroll e ON e.s_id = s.s_id
JOIN class c ON c.c_name = e.c_name;

