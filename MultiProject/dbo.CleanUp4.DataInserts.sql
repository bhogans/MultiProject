SET IDENTITY_INSERT [dbo].[Buildings] ON
INSERT INTO [dbo].[Buildings] ([BuildingId], [Type], [Name], [Address1], [Address2], [City], [State], [Zipcode], [ClientId], [Latitude], [Longitude]) VALUES (2, N'Residential', N'Mick''s Apartment', N'3155 Aspen St NW', N'www', N'Washington', N'DC', N'20018', 6, NULL, NULL)
INSERT INTO [dbo].[Buildings] ([BuildingId], [Type], [Name], [Address1], [Address2], [City], [State], [Zipcode], [ClientId], [Latitude], [Longitude]) VALUES (3, N'Residential', N'Larry Lewis House', N'1414 Holly St NW', N'Apt 2.', N'Washington', N'DC', N'20011', 5, NULL, NULL)
INSERT INTO [dbo].[Buildings] ([BuildingId], [Type], [Name], [Address1], [Address2], [City], [State], [Zipcode], [ClientId], [Latitude], [Longitude]) VALUES (1001, N'Commercial', N'Social Kitchen', N'5505 Colorado', NULL, N'Washington', N'DC', N'20011', 5, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Buildings] OFF

SET IDENTITY_INSERT [dbo].[Candidates] ON
INSERT INTO [dbo].[Candidates] ([CandidateId], [FirstName], [LastName], [Age], [PhoneNumber], [Email], [PhotoBase64]) VALUES (2, N'Jon', N'Lewis', 45, N'2023335454', N'jlewis@gmail.com', NULL)
INSERT INTO [dbo].[Candidates] ([CandidateId], [FirstName], [LastName], [Age], [PhoneNumber], [Email], [PhotoBase64]) VALUES (3, N'Rebecca', N'Funk', 23, N'2025556767', N'rfunk@gmail.com', NULL)
INSERT INTO [dbo].[Candidates] ([CandidateId], [FirstName], [LastName], [Age], [PhoneNumber], [Email], [PhotoBase64]) VALUES (4, N'Micheal', N'Roots', 22, N'2221113333', N'mroots@cleanup.com', NULL)
INSERT INTO [dbo].[Candidates] ([CandidateId], [FirstName], [LastName], [Age], [PhoneNumber], [Email], [PhotoBase64]) VALUES (5, N'Larry', N'Holmes', 46, N'3432221234', N'lholmes@cleanup.com', NULL)
INSERT INTO [dbo].[Candidates] ([CandidateId], [FirstName], [LastName], [Age], [PhoneNumber], [Email], [PhotoBase64]) VALUES (7, N'Ernest', N'Hogans', 18, N'2026042913', N'ernest.hogans@gmail.com', NULL)
INSERT INTO [dbo].[Candidates] ([CandidateId], [FirstName], [LastName], [Age], [PhoneNumber], [Email], [PhotoBase64]) VALUES (8, N'Chante', N'Little', 45, N'2026031199', N'chante.hogans@gmail.com', NULL)
INSERT INTO [dbo].[Candidates] ([CandidateId], [FirstName], [LastName], [Age], [PhoneNumber], [Email], [PhotoBase64]) VALUES (11, N'John', N'Hogans', 22, N'2026042913', N'John.hogans@gmail.com', NULL)
SET IDENTITY_INSERT [dbo].[Candidates] OFF

SET IDENTITY_INSERT [dbo].[Clients] ON
INSERT INTO [dbo].[Clients] ([ClientId], [FirstName], [LastName], [NickName], [Email], [Phone], [BirthDate]) VALUES (2, N'Markasar7', N'Jeffries13', N'MJs', N'mjeff@gmail.com', N'1112223333', N'2022-08-16 00:00:00')
INSERT INTO [dbo].[Clients] ([ClientId], [FirstName], [LastName], [NickName], [Email], [Phone], [BirthDate]) VALUES (3, N'Jason', N'Kings', N'JK', N'jking@gmail.com', N'3102346789', N'2000-03-30 00:00:00')
INSERT INTO [dbo].[Clients] ([ClientId], [FirstName], [LastName], [NickName], [Email], [Phone], [BirthDate]) VALUES (5, N'Larry', N'Lewis', N'larse', N'll@gmail.com', N'2023334444', N'1990-04-04 00:00:00')
INSERT INTO [dbo].[Clients] ([ClientId], [FirstName], [LastName], [NickName], [Email], [Phone], [BirthDate]) VALUES (6, N'Mick', N'Arsonal', N'Mickey', N'mickarson@gmail.com', N'202333433', N'1995-05-06 00:00:00')
INSERT INTO [dbo].[Clients] ([ClientId], [FirstName], [LastName], [NickName], [Email], [Phone], [BirthDate]) VALUES (1024, N'Robert', N'Hogans', N'rrt', N'bobby.hogans@gmail.com', N'2026042913', NULL)
INSERT INTO [dbo].[Clients] ([ClientId], [FirstName], [LastName], [NickName], [Email], [Phone], [BirthDate]) VALUES (1030, N'sss', N'Hogans', N'sss', N'sss.hogans@gmail.com', N'2026042913', NULL)
SET IDENTITY_INSERT [dbo].[Clients] OFF

SET IDENTITY_INSERT [dbo].[Employees] ON
INSERT INTO [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Age], [PhoneNumber], [Email], [StartDate], [CreatedAt], [Latitude], [Longitude]) VALUES (2, N'Jessica1', N'Harlow', 25, N'1112223334', N'rj@gmail.com', N'2021-03-12 00:00:00', N'2021-06-12 00:00:00', NULL, NULL)
INSERT INTO [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Age], [PhoneNumber], [Email], [StartDate], [CreatedAt], [Latitude], [Longitude]) VALUES (3, N'Jewell', N'Jackson', 18, N'1112223333', N'jewellj@gmail.com', N'2021-03-03 00:00:00', N'2021-10-12 00:00:00', NULL, NULL)
INSERT INTO [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Age], [PhoneNumber], [Email], [StartDate], [CreatedAt], [Latitude], [Longitude]) VALUES (4, N'Timothy', N'Towson', 32, N'1112223333', N'ttow@gmail.com', N'2021-03-03 00:00:00', N'2021-09-12 00:00:00', NULL, NULL)
INSERT INTO [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Age], [PhoneNumber], [Email], [StartDate], [CreatedAt], [Latitude], [Longitude]) VALUES (5, N'Jadia', N'Mitchell', 20, N'1112223333', N'jmitch@gmail.com', N'2021-03-03 00:00:00', N'2021-06-12 00:00:00', NULL, NULL)
INSERT INTO [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Age], [PhoneNumber], [Email], [StartDate], [CreatedAt], [Latitude], [Longitude]) VALUES (1001, N'Robert', N'Hogans', 45, N'2027234229', N'bobby.hogans@gmail.com', N'2021-11-02 00:00:00', N'2021-06-12 00:00:00', NULL, NULL)
INSERT INTO [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Age], [PhoneNumber], [Email], [StartDate], [CreatedAt], [Latitude], [Longitude]) VALUES (1002, N'eric', N'White', 45, N'1112223333', N'ewh@gmail.com', N'2021-05-05 00:00:00', N'2021-06-12 00:00:00', NULL, NULL)
INSERT INTO [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Age], [PhoneNumber], [Email], [StartDate], [CreatedAt], [Latitude], [Longitude]) VALUES (2002, N'Jon', N'Lewis', 45, N'2023335454', N'jlewis@gmail.com', N'2022-08-26 00:00:00', N'0001-01-01 00:00:00', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Employees] OFF

SET IDENTITY_INSERT [dbo].[Jobs] ON
INSERT INTO [dbo].[Jobs] ([JobId], [JobType], [BuildingId], [Start], [Finish], [Status]) VALUES (1002, N'Commercial', 2, N'2021-10-06 20:03:00', N'2021-10-07 20:03:00', N'Completed')
INSERT INTO [dbo].[Jobs] ([JobId], [JobType], [BuildingId], [Start], [Finish], [Status]) VALUES (1003, N'Residential', 2, N'2021-10-10 12:00:00', N'2021-10-10 17:00:00', N'InProcess')
INSERT INTO [dbo].[Jobs] ([JobId], [JobType], [BuildingId], [Start], [Finish], [Status]) VALUES (1004, N'Residential', 2, N'2021-10-11 12:00:00', N'2021-10-11 15:00:00', N'Pending')
INSERT INTO [dbo].[Jobs] ([JobId], [JobType], [BuildingId], [Start], [Finish], [Status]) VALUES (1005, N'Residential', 2, N'2021-10-14 16:00:00', N'2021-10-14 20:00:00', N'Pending')
INSERT INTO [dbo].[Jobs] ([JobId], [JobType], [BuildingId], [Start], [Finish], [Status]) VALUES (1006, N'Commercial', 3, N'2021-12-27 20:03:00', N'2021-12-27 20:03:00', N'InProcess')
INSERT INTO [dbo].[Jobs] ([JobId], [JobType], [BuildingId], [Start], [Finish], [Status]) VALUES (1007, N'Residential', 3, N'2021-12-27 12:00:00', N'2021-12-27 17:00:00', N'InProcess')
INSERT INTO [dbo].[Jobs] ([JobId], [JobType], [BuildingId], [Start], [Finish], [Status]) VALUES (1008, N'Residential', 3, N'2021-12-27 12:00:00', N'2021-12-27 15:00:00', N'InProcess')
INSERT INTO [dbo].[Jobs] ([JobId], [JobType], [BuildingId], [Start], [Finish], [Status]) VALUES (1009, N'Residential', 3, N'2021-12-27 16:00:00', N'2021-12-27 20:00:00', N'InProcess')
INSERT INTO [dbo].[Jobs] ([JobId], [JobType], [BuildingId], [Start], [Finish], [Status]) VALUES (1010, N'Residential', 2, N'2021-12-28 03:38:00', N'2021-12-28 05:37:00', N'Completed')
INSERT INTO [dbo].[Jobs] ([JobId], [JobType], [BuildingId], [Start], [Finish], [Status]) VALUES (1012, N'Residential', 2, N'2021-12-28 02:46:00', N'2021-12-28 03:46:00', N'InProcess')
INSERT INTO [dbo].[Jobs] ([JobId], [JobType], [BuildingId], [Start], [Finish], [Status]) VALUES (1013, N'Commercial', 2, N'2021-12-28 07:00:00', N'2021-12-28 09:00:00', N'Pending')
INSERT INTO [dbo].[Jobs] ([JobId], [JobType], [BuildingId], [Start], [Finish], [Status]) VALUES (1014, N'Residential', 2, N'2022-01-14 15:47:00', N'2022-01-15 14:48:00', N'Pending')
INSERT INTO [dbo].[Jobs] ([JobId], [JobType], [BuildingId], [Start], [Finish], [Status]) VALUES (1015, N'Residential', 2, N'2022-02-23 21:51:00', N'2022-02-23 19:51:00', N'InProcess')
INSERT INTO [dbo].[Jobs] ([JobId], [JobType], [BuildingId], [Start], [Finish], [Status]) VALUES (1016, N'Residential', 2, N'2022-02-23 21:51:00', N'2022-02-23 19:51:00', N'InProcess')
INSERT INTO [dbo].[Jobs] ([JobId], [JobType], [BuildingId], [Start], [Finish], [Status]) VALUES (1017, N'Residential', 2, N'2022-03-15 11:09:00', N'2022-03-15 11:11:00', N'Pending')
INSERT INTO [dbo].[Jobs] ([JobId], [JobType], [BuildingId], [Start], [Finish], [Status]) VALUES (1018, N'Residential', 1001, N'2022-08-10 10:37:00', N'2022-08-19 10:37:00', N'InProcess')
INSERT INTO [dbo].[Jobs] ([JobId], [JobType], [BuildingId], [Start], [Finish], [Status]) VALUES (1019, N'Commercial', 1001, N'2022-08-17 10:37:00', N'2022-08-19 10:37:00', N'Pending')
INSERT INTO [dbo].[Jobs] ([JobId], [JobType], [BuildingId], [Start], [Finish], [Status]) VALUES (1020, N'Residential', 1001, N'2022-08-27 10:11:00', N'2022-08-27 14:00:00', N'Pending')
SET IDENTITY_INSERT [dbo].[Jobs] OFF





SET IDENTITY_INSERT [dbo].[CTasks] ON
INSERT INTO [dbo].[CTasks] ([CTaskId], [Room], [TaskName], [EstimatedTime], [CompletionTime], [PropId], [GuidePhotoUrl], [TemplateId], [TaskType], [BuildingId]) VALUES (3, N'Bedroom', N'Pick up clothes', 5, 4, 2, N'~/photos/mantle.jpg', 2, NULL, 2)
INSERT INTO [dbo].[CTasks] ([CTaskId], [Room], [TaskName], [EstimatedTime], [CompletionTime], [PropId], [GuidePhotoUrl], [TemplateId], [TaskType], [BuildingId]) VALUES (4, N'Bedroom', N'Make bed', 8, 8, 2, N'~/photos/mantle.jpg', 2, N'Arrange', 2)
INSERT INTO [dbo].[CTasks] ([CTaskId], [Room], [TaskName], [EstimatedTime], [CompletionTime], [PropId], [GuidePhotoUrl], [TemplateId], [TaskType], [BuildingId]) VALUES (5, N'Bedroom', N'Vacuum Rug', 3, 2, 2, N'~/photos/mantle.jpg', 2, N'Vaccuum', 2)
INSERT INTO [dbo].[CTasks] ([CTaskId], [Room], [TaskName], [EstimatedTime], [CompletionTime], [PropId], [GuidePhotoUrl], [TemplateId], [TaskType], [BuildingId]) VALUES (6, N'Kitchen', N'Wash Dishes', 15, 20, 2, N'~/photos/mantle.jpg', 1, N'Wash', 2)
INSERT INTO [dbo].[CTasks] ([CTaskId], [Room], [TaskName], [EstimatedTime], [CompletionTime], [PropId], [GuidePhotoUrl], [TemplateId], [TaskType], [BuildingId]) VALUES (7, N'Kitchen', N'Mop Foor', 8, 8, 2, N'~/photos/mantle.jpg', 1, N'Mop', 2)
SET IDENTITY_INSERT [dbo].[CTasks] OFF
