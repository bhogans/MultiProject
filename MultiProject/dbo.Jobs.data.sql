SET IDENTITY_INSERT [dbo].[Jobs] ON
INSERT INTO [dbo].[Jobs] ([JobId], [JobType], [BuildingId], [Start], [Finish], [Status]) VALUES (1, N'Commercial', 1, N'2021-10-06 20:03:00', N'2021-10-07 20:03:00', N'Completed')
INSERT INTO [dbo].[Jobs] ([JobId], [JobType], [BuildingId], [Start], [Finish], [Status]) VALUES (2, N'Residential', 1, N'2021-10-10 12:00:00', N'2021-10-10 17:00:00', N'InProcess')
INSERT INTO [dbo].[Jobs] ([JobId], [JobType], [BuildingId], [Start], [Finish], [Status]) VALUES (3, N'Residential', 1, N'2021-10-11 12:00:00', N'2021-10-11 15:00:00', N'Pending')
INSERT INTO [dbo].[Jobs] ([JobId], [JobType], [BuildingId], [Start], [Finish], [Status]) VALUES (4, N'Residential', 1, N'2021-10-14 16:00:00', N'2021-10-14 20:00:00', N'Pending')
SET IDENTITY_INSERT [dbo].[Jobs] OFF
