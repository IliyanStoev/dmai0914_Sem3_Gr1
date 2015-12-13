USE HomeworkOnP
GO

SET IDENTITY_INSERT [dbo].[Person] ON
INSERT INTO [dbo].[Person] ([pid], [userName], [name], [phone], [email], [password], [userType], [subject], [grade]) VALUES (1, N'anna', N'Anabella Smith', N'12345678', N'anas@gmail.com', N'edee29f882543b956620b26d0ee0e7e950399b1c4222f5de05e06425b4c995e9', 1, N'English', NULL)
INSERT INTO [dbo].[Person] ([pid], [userName], [name], [phone], [email], [password], [userType], [subject], [grade]) VALUES (2, N'george', N'George Larsen', N'87654321', N'georgel@gmail.com', N'edee29f882543b956620b26d0ee0e7e950399b1c4222f5de05e06425b4c995e9', 2, NULL, N'A3')
INSERT INTO [dbo].[Person] ([pid], [userName], [name], [phone], [email], [password], [userType], [subject], [grade]) VALUES (3, N'ralph', N'Ralph Ingversen', N'12345678', N'ralphi@gmail.com', N'edee29f882543b956620b26d0ee0e7e950399b1c4222f5de05e06425b4c995e9', 1, N'Math', NULL)
INSERT INTO [dbo].[Person] ([pid], [userName], [name], [phone], [email], [password], [userType], [subject], [grade]) VALUES (4, N'stephan', N'Stephan Stark', N'12345678', N'stephans@gmail.com', N'edee29f882543b956620b26d0ee0e7e950399b1c4222f5de05e06425b4c995e9', 1, N'Literature', NULL)
INSERT INTO [dbo].[Person] ([pid], [userName], [name], [phone], [email], [password], [userType], [subject], [grade]) VALUES (5, N'sara', N'Sara Simons', N'12345678', N'saras@gmail.com', N'edee29f882543b956620b26d0ee0e7e950399b1c4222f5de05e06425b4c995e9', 1, N'English', NULL)
INSERT INTO [dbo].[Person] ([pid], [userName], [name], [phone], [email], [password], [userType], [subject], [grade]) VALUES (6, N'linda', N'Linda Claus', N'12345678', N'lindac@gmail.com', N'edee29f882543b956620b26d0ee0e7e950399b1c4222f5de05e06425b4c995e9', 1, N'Math', NULL)
INSERT INTO [dbo].[Person] ([pid], [userName], [name], [phone], [email], [password], [userType], [subject], [grade]) VALUES (7, N'kail', N'Kail Rasmus', N'12345678', N'kailr@gmail.com', N'edee29f882543b956620b26d0ee0e7e950399b1c4222f5de05e06425b4c995e9', 1, N'Literature', NULL)
INSERT INTO [dbo].[Person] ([pid], [userName], [name], [phone], [email], [password], [userType], [subject], [grade]) VALUES (8, N'tim', N'Tim Travis', N'87654321', N'timij@gmail.com', N'edee29f882543b956620b26d0ee0e7e950399b1c4222f5de05e06425b4c995e9', 2, NULL, N'B3')
SET IDENTITY_INSERT [dbo].[Person] OFF

SET IDENTITY_INSERT [dbo].[TutoringTime] ON
INSERT INTO [dbo].[TutoringTime] ([tid], [date], [childId], [teacherId], [time]) VALUES (1, N'2015-12-23 00:00:00', NULL, 1, N'10:00')
INSERT INTO [dbo].[TutoringTime] ([tid], [date], [childId], [teacherId], [time]) VALUES (2, N'2015-12-24 00:00:00', NULL, 3, N'12:00')
INSERT INTO [dbo].[TutoringTime] ([tid], [date], [childId], [teacherId], [time]) VALUES (3, N'2016-01-02 00:00:00', NULL, 4, N'14:00')
INSERT INTO [dbo].[TutoringTime] ([tid], [date], [childId], [teacherId], [time]) VALUES (4, N'2016-01-14 00:00:00', NULL, 5, N'16:00')
INSERT INTO [dbo].[TutoringTime] ([tid], [date], [childId], [teacherId], [time]) VALUES (5, N'2016-01-14 00:00:00', NULL, 1, N'10:00')
INSERT INTO [dbo].[TutoringTime] ([tid], [date], [childId], [teacherId], [time]) VALUES (6, N'2016-01-14 00:00:00', NULL, 3, N'12:00')
INSERT INTO [dbo].[TutoringTime] ([tid], [date], [childId], [teacherId], [time]) VALUES (7, N'2016-01-15 00:00:00', NULL, 4, N'14:00')
INSERT INTO [dbo].[TutoringTime] ([tid], [date], [childId], [teacherId], [time]) VALUES (8, N'2016-01-15 00:00:00', NULL, 5, N'16:00')
INSERT INTO [dbo].[TutoringTime] ([tid], [date], [childId], [teacherId], [time]) VALUES (9, N'2016-01-16 00:00:00', NULL, 1, N'10:00')
INSERT INTO [dbo].[TutoringTime] ([tid], [date], [childId], [teacherId], [time]) VALUES (10, N'2016-01-17 00:00:00', NULL, 3, N'12:00')
INSERT INTO [dbo].[TutoringTime] ([tid], [date], [childId], [teacherId], [time]) VALUES (11, N'2016-01-18 00:00:00', NULL, 4, N'14:00')
INSERT INTO [dbo].[TutoringTime] ([tid], [date], [childId], [teacherId], [time]) VALUES (12, N'2016-01-19 00:00:00', NULL, 5, N'16:00')
SET IDENTITY_INSERT [dbo].[TutoringTime] OFF


SET IDENTITY_INSERT [dbo].[Assignment] ON
INSERT INTO [dbo].[Assignment] ([aid], [subject], [title], [exercise], [date], [deadLine], [pid]) VALUES (1, N'Math', N'Addition learning', N'What is 1+2=?', N'2015-12-12', N'2015-12-13', 3)
INSERT INTO [dbo].[Assignment] ([aid], [subject], [title], [exercise], [date], [deadLine], [pid]) VALUES (2, N'Literature', N'Book conspect', N'Who was your favorite character in the book?', N'2015-12-12', N'2015-12-13', 4)
INSERT INTO [dbo].[Assignment] ([aid], [subject], [title], [exercise], [date], [deadLine], [pid]) VALUES (3, N'English', N'Write 20 sentences', N'Write 20 sentences about what you did in winter holidays.', N'2015-12-12', N'2015-12-13', 1)
INSERT INTO [dbo].[Assignment] ([aid], [subject], [title], [exercise], [date], [deadLine], [pid]) VALUES (4, N'English', N'Christmas', N'Write a small story about Christmas', N'2015-12-12', N'2015-12-13', 1)
SET IDENTITY_INSERT [dbo].[Assignment] OFF



SET IDENTITY_INSERT [dbo].[Homework] ON
INSERT INTO [dbo].[Homework] ([hid], [childId], [assignmentId], [date], [diskName]) VALUES (1, 2, 1, N'2015-12-12 00:00:00', N'C://Somewhere on the server')
INSERT INTO [dbo].[Homework] ([hid], [childId], [assignmentId], [date], [diskName]) VALUES (2, 2, 2, N'2015-12-12 00:00:00', N'D://Somewhere on the server')
INSERT INTO [dbo].[Homework] ([hid], [childId], [assignmentId], [date], [diskName]) VALUES (3, 2, 3, N'2015-12-12 00:00:00', N'F://Somewhere on the server')
INSERT INTO [dbo].[Homework] ([hid], [childId], [assignmentId], [date], [diskName]) VALUES (4, 8, 1, N'2015-12-13 00:00:00', N'D://Somewhere on the server')
INSERT INTO [dbo].[Homework] ([hid], [childId], [assignmentId], [date], [diskName]) VALUES (5, 8, 2, N'2015-12-13 00:00:00', N'F://Somewhere on the server')
INSERT INTO [dbo].[Homework] ([hid], [childId], [assignmentId], [date], [diskName]) VALUES (6, 8, 3, N'2015-12-13 00:00:00', N'C://Somewhere on the server')
INSERT INTO [dbo].[Homework] ([hid], [childId], [assignmentId], [date], [diskName]) VALUES (8, 2, 4, N'2015-12-12 00:00:00', N'C://Somewhere on the server')
INSERT INTO [dbo].[Homework] ([hid], [childId], [assignmentId], [date], [diskName]) VALUES (9, 8, 4, N'2015-12-13 00:00:00', N'D://Somewhere on the server')
SET IDENTITY_INSERT [dbo].[Homework] OFF
