USE [IBBPortal]
GO
SET IDENTITY_INSERT [dbo].[Subfunction] ON 
GO
INSERT [dbo].[Subfunction] ([SubfunctionID], [SubfunctionTitle], [SubfunctionDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, N'Cami', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T16:48:19.6676731' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Subfunction] ([SubfunctionID], [SubfunctionTitle], [SubfunctionDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, N'Park', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T16:48:22.5796050' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Subfunction] ([SubfunctionID], [SubfunctionTitle], [SubfunctionDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (3, N'Otopark', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T16:48:25.6772348' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Subfunction] ([SubfunctionID], [SubfunctionTitle], [SubfunctionDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (4, N'Hebele Hübele', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T16:48:28.1316963' AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Subfunction] OFF
GO
SET IDENTITY_INSERT [dbo].[SubfunctionFeature] ON 
GO
INSERT [dbo].[SubfunctionFeature] ([SubfunctionFeatureID], [SubfunctionFeatureTitle], [SubfunctionFeatureDescription], [SubfunctionMeasurementUnit], [SubfunctionID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, N'Özellik Deneme', NULL, N'm2', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T16:48:35.1872755' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[SubfunctionFeature] ([SubfunctionFeatureID], [SubfunctionFeatureTitle], [SubfunctionFeatureDescription], [SubfunctionMeasurementUnit], [SubfunctionID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, N'Kapasite', NULL, N'Adet', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T16:48:41.6106443' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[SubfunctionFeature] ([SubfunctionFeatureID], [SubfunctionFeatureTitle], [SubfunctionFeatureDescription], [SubfunctionMeasurementUnit], [SubfunctionID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (3, N'Alan', NULL, N'm2', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T16:48:46.3678729' AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[SubfunctionFeature] OFF
GO
SET IDENTITY_INSERT [dbo].[City] ON 
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, 1, N'Adana', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.7933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, 2, N'Adıyaman', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.7933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (3, 3, N'Afyonkarahisar', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.7966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (4, 4, N'Ağrı', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.7966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (5, 5, N'Amasya', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.7966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (6, 6, N'Ankara', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.7966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (7, 7, N'Antalya', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.7966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (8, 8, N'Artvin', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.7966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (9, 9, N'Aydın', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.7966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (10, 10, N'Balıkesir', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.7966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (11, 11, N'Bilecik', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.7966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (12, 12, N'Bingöl', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.7966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (13, 13, N'Bitlis', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.7966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (14, 14, N'Bolu', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.7966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (15, 15, N'Burdur', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (16, 16, N'Bursa', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (17, 17, N'Çanakkale', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (18, 18, N'Çankırı', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (19, 19, N'Çorum', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (20, 20, N'Denizli', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (21, 21, N'Diyarbakır', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (22, 22, N'Edirne', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (23, 23, N'Elazığ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (24, 24, N'Erzincan', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (25, 25, N'Erzurum', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (26, 26, N'Eskişehir', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (27, 27, N'Gaziantep', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (28, 28, N'Giresun', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (29, 29, N'Gümüşhane', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (30, 30, N'Hakkâri', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (31, 31, N'Hatay', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (32, 32, N'Isparta', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (33, 33, N'İçel (Mersin)', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (34, 34, N'İstanbul', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (35, 35, N'İzmir', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (36, 36, N'Kars', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (37, 37, N'Kastamonu', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (38, 38, N'Kayseri', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (39, 39, N'Kırklareli', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (40, 40, N'Kırşehir', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (41, 41, N'Kocaeli', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (42, 42, N'Konya', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (43, 43, N'Kütahya', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (44, 44, N'Malatya', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (45, 45, N'Manisa', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (46, 46, N'Kahramanmaraş', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (47, 47, N'Mardin', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (48, 48, N'Muğla', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (49, 49, N'Muş', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (50, 50, N'Nevşehir', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (51, 51, N'Niğde', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (52, 52, N'Ordu', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (53, 53, N'Rize', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (54, 54, N'Sakarya', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (55, 55, N'Samsun', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (56, 56, N'Siirt', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (57, 57, N'Sinop', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (58, 58, N'Sivas', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (59, 59, N'Tekirdağ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (60, 60, N'Tokat', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (61, 61, N'Trabzon', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (62, 62, N'Tunceli', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (63, 63, N'Şanlıurfa', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (64, 64, N'Uşak', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (65, 65, N'Van', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (66, 66, N'Yozgat', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (67, 67, N'Zonguldak', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (68, 68, N'Aksaray', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (69, 69, N'Bayburt', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (70, 70, N'Karaman', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (71, 71, N'Kırıkkale', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (72, 72, N'Batman', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (73, 73, N'Şırnak', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (74, 74, N'Bartın', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (75, 75, N'Ardahan', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (76, 76, N'Iğdır', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (77, 77, N'Yalova', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (78, 78, N'Karabük', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (79, 79, N'Kilis', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (80, 80, N'Osmaniye', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[City] ([CityID], [CityCode], [CityName], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (81, 81, N'Düzce', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8100000' AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[City] OFF
GO
SET IDENTITY_INSERT [dbo].[District] ON 
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, 1219, N'Ceyhan', 1, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, 1329, N'Feke', 1, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (3, 1437, N'Karaisalı', 1, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (4, 1443, N'Karataş', 1, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (5, 1486, N'Kozan', 1, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (6, 1580, N'Pozantı', 1, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (7, 1588, N'Saimbeyli', 1, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (8, 1687, N'Tufanbeyli', 1, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (9, 1734, N'Yumurtalık', 1, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (10, 1748, N'Yüreğir', 1, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (11, 1757, N'Aladağ', 1, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (12, 1806, N'İmamoğlu', 1, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (13, 2032, N'Sarıçam', 1, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (14, 2033, N'Çukurova', 1, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (15, 1105, N'Merkez', 2, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (16, 1182, N'Besni', 2, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (17, 1246, N'Çelikhan', 2, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (18, 1347, N'Gerger', 2, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (19, 1354, N'Gölbaşı', 2, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (20, 1425, N'Kahta', 2, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (21, 1592, N'Samsat', 2, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (22, 1985, N'Sincik', 2, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (23, 1989, N'Tut', 2, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (24, 1108, N'Merkez', 3, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (25, 1200, N'Bolvadin', 3, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (26, 1239, N'Çay', 3, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (27, 1267, N'Dazkırı', 3, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (28, 1281, N'Dinar', 3, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (29, 1306, N'Emirdağ', 3, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (30, 1404, N'İhsaniye', 3, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (31, 1594, N'Sandıklı', 3, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (32, 1626, N'Sinanpaşa', 3, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (33, 1639, N'Sultandağı', 3, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (34, 1664, N'Şuhut', 3, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (35, 1771, N'Başmakçı', 3, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (36, 1773, N'Bayat', 3, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.8966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (37, 1809, N'İscehisar', 3, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (38, 1906, N'Çobanlar', 3, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (39, 1923, N'Evciler', 3, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (40, 1944, N'Hocalar', 3, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (41, 1961, N'Kızılören', 3, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (42, 1111, N'Merkez', 4, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (43, 1283, N'Diyadin', 4, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (44, 1287, N'Doğubayazıt', 4, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (45, 1301, N'Eleşkirt', 4, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (46, 1379, N'Hamur', 4, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (47, 1568, N'Patnos', 4, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (48, 1667, N'Taşlıçay', 4, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (49, 1691, N'Tutak', 4, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (50, 1134, N'Merkez', 5, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (51, 1363, N'Göynücek', 5, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (52, 1368, N'Gümüşhacıköy', 5, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (53, 1524, N'Merzifon', 5, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (54, 1641, N'Suluova', 5, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (55, 1668, N'Taşova', 5, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (56, 1938, N'Hamamözü', 5, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (57, 1130, N'Altındağ', 6, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (58, 1157, N'Ayaş', 6, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (59, 1167, N'Bala', 6, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (60, 1187, N'Beypazarı', 6, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (61, 1227, N'Çamlıdere', 6, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (62, 1231, N'Çankaya', 6, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (63, 1260, N'Çubuk', 6, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (64, 1302, N'Elmadağ', 6, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (65, 1365, N'Güdül', 6, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (66, 1387, N'Haymana', 6, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (67, 1427, N'Kalecik', 6, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (68, 1473, N'Kızılcahamam', 6, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (69, 1539, N'Nallıhan', 6, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (70, 1578, N'Polatlı', 6, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (71, 1658, N'Şereflikoçhisar', 6, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (72, 1723, N'Yenimahalle', 6, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (73, 1744, N'Gölbaşı', 6, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (74, 1745, N'Keçiören', 6, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (75, 1746, N'Mamak', 6, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (76, 1747, N'Sincan', 6, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (77, 1815, N'Kazan', 6, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (78, 1872, N'Akyurt', 6, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (79, 1922, N'Etimesgut', 6, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:27.9966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (80, 1924, N'Evren', 6, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (81, 2034, N'Pursaklar', 6, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (82, 1121, N'Akseki', 7, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (83, 1126, N'Alanya', 7, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (84, 1303, N'Elmalı', 7, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (85, 1333, N'Finike', 7, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (86, 1337, N'Gazipaşa', 7, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (87, 1370, N'Gündoğmuş', 7, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (88, 1451, N'Kaş', 7, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (89, 1483, N'Korkuteli', 7, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (90, 1492, N'Kumluca', 7, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (91, 1512, N'Manavgat', 7, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (92, 1616, N'Serik', 7, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (93, 1811, N'Demre', 7, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (94, 1946, N'İbradı', 7, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (95, 1959, N'Kemer', 7, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (96, 2035, N'Aksu', 7, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (97, 2036, N'Döşemealtı', 7, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (98, 2037, N'Kepez', 7, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (99, 2038, N'Konyaaltı', 7, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (100, 2039, N'Muratpaşa', 7, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (101, 1145, N'Ardanuç', 8, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (102, 1147, N'Arhavi', 8, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (103, 1152, N'Merkez', 8, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (104, 1202, N'Borçka', 8, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (105, 1395, N'Hopa', 8, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (106, 1653, N'Şavşat', 8, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (107, 1736, N'Yusufeli', 8, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (108, 1828, N'Murgul', 8, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (109, 1206, N'Bozdoğan', 9, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (110, 1256, N'Çine', 9, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (111, 1348, N'Germencik', 9, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (112, 1435, N'Karacasu', 9, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (113, 1479, N'Koçarlı', 9, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (114, 1497, N'Kuşadası', 9, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (115, 1498, N'Kuyucak', 9, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (116, 1542, N'Nazilli', 9, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (117, 1637, N'Söke', 9, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (118, 1640, N'Sultanhisar', 9, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (119, 1724, N'Yenipazar', 9, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (120, 1781, N'Buharkent', 9, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (121, 1807, N'İncirliova', 9, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (122, 1957, N'Karpuzlu', 9, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.0966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (123, 1968, N'Köşk', 9, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (124, 2000, N'Didim', 9, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (125, 2076, N'Efeler', 9, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (126, 1161, N'Ayvalık', 10, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (127, 1169, N'Balya', 10, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (128, 1171, N'Bandırma', 10, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (129, 1191, N'Bigadiç', 10, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (130, 1216, N'Burhaniye', 10, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (131, 1291, N'Dursunbey', 10, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (132, 1294, N'Edremit', 10, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (133, 1310, N'Erdek', 10, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (134, 1360, N'Gönen', 10, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (135, 1384, N'Havran', 10, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (136, 1418, N'İvrindi', 10, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (137, 1462, N'Kepsut', 10, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (138, 1514, N'Manyas', 10, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (139, 1608, N'Savaştepe', 10, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (140, 1619, N'Sındırgı', 10, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (141, 1644, N'Susurluk', 10, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (142, 1824, N'Marmara', 10, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (143, 1928, N'Gömeç', 10, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (144, 2077, N'Altıeylül', 10, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (145, 2078, N'Karesi', 10, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (146, 1192, N'Merkez', 11, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (147, 1210, N'Bozüyük', 11, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (148, 1359, N'Gölpazarı', 11, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (149, 1559, N'Osmaneli', 11, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (150, 1571, N'Pazaryeri', 11, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (151, 1636, N'Söğüt', 11, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (152, 1857, N'Yenipazar', 11, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (153, 1948, N'İnhisar', 11, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (154, 1193, N'Merkez', 12, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (155, 1344, N'Genç', 12, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (156, 1446, N'Karlıova', 12, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (157, 1475, N'Kiğı', 12, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (158, 1633, N'Solhan', 12, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (159, 1750, N'Adaklı', 12, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (160, 1855, N'Yayladere', 12, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (161, 1996, N'Yedisu', 12, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (162, 1106, N'Adilcevaz', 13, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (163, 1112, N'Ahlat', 13, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (164, 1196, N'Merkez', 13, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (165, 1394, N'Hizan', 13, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (166, 1537, N'Mutki', 13, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.1966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (167, 1669, N'Tatvan', 13, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (168, 1798, N'Güroymak', 13, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (169, 1199, N'Merkez', 14, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (170, 1346, N'Gerede', 14, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (171, 1364, N'Göynük', 14, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (172, 1466, N'Kıbrıscık', 14, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (173, 1522, N'Mengen', 14, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (174, 1531, N'Mudurnu', 14, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (175, 1610, N'Seben', 14, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (176, 1916, N'Dörtdivan', 14, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (177, 1997, N'Yeniçağa', 14, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (178, 1109, N'Ağlasun', 15, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (179, 1211, N'Bucak', 15, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (180, 1215, N'Merkez', 15, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (181, 1357, N'Gölhisar', 15, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (182, 1672, N'Tefenni', 15, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (183, 1728, N'Yeşilova', 15, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (184, 1813, N'Karamanlı', 15, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (185, 1816, N'Kemer', 15, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (186, 1874, N'Altınyayla', 15, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (187, 1899, N'Çavdır', 15, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (188, 1903, N'Çeltikçi', 15, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (189, 1343, N'Gemlik', 16, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (190, 1411, N'İnegöl', 16, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (191, 1420, N'İznik', 16, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (192, 1434, N'Karacabey', 16, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (193, 1457, N'Keles', 16, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (194, 1530, N'Mudanya', 16, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (195, 1535, N'Mustafakemalpaşa', 16, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (196, 1553, N'Orhaneli', 16, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (197, 1554, N'Orhangazi', 16, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (198, 1725, N'Yenişehir', 16, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (199, 1783, N'Büyükorhan', 16, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (200, 1799, N'Harmancık', 16, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (201, 1829, N'Nilüfer', 16, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (202, 1832, N'Osmangazi', 16, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (203, 1859, N'Yıldırım', 16, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (204, 1935, N'Gürsu', 16, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (205, 1960, N'Kestel', 16, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (206, 1160, N'Ayvacık', 17, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (207, 1180, N'Bayramiç', 17, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (208, 1190, N'Biga', 17, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (209, 1205, N'Bozcaada', 17, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.2966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (210, 1229, N'Çan', 17, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (211, 1230, N'Merkez', 17, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (212, 1293, N'Eceabat', 17, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (213, 1326, N'Ezine', 17, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (214, 1340, N'Gelibolu', 17, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (215, 1408, N'Gökçeada', 17, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (216, 1503, N'Lapseki', 17, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (217, 1722, N'Yenice', 17, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (218, 1232, N'Merkez', 18, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (219, 1248, N'Çerkeş', 18, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (220, 1300, N'Eldivan', 18, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (221, 1399, N'Ilgaz', 18, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (222, 1494, N'Kurşunlu', 18, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (223, 1555, N'Orta', 18, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (224, 1649, N'Şabanözü', 18, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (225, 1718, N'Yapraklı', 18, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (226, 1765, N'Atkaracalar', 18, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (227, 1817, N'Kızılırmak', 18, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (228, 1885, N'Bayramören', 18, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (229, 1963, N'Korgun', 18, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (230, 1124, N'Alaca', 19, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (231, 1177, N'Bayat', 19, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (232, 1259, N'Merkez', 19, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (233, 1414, N'İskilip', 19, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (234, 1445, N'Kargı', 19, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (235, 1520, N'Mecitözü', 19, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (236, 1556, N'Ortaköy', 19, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (237, 1558, N'Osmancık', 19, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (238, 1642, N'Sungurlu', 19, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (239, 1778, N'Boğazkale', 19, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (240, 1850, N'Uğurludağ', 19, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (241, 1911, N'Dodurga', 19, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (242, 1972, N'Laçin', 19, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (243, 1976, N'Oğuzlar', 19, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (244, 1102, N'Acıpayam', 20, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (245, 1214, N'Buldan', 20, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (246, 1224, N'Çal', 20, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (247, 1226, N'Çameli', 20, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (248, 1233, N'Çardak', 20, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (249, 1257, N'Çivril', 20, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (250, 1371, N'Güney', 20, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.3966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (251, 1426, N'Kale', 20, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (252, 1597, N'Sarayköy', 20, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (253, 1670, N'Tavas', 20, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (254, 1769, N'Babadağ', 20, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (255, 1774, N'Bekilli', 20, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (256, 1803, N'Honaz', 20, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (257, 1840, N'Serinhisar', 20, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (258, 1871, N'Pamukkale', 20, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (259, 1881, N'Baklan', 20, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (260, 1888, N'Beyağaç', 20, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (261, 1889, N'Bozkurt', 20, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (262, 2079, N'Merkezefendi', 20, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (263, 1195, N'Bismil', 21, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (264, 1249, N'Çermik', 21, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (265, 1253, N'Çınar', 21, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (266, 1263, N'Çüngüş', 21, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (267, 1278, N'Dicle', 21, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (268, 1315, N'Ergani', 21, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (269, 1381, N'Hani', 21, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (270, 1389, N'Hazro', 21, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (271, 1490, N'Kulp', 21, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (272, 1504, N'Lice', 21, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (273, 1624, N'Silvan', 21, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (274, 1791, N'Eğil', 21, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (275, 1962, N'Kocaköy', 21, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (276, 2040, N'Bağlar', 21, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (277, 2041, N'Kayapınar', 21, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (278, 2042, N'Sur', 21, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (279, 2043, N'Yenişehir', 21, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (280, 1295, N'Merkez', 22, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (281, 1307, N'Enez', 22, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (282, 1385, N'Havsa', 22, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (283, 1412, N'İpsala', 22, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (284, 1464, N'Keşan', 22, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (285, 1502, N'Lalapaşa', 22, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (286, 1523, N'Meriç', 22, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (287, 1705, N'Uzunköprü', 22, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (288, 1988, N'Süloğlu', 22, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (289, 1110, N'Ağın', 23, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (290, 1173, N'Baskil', 23, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (291, 1298, N'Merkez', 23, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (292, 1438, N'Karakoçan', 23, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.4966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (293, 1455, N'Keban', 23, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (294, 1506, N'Maden', 23, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (295, 1566, N'Palu', 23, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (296, 1631, N'Sivrice', 23, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (297, 1762, N'Arıcak', 23, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (298, 1820, N'Kovancılar', 23, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (299, 1873, N'Alacakaya', 23, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (300, 1243, N'Çayırlı', 24, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (301, 1318, N'Merkez', 24, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (302, 1406, N'İliç', 24, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (303, 1459, N'Kemah', 24, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (304, 1460, N'Kemaliye', 24, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (305, 1583, N'Refahiye', 24, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (306, 1675, N'Tercan', 24, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (307, 1853, N'Üzümlü', 24, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (308, 1977, N'Otlukbeli', 24, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (309, 1153, N'Aşkale', 25, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (310, 1235, N'Çat', 25, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (311, 1392, N'Hınıs', 25, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (312, 1396, N'Horasan', 25, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (313, 1416, N'İspir', 25, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (314, 1444, N'Karayazı', 25, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (315, 1540, N'Narman', 25, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (316, 1550, N'Oltu', 25, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (317, 1551, N'Olur', 25, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (318, 1567, N'Pasinler', 25, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (319, 1657, N'Şenkaya', 25, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (320, 1674, N'Tekman', 25, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (321, 1683, N'Tortum', 25, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (322, 1812, N'Karaçoban', 25, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (323, 1851, N'Uzundere', 25, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (324, 1865, N'Pazaryolu', 25, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (325, 1945, N'Aziziye', 25, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (326, 1967, N'Köprüköy', 25, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (327, 2044, N'Palandöken', 25, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (328, 2045, N'Yakutiye', 25, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (329, 1255, N'Çifteler', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (330, 1508, N'Mahmudiye', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (331, 1527, N'Mihalıççık', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (332, 1599, N'Sarıcakaya', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (333, 1618, N'Seyitgazi', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.5966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (334, 1632, N'Sivrihisar', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (335, 1759, N'Alpu', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (336, 1777, N'Beylikova', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (337, 1808, N'İnönü', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (338, 1934, N'Günyüzü', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (339, 1939, N'Han', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (340, 1973, N'Mihalgazi', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (341, 2046, N'Odunpazarı', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (342, 2047, N'Tepebaşı', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (343, 1139, N'Araban', 27, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (344, 1415, N'İslahiye', 27, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (345, 1546, N'Nizip', 27, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (346, 1549, N'Oğuzeli', 27, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (347, 1720, N'Yavuzeli', 27, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (348, 1841, N'Şahinbey', 27, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (349, 1844, N'Şehitkamil', 27, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (350, 1956, N'Karkamış', 27, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (351, 1974, N'Nurdağı', 27, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (352, 1133, N'Alucra', 28, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (353, 1212, N'Bulancak', 28, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (354, 1272, N'Dereli', 28, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (355, 1320, N'Espiye', 28, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (356, 1324, N'Eynesil', 28, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (357, 1352, N'Merkez', 28, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (358, 1361, N'Görele', 28, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (359, 1465, N'Keşap', 28, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (360, 1654, N'Şebinkarahisar', 28, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (361, 1678, N'Tirebolu', 28, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (362, 1837, N'Piraziz', 28, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (363, 1854, N'Yağlıdere', 28, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (364, 1893, N'Çamoluk', 28, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (365, 1894, N'Çanakçı', 28, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (366, 1912, N'Doğankent', 28, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (367, 1930, N'Güce', 28, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (368, 1369, N'Merkez', 29, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (369, 1458, N'Kelkit', 29, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (370, 1660, N'Şiran', 29, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (371, 1684, N'Torul', 29, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (372, 1822, N'Köse', 29, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (373, 1971, N'Kürtün', 29, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (374, 1261, N'Çukurca', 30, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (375, 1377, N'Merkez', 30, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (376, 1656, N'Şemdinli', 30, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.6966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (377, 1737, N'Yüksekova', 30, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (378, 1131, N'Altınözü', 31, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (379, 1289, N'Dörtyol', 31, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (380, 1382, N'Hassa', 31, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (381, 1413, N'İskenderun', 31, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (382, 1468, N'Kırıkhan', 31, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (383, 1585, N'Reyhanlı', 31, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (384, 1591, N'Samandağ', 31, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (385, 1721, N'Yayladağı', 31, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (386, 1792, N'Erzin', 31, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (387, 1887, N'Belen', 31, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (388, 1970, N'Kumlu', 31, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (389, 2080, N'Antakya', 31, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (390, 2081, N'Arsuz', 31, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (391, 2082, N'Defne', 31, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (392, 2083, N'Payas', 31, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (393, 1154, N'Atabey', 32, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (394, 1297, N'Eğirdir', 32, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (395, 1341, N'Gelendost', 32, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (396, 1401, N'Merkez', 32, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (397, 1456, N'Keçiborlu', 32, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (398, 1615, N'Senirkent', 32, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (399, 1648, N'Sütçüler', 32, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (400, 1651, N'Şarkikaraağaç', 32, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (401, 1699, N'Uluborlu', 32, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (402, 1717, N'Yalvaç', 32, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (403, 1755, N'Aksu', 32, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (404, 1929, N'Gönen', 32, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (405, 2001, N'Yenişarbademli', 32, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (406, 1135, N'Anamur', 33, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (407, 1311, N'Erdemli', 33, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (408, 1366, N'Gülnar', 33, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (409, 1536, N'Mut', 33, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (410, 1621, N'Silifke', 33, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (411, 1665, N'Tarsus', 33, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (412, 1766, N'Aydıncık', 33, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (413, 1779, N'Bozyazı', 33, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (414, 1892, N'Çamlıyayla', 33, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (415, 2064, N'Akdeniz', 33, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (416, 2065, N'Mezitli', 33, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (417, 2066, N'Toroslar', 33, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (418, 2067, N'Yenişehir', 33, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.7966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (419, 1103, N'Adalar', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (420, 1166, N'Bakırköy', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (421, 1183, N'Beşiktaş', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (422, 1185, N'Beykoz', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (423, 1186, N'Beyoğlu', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (424, 1237, N'Çatalca', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (425, 1325, N'Eyüp', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (426, 1327, N'Fatih', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (427, 1336, N'Gaziosmanpaşa', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (428, 1421, N'Kadıköy', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (429, 1449, N'Kartal', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (430, 1604, N'Sarıyer', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (431, 1622, N'Silivri', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (432, 1659, N'Şile', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (433, 1663, N'Şişli', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (434, 1708, N'Üsküdar', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (435, 1739, N'Zeytinburnu', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (436, 1782, N'Büyükçekmece', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (437, 1810, N'Kağıthane', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (438, 1823, N'Küçükçekmece', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (439, 1835, N'Pendik', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (440, 1852, N'Ümraniye', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (441, 1886, N'Bayrampaşa', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (442, 2003, N'Avcılar', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (443, 2004, N'Bağcılar', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (444, 2005, N'Bahçelievler', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (445, 2010, N'Güngören', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (446, 2012, N'Maltepe', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (447, 2014, N'Sultanbeyli', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (448, 2015, N'Tuzla', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (449, 2016, N'Esenler', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (450, 2048, N'Arnavutköy', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (451, 2049, N'Ataşehir', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (452, 2050, N'Başakşehir', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (453, 2051, N'Beylikdüzü', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (454, 2052, N'Çekmeköy', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (455, 2053, N'Esenyurt', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (456, 2054, N'Sancaktepe', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (457, 2055, N'Sultangazi', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (458, 1128, N'Aliağa', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (459, 1178, N'Bayındır', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (460, 1181, N'Bergama', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.8966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (461, 1203, N'Bornova', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (462, 1251, N'Çeşme', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (463, 1280, N'Dikili', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (464, 1334, N'Foça', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (465, 1432, N'Karaburun', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (466, 1448, N'Karşıyaka', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (467, 1461, N'Kemalpaşa', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (468, 1467, N'Kınık', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (469, 1477, N'Kiraz', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (470, 1521, N'Menemen', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (471, 1563, N'Ödemiş', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (472, 1611, N'Seferihisar', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (473, 1612, N'Selçuk', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (474, 1677, N'Tire', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (475, 1682, N'Torbalı', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (476, 1703, N'Urla', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (477, 1776, N'Beydağ', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (478, 1780, N'Buca', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (479, 1819, N'Konak', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (480, 1826, N'Menderes', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (481, 2006, N'Balçova', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (482, 2007, N'Çiğli', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (483, 2009, N'Gaziemir', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (484, 2013, N'Narlıdere', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (485, 2018, N'Güzelbahçe', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (486, 2056, N'Bayraklı', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (487, 2057, N'Karabağlar', 35, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (488, 1149, N'Arpaçay', 36, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (489, 1279, N'Digor', 36, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (490, 1424, N'Kağızman', 36, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (491, 1447, N'Merkez', 36, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (492, 1601, N'Sarıkamış', 36, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (493, 1614, N'Selim', 36, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (494, 1645, N'Susuz', 36, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (495, 1756, N'Akyaka', 36, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (496, 1101, N'Abana', 37, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (497, 1140, N'Araç', 37, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (498, 1162, N'Azdavay', 37, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (499, 1208, N'Bozkurt', 37, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (500, 1221, N'Cide', 37, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (501, 1238, N'Çatalzeytin', 37, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (502, 1264, N'Daday', 37, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (503, 1277, N'Devrekani', 37, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:28.9966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (504, 1410, N'İnebolu', 37, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (505, 1450, N'Merkez', 37, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (506, 1499, N'Küre', 37, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (507, 1666, N'Taşköprü', 37, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (508, 1685, N'Tosya', 37, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (509, 1805, N'İhsangazi', 37, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (510, 1836, N'Pınarbaşı', 37, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (511, 1845, N'Şenpazar', 37, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (512, 1867, N'Ağlı', 37, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (513, 1915, N'Doğanyurt', 37, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (514, 1940, N'Hanönü', 37, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (515, 1984, N'Seydiler', 37, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (516, 1218, N'Bünyan', 38, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (517, 1275, N'Develi', 38, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (518, 1330, N'Felahiye', 38, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (519, 1409, N'İncesu', 38, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (520, 1576, N'Pınarbaşı', 38, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (521, 1603, N'Sarıoğlan', 38, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (522, 1605, N'Sarız', 38, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (523, 1680, N'Tomarza', 38, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (524, 1715, N'Yahyalı', 38, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (525, 1727, N'Yeşilhisar', 38, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (526, 1752, N'Akkışla', 38, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (527, 1846, N'Talas', 38, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (528, 1863, N'Kocasinan', 38, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (529, 1864, N'Melikgazi', 38, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (530, 1936, N'Hacılar', 38, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (531, 1978, N'Özvatan', 38, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (532, 1163, N'Babaeski', 39, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (533, 1270, N'Demirköy', 39, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (534, 1471, N'Merkez', 39, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (535, 1480, N'Kofçaz', 39, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (536, 1505, N'Lüleburgaz', 39, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (537, 1572, N'Pehlivanköy', 39, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (538, 1577, N'Pınarhisar', 39, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (539, 1714, N'Vize', 39, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (540, 1254, N'Çiçekdağı', 40, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (541, 1429, N'Kaman', 40, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (542, 1472, N'Merkez', 40, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (543, 1529, N'Mucur', 40, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (544, 1754, N'Akpınar', 40, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (545, 1869, N'Akçakent', 40, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.0966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (546, 1890, N'Boztepe', 40, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (547, 1338, N'Gebze', 41, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (548, 1355, N'Gölcük', 41, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (549, 1430, N'Kandıra', 41, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (550, 1440, N'Karamürsel', 41, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (551, 1821, N'Körfez', 41, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (552, 2030, N'Derince', 41, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (553, 2058, N'Başiskele', 41, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (554, 2059, N'Çayırova', 41, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (555, 2060, N'Darıca', 41, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (556, 2061, N'Dilovası', 41, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (557, 2062, N'İzmit', 41, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (558, 2063, N'Kartepe', 41, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (559, 1122, N'Akşehir', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (560, 1188, N'Beyşehir', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (561, 1207, N'Bozkır', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (562, 1222, N'Cihanbeyli', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (563, 1262, N'Çumra', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (564, 1285, N'Doğanhisar', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (565, 1312, N'Ereğli', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (566, 1375, N'Hadim', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (567, 1400, N'Ilgın', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (568, 1422, N'Kadınhanı', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (569, 1441, N'Karapınar', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (570, 1491, N'Kulu', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (571, 1598, N'Sarayönü', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (572, 1617, N'Seydişehir', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (573, 1735, N'Yunak', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (574, 1753, N'Akören', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (575, 1760, N'Altınekin', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (576, 1789, N'Derebucak', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (577, 1804, N'Hüyük', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (578, 1814, N'Karatay', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (579, 1827, N'Meram', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (580, 1839, N'Selçuklu', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (581, 1848, N'Taşkent', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (582, 1868, N'Ahırlı', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (583, 1902, N'Çeltik', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (584, 1907, N'Derbent', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (585, 1920, N'Emirgazi', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (586, 1933, N'Güneysınır', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.1966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (587, 1937, N'Halkapınar', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (588, 1990, N'Tuzlukçu', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (589, 1994, N'Yalıhüyük', 42, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (590, 1132, N'Altıntaş', 43, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (591, 1288, N'Domaniç', 43, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (592, 1304, N'Emet', 43, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (593, 1339, N'Gediz', 43, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (594, 1500, N'Merkez', 43, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (595, 1625, N'Simav', 43, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (596, 1671, N'Tavşanlı', 43, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (597, 1764, N'Aslanapa', 43, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (598, 1790, N'Dumlupınar', 43, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (599, 1802, N'Hisarcık', 43, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (600, 1843, N'Şaphane', 43, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (601, 1898, N'Çavdarhisar', 43, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (602, 1979, N'Pazarlar', 43, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (603, 1114, N'Akçadağ', 44, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (604, 1143, N'Arapgir', 44, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (605, 1148, N'Arguvan', 44, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (606, 1265, N'Darende', 44, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (607, 1286, N'Doğanşehir', 44, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (608, 1390, N'Hekimhan', 44, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (609, 1582, N'Pütürge', 44, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (610, 1729, N'Yeşilyurt', 44, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (611, 1772, N'Battalgazi', 44, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (612, 1914, N'Doğanyol', 44, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (613, 1953, N'Kale', 44, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (614, 1969, N'Kuluncak', 44, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (615, 1995, N'Yazıhan', 44, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (616, 1118, N'Akhisar', 45, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (617, 1127, N'Alaşehir', 45, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (618, 1269, N'Demirci', 45, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (619, 1362, N'Gördes', 45, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (620, 1470, N'Kırkağaç', 45, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (621, 1489, N'Kula', 45, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (622, 1590, N'Salihli', 45, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (623, 1600, N'Sarıgöl', 45, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (624, 1606, N'Saruhanlı', 45, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (625, 1613, N'Selendi', 45, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (626, 1634, N'Soma', 45, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (627, 1689, N'Turgutlu', 45, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (628, 1751, N'Ahmetli', 45, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.2966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (629, 1793, N'Gölmarmara', 45, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (630, 1965, N'Köprübaşı', 45, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (631, 2086, N'Şehzadeler', 45, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (632, 2087, N'Yunusemre', 45, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (633, 1107, N'Afşin', 46, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (634, 1136, N'Andırın', 46, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (635, 1299, N'Elbistan', 46, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (636, 1353, N'Göksun', 46, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (637, 1570, N'Pazarcık', 46, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (638, 1694, N'Türkoğlu', 46, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (639, 1785, N'Çağlayancerit', 46, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (640, 1919, N'Ekinözü', 46, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (641, 1975, N'Nurhak', 46, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (642, 2084, N'Dulkadiroğlu', 46, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (643, 2085, N'Onikişubat', 46, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (644, 1273, N'Derik', 47, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (645, 1474, N'Kızıltepe', 47, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (646, 1519, N'Mazıdağı', 47, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (647, 1526, N'Midyat', 47, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (648, 1547, N'Nusaybin', 47, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (649, 1564, N'Ömerli', 47, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (650, 1609, N'Savur', 47, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (651, 1787, N'Dargeçit', 47, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (652, 2002, N'Yeşilli', 47, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (653, 2088, N'Artuklu', 47, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (654, 1197, N'Bodrum', 48, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (655, 1266, N'Datça', 48, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (656, 1331, N'Fethiye', 48, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (657, 1488, N'Köyceğiz', 48, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (658, 1517, N'Marmaris', 48, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (659, 1528, N'Milas', 48, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (660, 1695, N'Ula', 48, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (661, 1719, N'Yatağan', 48, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (662, 1742, N'Dalaman', 48, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (663, 1831, N'Ortaca', 48, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (664, 1958, N'Kavaklıdere', 48, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (665, 2089, N'Menteşe', 48, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (666, 2090, N'Seydikemer', 48, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (667, 1213, N'Bulanık', 49, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (668, 1510, N'Malazgirt', 49, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (669, 1534, N'Merkez', 49, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (670, 1711, N'Varto', 49, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (671, 1801, N'Hasköy', 49, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.3966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (672, 1964, N'Korkut', 49, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (673, 1155, N'Avanos', 50, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (674, 1274, N'Derinkuyu', 50, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (675, 1367, N'Gülşehir', 50, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (676, 1374, N'Hacıbektaş', 50, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (677, 1485, N'Kozaklı', 50, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (678, 1543, N'Merkez', 50, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (679, 1707, N'Ürgüp', 50, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (680, 1749, N'Acıgöl', 50, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (681, 1201, N'Bor', 51, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (682, 1225, N'Çamardı', 51, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (683, 1544, N'Merkez', 51, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (684, 1700, N'Ulukışla', 51, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (685, 1876, N'Altunhisar', 51, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (686, 1904, N'Çiftlik', 51, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (687, 1119, N'Akkuş', 52, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (688, 1158, N'Aybastı', 52, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (689, 1328, N'Fatsa', 52, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (690, 1358, N'Gölköy', 52, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (691, 1482, N'Korgan', 52, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (692, 1493, N'Kumru', 52, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (693, 1525, N'Mesudiye', 52, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (694, 1573, N'Perşembe', 52, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (695, 1696, N'Ulubey', 52, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (696, 1706, N'Ünye', 52, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (697, 1795, N'Gülyalı', 52, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (698, 1797, N'Gürgentepe', 52, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (699, 1891, N'Çamaş', 52, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (700, 1897, N'Çatalpınar', 52, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (701, 1900, N'Çaybaşı', 52, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (702, 1947, N'İkizce', 52, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (703, 1950, N'Kabadüz', 52, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (704, 1951, N'Kabataş', 52, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (705, 2103, N'Altınordu', 52, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (706, 1146, N'Ardeşen', 53, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (707, 1228, N'Çamlıhemşin', 53, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (708, 1241, N'Çayeli', 53, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (709, 1332, N'Fındıklı', 53, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (710, 1405, N'İkizdere', 53, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (711, 1428, N'Kalkandere', 53, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (712, 1569, N'Pazar', 53, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (713, 1586, N'Merkez', 53, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.4966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (714, 1796, N'Güneysu', 53, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (715, 1908, N'Derepazarı', 53, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (716, 1943, N'Hemşin', 53, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (717, 1949, N'İyidere', 53, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (718, 1123, N'Akyazı', 54, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (719, 1351, N'Geyve', 54, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (720, 1391, N'Hendek', 54, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (721, 1442, N'Karasu', 54, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (722, 1453, N'Kaynarca', 54, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (723, 1595, N'Sapanca', 54, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (724, 1818, N'Kocaali', 54, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (725, 1833, N'Pamukova', 54, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (726, 1847, N'Taraklı', 54, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (727, 1925, N'Ferizli', 54, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (728, 1955, N'Karapürçek', 54, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (729, 1986, N'Söğütlü', 54, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (730, 2068, N'Adapazarı', 54, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (731, 2069, N'Arifiye', 54, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (732, 2070, N'Erenler', 54, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (733, 2071, N'Serdivan', 54, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (734, 1125, N'Alaçam', 55, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (735, 1164, N'Bafra', 55, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (736, 1234, N'Çarşamba', 55, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (737, 1386, N'Havza', 55, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (738, 1452, N'Kavak', 55, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (739, 1501, N'Ladik', 55, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (740, 1676, N'Terme', 55, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (741, 1712, N'Vezirköprü', 55, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (742, 1763, N'Asarcık', 55, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (743, 1830, N'19 Mayıs', 55, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (744, 1838, N'Salıpazarı', 55, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (745, 1849, N'Tekkeköy', 55, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (746, 1879, N'Ayvacık', 55, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (747, 1993, N'Yakakent', 55, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (748, 2072, N'Atakum', 55, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (749, 2073, N'Canik', 55, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (750, 2074, N'İlkadım', 55, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (751, 1179, N'Baykan', 56, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (752, 1317, N'Eruh', 56, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (753, 1495, N'Kurtalan', 56, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (754, 1575, N'Pervari', 56, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (755, 1620, N'Merkez', 56, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (756, 1662, N'Şirvan', 56, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.5966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (757, 1878, N'Tillo', 56, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (758, 1156, N'Ayancık', 57, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (759, 1204, N'Boyabat', 57, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (760, 1290, N'Durağan', 57, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (761, 1314, N'Erfelek', 57, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (762, 1349, N'Gerze', 57, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (763, 1627, N'Merkez', 57, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (764, 1693, N'Türkeli', 57, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (765, 1910, N'Dikmen', 57, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (766, 1981, N'Saraydüzü', 57, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (767, 1282, N'Divriği', 58, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (768, 1342, N'Gemerek', 58, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (769, 1373, N'Gürün', 58, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (770, 1376, N'Hafik', 58, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (771, 1407, N'İmranlı', 58, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (772, 1431, N'Kangal', 58, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (773, 1484, N'Koyulhisar', 58, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (774, 1628, N'Merkez', 58, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (775, 1646, N'Suşehri', 58, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (776, 1650, N'Şarkışla', 58, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (777, 1731, N'Yıldızeli', 58, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (778, 1738, N'Zara', 58, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (779, 1870, N'Akıncılar', 58, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (780, 1875, N'Altınyayla', 58, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (781, 1913, N'Doğanşar', 58, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (782, 1927, N'Gölova', 58, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (783, 1991, N'Ulaş', 58, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (784, 1250, N'Çerkezköy', 59, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (785, 1258, N'Çorlu', 59, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (786, 1388, N'Hayrabolu', 59, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (787, 1511, N'Malkara', 59, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (788, 1538, N'Muratlı', 59, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (789, 1596, N'Saray', 59, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (790, 1652, N'Şarköy', 59, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (791, 1825, N'Marmaraereğlisi', 59, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (792, 2094, N'Ergene', 59, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (793, 2096, N'Süleymanpaşa', 59, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (794, 1129, N'Almus', 60, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (795, 1151, N'Artova', 60, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (796, 1308, N'Erbaa', 60, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (797, 1545, N'Niksar', 60, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (798, 1584, N'Reşadiye', 60, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (799, 1679, N'Merkez', 60, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.6966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (800, 1690, N'Turhal', 60, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (801, 1740, N'Zile', 60, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (802, 1834, N'Pazar', 60, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (803, 1858, N'Yeşilyurt', 60, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (804, 1883, N'Başçiftlik', 60, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (805, 1987, N'Sulusaray', 60, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (806, 1113, N'Akçaabat', 61, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (807, 1141, N'Araklı', 61, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (808, 1150, N'Arsin', 61, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (809, 1244, N'Çaykara', 61, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (810, 1507, N'Maçka', 61, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (811, 1548, N'Of', 61, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (812, 1647, N'Sürmene', 61, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (813, 1681, N'Tonya', 61, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (814, 1709, N'Vakfıkebir', 61, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (815, 1732, N'Yomra', 61, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (816, 1775, N'Beşikdüzü', 61, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (817, 1842, N'Şalpazarı', 61, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (818, 1896, N'Çarşıbaşı', 61, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (819, 1909, N'Dernekpazarı', 61, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (820, 1917, N'Düzköy', 61, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (821, 1942, N'Hayrat', 61, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (822, 1966, N'Köprübaşı', 61, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (823, 2097, N'Ortahisar', 61, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (824, 1247, N'Çemişgezek', 62, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (825, 1397, N'Hozat', 62, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (826, 1518, N'Mazgirt', 62, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (827, 1541, N'Nazımiye', 62, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (828, 1562, N'Ovacık', 62, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (829, 1574, N'Pertek', 62, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (830, 1581, N'Pülümür', 62, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (831, 1688, N'Merkez', 62, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (832, 1115, N'Akçakale', 63, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (833, 1194, N'Birecik', 63, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (834, 1209, N'Bozova', 63, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (835, 1220, N'Ceylanpınar', 63, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (836, 1378, N'Halfeti', 63, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (837, 1393, N'Hilvan', 63, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (838, 1630, N'Siverek', 63, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (839, 1643, N'Suruç', 63, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (840, 1713, N'Viranşehir', 63, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.7966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (841, 1800, N'Harran', 63, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (842, 2091, N'Eyyübiye', 63, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (843, 2092, N'Haliliye', 63, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (844, 2093, N'Karaköprü', 63, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (845, 1170, N'Banaz', 64, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (846, 1323, N'Eşme', 64, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (847, 1436, N'Karahallı', 64, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (848, 1629, N'Sivaslı', 64, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (849, 1697, N'Ulubey', 64, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (850, 1704, N'Merkez', 64, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (851, 1175, N'Başkale', 65, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (852, 1236, N'Çatak', 65, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (853, 1309, N'Erciş', 65, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (854, 1350, N'Gevaş', 65, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (855, 1372, N'Gürpınar', 65, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (856, 1533, N'Muradiye', 65, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (857, 1565, N'Özalp', 65, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (858, 1770, N'Bahçesaray', 65, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (859, 1786, N'Çaldıran', 65, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (860, 1918, N'Edremit', 65, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (861, 1980, N'Saray', 65, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (862, 2098, N'İpekyolu', 65, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (863, 2099, N'Tuşba', 65, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (864, 1117, N'Akdağmadeni', 66, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (865, 1198, N'Boğazlıyan', 66, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (866, 1242, N'Çayıralan', 66, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (867, 1245, N'Çekerek', 66, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (868, 1602, N'Sarıkaya', 66, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (869, 1635, N'Sorgun', 66, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (870, 1655, N'Şefaatli', 66, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (871, 1726, N'Yerköy', 66, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (872, 1733, N'Merkez', 66, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (873, 1877, N'Aydıncık', 66, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (874, 1895, N'Çandır', 66, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (875, 1952, N'Kadışehri', 66, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (876, 1982, N'Saraykent', 66, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (877, 1998, N'Yenifakılı', 66, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (878, 1240, N'Çaycuma', 67, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (879, 1276, N'Devrek', 67, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (880, 1313, N'Ereğli', 67, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (881, 1741, N'Merkez', 67, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (882, 1758, N'Alaplı', 67, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.8966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (883, 1926, N'Gökçebey', 67, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (884, 1120, N'Merkez', 68, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (885, 1557, N'Ortaköy', 68, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (886, 1860, N'Ağaçören', 68, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (887, 1861, N'Güzelyurt', 68, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (888, 1866, N'Sarıyahşi', 68, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (889, 1921, N'Eskil', 68, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (890, 1932, N'Gülağaç', 68, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (891, 1176, N'Merkez', 69, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (892, 1767, N'Aydıntepe', 69, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (893, 1788, N'Demirözü', 69, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (894, 1316, N'Ermenek', 70, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (895, 1439, N'Merkez', 70, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (896, 1768, N'Ayrancı', 70, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (897, 1862, N'Kazımkarabekir', 70, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (898, 1884, N'Başyayla', 70, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (899, 1983, N'Sarıveliler', 70, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (900, 1268, N'Delice', 71, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (901, 1463, N'Keskin', 71, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (902, 1469, N'Merkez', 71, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (903, 1638, N'Sulakyurt', 71, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (904, 1880, N'Bahşili', 71, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (905, 1882, N'Balışeyh', 71, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (906, 1901, N'Çelebi', 71, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (907, 1954, N'Karakeçili', 71, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (908, 1992, N'Yahşihan', 71, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (909, 1174, N'Merkez', 72, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (910, 1184, N'Beşiri', 72, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (911, 1345, N'Gercüş', 72, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (912, 1487, N'Kozluk', 72, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (913, 1607, N'Sason', 72, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (914, 1941, N'Hasankeyf', 72, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (915, 1189, N'Beytüşşebap', 73, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (916, 1223, N'Cizre', 73, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (917, 1403, N'İdil', 73, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (918, 1623, N'Silopi', 73, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (919, 1661, N'Merkez', 73, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (920, 1698, N'Uludere', 73, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (921, 1931, N'Güçlükonak', 73, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (922, 1172, N'Merkez', 74, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (923, 1496, N'Kurucaşile', 74, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (924, 1701, N'Ulus', 74, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (925, 1761, N'Amasra', 74, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:29.9966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (926, 1144, N'Merkez', 75, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (927, 1252, N'Çıldır', 75, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (928, 1356, N'Göle', 75, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (929, 1380, N'Hanak', 75, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (930, 1579, N'Posof', 75, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (931, 2008, N'Damal', 75, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (932, 1142, N'Aralık', 76, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (933, 1398, N'Merkez', 76, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (934, 1692, N'Tuzluca', 76, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (935, 2011, N'Karakoyunlu', 76, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (936, 1716, N'Merkez', 77, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (937, 2019, N'Altınova', 77, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (938, 2020, N'Armutlu', 77, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (939, 2021, N'Çınarcık', 77, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (940, 2022, N'Çiftlikköy', 77, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (941, 2026, N'Termal', 77, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (942, 1296, N'Eflani', 78, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (943, 1321, N'Eskipazar', 78, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (944, 1433, N'Merkez', 78, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (945, 1561, N'Ovacık', 78, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (946, 1587, N'Safranbolu', 78, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (947, 1856, N'Yenice', 78, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (948, 1476, N'Merkez', 79, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (949, 2023, N'Elbeyli', 79, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (950, 2024, N'Musabeyli', 79, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (951, 2025, N'Polateli', 79, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (952, 1165, N'Bahçe', 80, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (953, 1423, N'Kadirli', 80, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (954, 1560, N'Merkez', 80, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (955, 1743, N'Düziçi', 80, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (956, 2027, N'Hasanbeyli', 80, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (957, 2028, N'Sumbas', 80, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (958, 2029, N'Toprakkale', 80, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (959, 1116, N'Akçakoca', 81, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (960, 1292, N'Merkez', 81, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (961, 1730, N'Yığılca', 81, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (962, 1784, N'Cumayeri', 81, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (963, 1794, N'Gölyaka', 81, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (964, 1905, N'Çilimli', 81, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (965, 2017, N'Gümüşova', 81, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[District] ([DistrictID], [DistrictCode], [DistrictName], [CityID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (966, 2031, N'Kaynaşlı', 81, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0933333' AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[District] OFF
GO
SET IDENTITY_INSERT [dbo].[ContractorType] ON 
GO
INSERT [dbo].[ContractorType] ([ContractorTypeID], [ContractorTypeTitle], [ContractorTypeDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, N'Yüklenici Tipi Deneme', N'dfg', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T14:11:33.1974478' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ContractorType] ([ContractorTypeID], [ContractorTypeTitle], [ContractorTypeDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, N'Yüklenici Tipi 2', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T14:11:36.1471578' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ContractorType] ([ContractorTypeID], [ContractorTypeTitle], [ContractorTypeDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (3, N'Yüklenici Tipi 1', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T14:11:40.0292366' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ContractorType] ([ContractorTypeID], [ContractorTypeTitle], [ContractorTypeDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (4, N'Yüklenici Tipi 3', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T14:11:42.8570548' AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[ContractorType] OFF
GO
SET IDENTITY_INSERT [dbo].[Contractor] ON 
GO
INSERT [dbo].[Contractor] ([ContractorID], [Title], [TaxCode], [TaxOffice], [CityID], [DistrictID], [ContractorTypeID], [UserID], [PhoneNumber], [Description], [Address], [Email], [Website], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, N'Deneme ', N'34324', N'657', 3, 27, 2, (SELECT TOP 1 [Id] FROM [dbo].[User]), N'(555) 555 55 55', N'sdadfsd', N'dsfsdf', N'deneme@deneme.com.tr', N'www.ornek.com.tr', CAST(N'2021-08-23T14:11:58.3201397' AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Contractor] OFF
GO
SET IDENTITY_INSERT [dbo].[Department] ON 
GO
INSERT [dbo].[Department] ([DepartmentID], [DepartmentTitle], [ParentDepartmentID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, N'Altyapı Projeler Müdürlüğü', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Department] ([DepartmentID], [DepartmentTitle], [ParentDepartmentID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, N'Kentsel Tasarım Müdürlüğü', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Department] ([DepartmentID], [DepartmentTitle], [ParentDepartmentID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (3, N'Proje Sorumlusu Müdürlük', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Department] ([DepartmentID], [DepartmentTitle], [ParentDepartmentID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (4, N'Üstyapı Projeler Müdürlüğü', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5833333' AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Department] OFF
GO
SET IDENTITY_INSERT [dbo].[JobTitle] ON 
GO
INSERT [dbo].[JobTitle] ([JobTitleID], [Title], [JobDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, N'Deneme ', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:25:15.2815984' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[JobTitle] ([JobTitleID], [Title], [JobDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, N'Deneme 2', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:25:21.9291601' AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[JobTitle] OFF
GO
SET IDENTITY_INSERT [dbo].[Person] ON 
GO
INSERT [dbo].[Person] ([PersonID], [PersonName], [PersonSurname], [PersonPhone], [PersonEmail], [isInternal], [JobTitleID], [DepartmentID], [ContractorID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, N'Can', N'cerrahoğlu', N'(545) 445 45 45', N'ustuncem7@gmail.com', 1, 1, NULL, NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:25:38.5619652' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Person] ([PersonID], [PersonName], [PersonSurname], [PersonPhone], [PersonEmail], [isInternal], [JobTitleID], [DepartmentID], [ContractorID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, N'Şafak', N'Basmacı', N'(342) 424 23 42', N'ustuncem7@gmail.com', 1, 1, 3, NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:25:51.4886189' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Person] ([PersonID], [PersonName], [PersonSurname], [PersonPhone], [PersonEmail], [isInternal], [JobTitleID], [DepartmentID], [ContractorID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (3, N'Cem', N'Deneme', N'(342) 424 23 42', N'email@email.com', 0, NULL, NULL, NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:26:05.0972976' AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Person] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectImportance] ON 
GO
INSERT [dbo].[ProjectImportance] ([ProjectImportanceID], [ProjectImportanceTitle], [ProjectImportanceDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, N'Vizyon', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:24:03.1029507' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ProjectImportance] ([ProjectImportanceID], [ProjectImportanceTitle], [ProjectImportanceDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, N'Yatırım', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:24:05.6477795' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ProjectImportance] ([ProjectImportanceID], [ProjectImportanceTitle], [ProjectImportanceDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (3, N'Bilmem Ne', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:24:08.9717906' AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[ProjectImportance] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectStatus] ON 
GO
INSERT [dbo].[ProjectStatus] ([ProjectStatusID], [ProjectStatusTitle], [ProjectStatusDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, N'Devam Ediyor', N'Devam Ediyor', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ProjectStatus] ([ProjectStatusID], [ProjectStatusTitle], [ProjectStatusDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, N'Durduruldu', N'Durduruldu', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ProjectStatus] ([ProjectStatusID], [ProjectStatusTitle], [ProjectStatusDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (3, N'Hazırlık Aşamasında', N'Hazırlık Aşamasında', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ProjectStatus] ([ProjectStatusID], [ProjectStatusTitle], [ProjectStatusDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (4, N'İptal', N'İptal', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ProjectStatus] ([ProjectStatusID], [ProjectStatusTitle], [ProjectStatusDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (5, N'İşin Durumu', N'İşin Durumu', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ProjectStatus] ([ProjectStatusID], [ProjectStatusTitle], [ProjectStatusDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (6, N'Proje Onaylandı', N'Proje Onaylandı', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ProjectStatus] ([ProjectStatusID], [ProjectStatusTitle], [ProjectStatusDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (7, N'Projesi Biten (Diğer Yapımcı Birimlere Giden)', N'Projesi Biten (Diğer Yapımcı Birimlere Giden)', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ProjectStatus] ([ProjectStatusID], [ProjectStatusTitle], [ProjectStatusDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (8, N'Projesi Biten (Yapım Aşamasına Geçmeyen)', N'Projesi Biten (Yapım Aşamasına Geçmeyen)', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ProjectStatus] ([ProjectStatusID], [ProjectStatusTitle], [ProjectStatusDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (9, N'Yapımcı Birim Onayı Bekleniyor', N'Yapımcı Birim Onayı Bekleniyor', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6133333' AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[ProjectStatus] OFF
GO
SET IDENTITY_INSERT [dbo].[ServiceArea] ON 
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, N'Çevre', N'Çevre', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, N'Deniz ve Kıyı Yapıları Projeleri', N'Deniz ve Kıyı Yapıları Projeleri', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (3, N'Hizmet Yapısı Projeleri', N'Hizmet Yapısı Projeleri', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (4, N'Kent Estetiği Projeleri', N'Kent Estetiği Projeleri', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (5, N'Kültür Yapıları', N'Kültür Yapıları', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (6, N'Spor Yapıları', N'Spor Yapıları', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (7, N'Temel Alan', N'Temel Alan', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (8, N'Ulaşım Projeleri', N'Ulaşım Projeleri', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.0966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (9, N'Atık Ve Arıtma Tesisleri', N'Atık Ve Arıtma Tesisleri', 1, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (10, N'Çevre', N'Çevre', 1, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (11, N'Dini Tesisler', N'Dini Tesisler', 3, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (12, N'Festival Ve Kongre', N'Festival Ve Kongre', 5, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (13, N'İdari Faaliyetler', N'İdari Faaliyetler', 3, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (14, N'İdari Tesisler', N'İdari Tesisler', 3, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (15, N'Kavşak Ve Yol Projeleri', N'Kavşak Ve Yol Projeleri', 8, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (16, N'Kentsel Tasarım', N'Kentsel Tasarım', 4, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (17, N'Kıyı Yapıları', N'Kıyı Yapıları', 2, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (18, N'Kültür Tesisleri', N'Kültür Tesisleri', 5, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (19, N'Lojistik Tesisler', N'Lojistik Te

sler', 3, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (20, N'Otogar', N'Otogar', 8, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (21, N'Otopark', N'Otopark', 8, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (22, N'Raylı 

stemler', N'Raylı 
stemler', 8, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (23, N'Rehabilitasyon', N'Rehabilitasyon', 4, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (24, N'Restorasyon', N'Restorasyon', 5, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (25, N'Sağlık Yapıları', N'Sağlık Yapıları', 3, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (26, N'Sosyal Destek Yapıları', N'Sosyal Destek Yapıları', 3, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (27, N'Sosyal Donatı Alanları', N'Sosyal Donatı Alanları', 3, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (28, N'Spor', N'Spor', 6, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (29, N'Spor Komplek

', N'Spor Komplek

', 6, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (30, N'Tematik Yapılar', N'Tematik Yapılar', 5, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (31, N'Yat Limanı', N'Yat Limanı', 2, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (32, N'Yaya Geçit Projeleri', N'Yaya Geçit Projeleri', 8, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (33, N'Yeşil Alan Ve Rekreasyon Projeleri', N'Yeşil Alan Ve Rekreasyon Projeleri', 1, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (34, N'Yurtlar', N'Yurtlar', 3, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (35, N'Açık Hava Tiyatrosu', N'Açık Hava Tiyatrosu', 18, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (36, N'Açık Otopark', N'Açık Otopark', 21, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (37, N'Açık Spor Te


sleri', N'Açık Spor Te

sleri', 28, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (38, N'Anne Çocuk Sağlığı Aile Plan Merkezleri', N'Anne Çocuk Sağlığı Aile Plan Merkezleri', 25, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (39, N'Anroşman düzenleme', N'Anroşman düzenleme', 17, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (40, N'Antrepo Depo', N'Antrepo Depo', 19, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (41, N'Araştırma/Raporlama', N'Araştırma/Raporlama', 13, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (42, N'Askeri Lojmanlar', N'Askeri Lojmanlar', 14, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (43, N'Balıkçı Barınağı', N'Balıkçı Barınağı', 17, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (44, N'Balıkçılar Çarşısı', N'Balıkçılar Çarşısı', 27, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (45, N'Bilim Merkezi', N'Bilim Merkezi', 18, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (46, N'Bina Cepheleri', N'Bina Cepheleri', 23, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.1966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (47, N'Bina Cepheleri ve Zemin Düzenlemeleri', N'Bina Cepheleri ve Zemin Düzenlemeleri', 23, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (48, N'Bölge Parkı', N'Bölge Parkı', 33, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (49, N'Botanik Parkı', N'Botanik Parkı', 33, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (50, N'Cadde (Bulvar) Düzenleme', N'Cadde (Bulvar) Düzenleme', 23, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (51, N'Cami Yapımı', N'Cami Yapımı', 11, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (52, N'Cep Otopark', N'Cep Otopark', 21, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (53, N'Danışmanlık/Müşavirlik', N'Danışmanlık/Müşavirlik', 13, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (54, N'Dere Islahı', N'Dere Islahı', 1, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (55, N'Diğer İdari Kurumlar', N'Diğer İdari Kurumlar', 14, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (56, N'Diğer Spor Tesis', N'Diğer Spor Te

s', 28, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (57, N'Eğitim Binaları', N'Eğitim Binaları', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (58, N'Ekolojik Koridor düzenleme', N'Ekolojik Koridor düzenleme', 33, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (59, N'Ekolojik Tarım', N'Ekolojik Tarım', 33, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (60, N'Engelli Eğitim Binası', N'Engelli Eğitim Binası', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (61, N'Engelli Kampı', N'Engelli Kampı', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (62, N'Evde Sağlık Merkezleri', N'Evde Sağlık Merkezleri', 25, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (63, N'Evlendirme Daire


(Nikah Salonu)', N'Evlendirme Daire
(Nikah Salonu)', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (64, N'Festival Alanları', N'Festival Alanları', 12, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (65, N'Fizik Tedavi Merkezi', N'Fizik Tedavi Merkezi', 25, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (66, N'Fuar Alanları', N'Fuar Alanları', 12, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (67, N'Futbol Sahası', N'Futbol Sahası', 28, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (68, N'Ga

lhane', N'Ga

lhane', 14, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (69, N'Gazhane Restorasyonu', N'Gazhane Restorasyonu', 24, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (70, N'Gençlik Merkezi', N'Gençlik Merkezi', 18, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (71, N'Gölet', N'Gölet', 1, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (72, N'Güçsüzler Evi', N'Güçsüzler Evi', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (73, N'Gürültü Bariyerleri', N'Gürültü Bariyerleri', 1, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (74, N'Güvenlik Binası', N'Güvenlik Binası', 14, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (75, N'Halı Saha', N'Halı Saha', 28, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (76, N'Hareket Amirliği', N'Hareket Amirliği', 14, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (77, N'Hayvan Barınağı', N'Hayvan Barınağı', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (78, N'Hayvan Yetiştiriciliği-Be

', N'Hayvan Yetiştiriciliği-Be

', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (79, N'Hayvanat Bahçe


', N'Hayvanat Bahçe

', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (80, N'Heyelan Önleme', N'Heyelan Önleme', 15, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (81, N'Heykel', N'Heykel', 30, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (82, N'Hizmet Binaları', N'Hizmet Binaları', 14, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (83, N'Hobi Bahçeleri', N'Hobi Bahçeleri', 33, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (84, N'Huzurevi', N'Huzurevi', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (85, N'İbadethane', N'İbadethane', 11, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.2966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (86, N'İBB Kurum Binası', N'İBB Kurum Binası', 14, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (87, N'İdari Binalar', N'İdari Binalar', 14, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (89, N'İlaçlama Merkezi', N'İlaçlama Merkezi', 25, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (90, N'İnovasyon ve Teknoloji Merkezi', N'İnovasyon ve Teknoloji Merkezi', 14, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (91, N'İskele', N'İskele', 17, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (92, N'İskele Binası', N'İskele Binası', 17, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (93, N'İSMEK Binaları', N'İSMEK Binaları', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (94, N'İstinat Duvarı', N'İstinat Duvarı', 15, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (95, N'İtfaiye Te

sleri', N'İtfaiye Te

sleri', 14, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (96, N'Kadın Koordinasyon Merkezi', N'Kadın Koordinasyon Merkezi', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (97, N'Kadın Sığınma Evi', N'Kadın Sığınma Evi', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (98, N'Kamp Yapıları ve Alanları', N'Kamp Yapıları ve Alanları', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (99, N'Kamu Lojmanları', N'Kamu Lojmanları', 14, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (100, N'Kamu Yurtları', N'Kamu Yurtları', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (101, N'Kapalı Otopark', N'Kapalı Otopark', 21, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (102, N'Kapalı Spor Te

sleri', N'Kapalı Spor Te

sleri', 18, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (103, N'Karakol Binası', N'Karakol Binası', 14, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (104, N'Katı Atık Te

sleri Ve Alanları', N'Katı Atık Te

sleri Ve Alanları', 9, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (105, N'Kavşak Yapımı', N'Kavşak Yapımı', 15, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (106, N'Kent Meydanı ve Yakın Çevre

nin Düzenlenme

', N'Kent Meydanı ve Yakın Çevre
nin Düzenlenme
', 23, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (107, N'Kent Mobilyası Tasarımı', N'Kent Mobilyası Tasarımı', 16, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (108, N'Kent Ormanı', N'Kent Ormanı', 33, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (109, N'Kentsel Tasarım Projeleri', N'Kentsel Tasarım Projeleri', 16, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (110, N'Kıraathane', N'Kıraathane', 18, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (111, N'Kıyı Tahkimatı', N'Kıyı Tahkimatı', 17, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (112, N'Kıyı Yapı Elemanı', N'Kıyı Yapı Elemanı', 17, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (113, N'Konferans Salonu', N'Konferans Salonu', 12, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (114, N'Kongre Merkezi', N'Kongre Merkezi', 12, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (115, N'Konser Salonu', N'Konser Salonu', 18, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (116, N'Konut', N'Konut', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (117, N'Köprü ve Viyadük Güçlendirme', N'Köprü ve Viyadük Güçlendirme', 15, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (118, N'Köprü ve Viyadük Yapımı', N'Köprü ve Viyadük Yapımı', 15, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (119, N'Koru Düzenleme


', N'Koru Düzenleme

', 1, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (120, N'Köy Evi', N'Köy Evi', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (121, N'Kreş', N'Kreş', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (122, N'Kronman düzenleme', N'Kronman düzenleme', 17, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (123, N'Kültür Komplek


', N'Kültür Komplek
', 18, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (124, N'Kültür Te



', N'Kültür Te





', 18, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.3966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (125, N'Kuran Kursu', N'Kuran Kursu', 11, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (126, N'Kurban Ke


m Alanı', N'Kurban Ke

m Alanı', 27, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (127, N'Kurvaziyer Limanı', N'Kurvaziyer Limanı', 31, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (128, N'Kütüphane', N'Kütüphane', 18, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (129, N'Mahalle parkı', N'Mahalle parkı', 33, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (130, N'Marina', N'Marina', 31, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (131, N'Metro', N'Metro', 22, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (132, N'Mezarlığa Ait Bina', N'Mezarlığa Ait Bina', 14, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (133, N'Mezarlıklar', N'Mezarlıklar', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (134, N'Mezbaha', N'Mezbaha', 27, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (135, N'Millet Bahçe


', N'Millet Bahçe


', 33, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (136, N'Müze', N'Müze', 18, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (137, N'Nakliye Ambarı', N'Nakliye Ambarı', 19, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (138, N'Nizamiye Binası', N'Nizamiye Binası', 14, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (139, N'Okul Kapalı Spor Salonları', N'Okul Kapalı Spor Salonları', 28, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (140, N'Okul Yapıları', N'Okul Yapıları', 14, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (141, N'Otogar', N'Otogar', 20, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (142, N'Özel Yurtlar', N'Özel Yurtlar', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (143, N'Parlayıcı Patlayıcı Madde Deposu', N'Parlayıcı Patlayıcı Madde Deposu', 19, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (144, N'Peyzaj ve Bahçe Düzenleme


', N'Peyzaj ve Bahçe Düzenleme

', 33, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (145, N'Piknik Ve Me

re Alanları', N'Piknik Ve Me

re Alanları', 33, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (146, N'Polis Lojmanları', N'Polis Lojmanları', 14, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (147, N'Rehabilitasyon Merkezi', N'Rehabilitasyon Merkezi', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (148, N'Rıhtım düzenleme', N'Rıhtım düzenleme', 17, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (149, N'Sahil düzenleme', N'Sahil düzenleme', 17, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (150, N'Sahil düzenleme (rekreatif amaçlı)', N'Sahil düzenleme (rekreatif amaçlı)', 33, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (151, N'Sahil Yolu düzenleme', N'Sahil Yolu düzenleme', 17, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (152, N'Sanatçı Yaşam Evi', N'Sanatçı Yaşam Evi', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (153, N'Sebze Meyve Hali', N'Sebze Meyve Hali', 14, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (154, N'Şehir Parkı', N'Şehir Parkı', 33, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (155, N'Semt Konağı', N'Semt Konağı', 18, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (156, N'Semt Parkı', N'Semt Parkı', 33, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (157, N'Semt Pazarı', N'Semt Pazarı', 27, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (160, N'Sosyal Te



sler', N'Sosyal Te
sler', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (161, N'Spor Komplek

', N'Spor Komplek

', 28, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (162, N'Spor Kulübü', N'Spor Kulübü', 28, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (163, N'Spor Salonu', N'Spor Salonu', 28, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.4966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (164, N'Stadyum', N'Stadyum', 28, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (165, N'Su Deposu', N'Su Deposu', 19, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (166, N'Su Sporları Parkı', N'Su Sporları Parkı', 28, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (167, N'Su Ürünleri Hali', N'Su Ürünleri Hali', 19, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (168, N'Sürücü Eğitim Merkezi', N'Sürücü Eğitim Merkezi', 26, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (169, N'Tanıtım/Medya', N'Tanıtım/Medya', 13, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (170, N'Tekne parklar', N'Tekne parklar', 31, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5166667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (171, N'Tema Park', N'Tema Park', 33, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (172, N'Tenis Kortu', N'Tenis Kortu', 29, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5200000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (173, N'Tescilli Yapı Restorasyonu', N'Tescilli Yapı Restorasyonu', 24, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5233333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (174, N'Tiyatro Salonu', N'Tiyatro Salonu', 18, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5266667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (175, N'Tır Parkı', N'Tır Parkı', 21, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (176, N'Toplum Sağlık Merkezleri', N'Toplum Sağlık Merkezleri', 25, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5300000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (177, N'Tramvay', N'Tramvay', 22, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5333333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (178, N'Transfer Merkezi', N'Transfer Merkezi', 21, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5366667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (179, N'Tribün', N'Tribün', 28, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5400000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (180, N'Tünel', N'Tünel', 15, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5433333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (181, N'Üniver


te Yurtları', N'Üniver

te Yurtları', 34, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (182, N'Üst Geçit Güçlendirme Projeleri', N'Üst Geçit Güçlendirme Projeleri', 32, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5466667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (183, N'Üst Örtü (membran/çelik vb)', N'Üst Örtü (membran/çelik vb)', 23, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5500000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (184, N'WC', N'WC', 27, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5533333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (185, N'Yaya Alt Geçit Projeleri', N'Yaya Alt Geçit Projeleri', 32, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (186, N'Yaya Geçit Projeleri', N'Yaya Geçit Projeleri', 32, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5566667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (187, N'Yaya Geçitleri Bakım Onarım Projeleri', N'Yaya Geçitleri Bakım Onarım Projeleri', 32, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5600000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (188, N'Yaya Üst Geçit Projeleri', N'Yaya Üst Geçit Projeleri', 32, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5633333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (189, N'Yayalaştırma Projeleri', N'Yayalaştırma Projeleri', 23, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5666667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (190, N'Yol Bakımı ve Düzenleme', N'Yol Bakımı ve Düzenleme', 15, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5700000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (192, N'Yol Yapımı', N'Yol Yapımı', 15, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5733333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (193, N'Yükleme İstasyonu', N'Yükleme İstasyonu', 19, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5766667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (194, N'Yüzen Otopark', N'Yüzen Otopark', 21, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (195, N'Yüzme Havuzu', N'Yüzme Havuzu', 29, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5800000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ServiceArea] ([ServiceAreaID], [ServiceAreaTitle], [ServiceAreaDescription], [ParentServiceAreaID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (196, N'Zemin Düzenlemeleri', N'Zemin Düzenlemeleri', 16, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5833333' AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[ServiceArea] OFF
GO
SET IDENTITY_INSERT [dbo].[Project] ON 
GO
INSERT [dbo].[Project] ([ProjectID], [ProjectTitle], [ProjectCode], [ProjectIBBCode], [RequestingDepartmentID], [Respon

bleDepartmentID], [ProjectOwnerPersonID], [ProjectServiceAreaID], [ProjectImportanceID], [ProjectStatu

D], [ProjectStatusDescription], [ProjectStatusDescriptionDate], [UserID], [CreationDate], [UpdateDate], [DeletionDate], [EstimatedProjectCost]) VALUES (1528, N'IBB Proje Portal İlk Deneme Proje

', NULL, N'234234234', 2, 3, 2, 4, 1, 6, N'24234', CAST(N'2021-08-21T00:00:00.0000000' AS DateTime2), (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:26:36.0000000' AS DateTime2), CAST(N'2021-08-25T21:04:11.7722656' AS DateTime2), NULL, CAST(345345.45 AS Decimal(18, 2)))
GO
INSERT [dbo].[Project] ([ProjectID], [ProjectTitle], [ProjectCode], [ProjectIBBCode], [RequestingDepartmentID], [Respon

bleDepartmentID], [ProjectOwnerPersonID], [ProjectServiceAreaID], [ProjectImportanceID], [ProjectStatu

D], [ProjectStatusDescription], [ProjectStatusDescriptionDate], [UserID], [CreationDate], [UpdateDate], [DeletionDate], [EstimatedProjectCost]) VALUES (1529, N'2. Deneme', NULL, N'234234234', 1, 2, 2, 4, 3, 6, N'werwr', CAST(N'2021-09-02T00:00:00.0000000' AS DateTime2), (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T14:04:37.5666763' AS DateTime2), NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Project] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectSubfunctionFeature] ON 
GO
INSERT [dbo].[ProjectSubfunctionFeature] ([ProjectSubfunctionFeatureID], [ProjectID], [SubfunctionID], [SubfunctionFeatureID], [SubfunctionFeatureValue], [SubfunctionFeatureValueDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, 1528, 4, 2, N'456456', N'dsfsdf', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T17:00:25.0000000' AS DateTime2), CAST(N'2021-08-23T17:03:46.7886134' AS DateTime2), NULL)
GO
SET IDENTITY_INSERT [dbo].[ProjectSubfunctionFeature] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectZoningPlan] ON 
GO
INSERT [dbo].[ProjectZoningPlan] ([ProjectZoningPlanID], [ProjectID], [ZoningPlanStatu

D1000], [ZoningPlanDate1000], [ZoningPlanStatu
D5000], [ZoningPlanDate5000], [ZoningPlanModificationNeeded], [ZoningPlanModificationReason], [ModificationApprovalDate], [ModificationProposalDate], [ZoningPlanModificationStatusID], [ZoningPlanResponsiblePersonID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, 1528, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:29:13.3247488' AS DateTime2), CAST(N'2021-08-23T14:03:40.7430959' AS DateTime2), NULL)
GO
INSERT [dbo].[ProjectZoningPlan] ([ProjectZoningPlanID], [ProjectID], [ZoningPlanStatusID1000], [ZoningPlanDate1000], [ZoningPlanStatusID5000], [ZoningPlanDate5000], [ZoningPlanModificationNeeded], [ZoningPlanModificationReason], [ModificationApprovalDate], [ModificationProposalDate], [ZoningPlanModificationStatusID], [ZoningPlanResponsiblePersonID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, 1529, NULL, CAST(N'2021-08-14T00:00:00.0000000' AS DateTime2), NULL, CAST(N'2021-08-06T00:00:00.0000000' AS DateTime2), 1, N'dsf', CAST(N'2021-08-12T00:00:00.0000000' AS DateTime2), CAST(N'2021-08-07T00:00:00.0000000' AS DateTime2), NULL, 3, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T14:09:39.7913390' AS DateTime2), CAST(N'2021-08-23T14:13:33.7104062' AS DateTime2), NULL)
GO
SET IDENTITY_INSERT [dbo].[ProjectZoningPlan] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectField] ON 
GO
INSERT [dbo].[ProjectField] ([ProjectFieldID], [ProjectID], [IsProjectInIstanbul], [DistrictID], [ProjectAddress], [ProjectCost], [ProjectArea], [ProjectConstructionArea], [ProjectPaysageArea], [ProjectPaftaAdaParsel], [KML], [ProjectLongitude], [ProjectLatitude], [ProjectPoint], [ProjectLineString], [ProjectPolygon], [coordinates], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, 1528, 1, 421, N'tyuyu', NULL, 345345, 6654, 45345, N'45345', N'<Placemark>
	<name>MUSTAFA KEMAL CADDESİ</name>
	<Style><LineStyle><color>ff0000ff</color></LineStyle><PolyStyle><fill>0</fill></PolyStyle></Style>
	<ExtendedData><SchemaData schemaUrl="#Drawing1_dwg_Polyline">
		<SimpleData name="altitudeMode">clampToGround</SimpleData>
		<SimpleData name="tessellate">1</SimpleData>
		<SimpleData name="EntColor">-1</SimpleData>
		<SimpleData name="LyrFrzn">0</SimpleData>
		<SimpleData name="LyrOn">1</SimpleData>
		<SimpleData name="BlkLinetype"></SimpleData>
		<SimpleData name="RefName"></SimpleData>
		<SimpleData name="Thickness">0</SimpleData>
		<SimpleData name="Entity">LWPolyline</SimpleData>
		<SimpleData name="LyrHandle">274</SimpleData>
		<SimpleData name="BlkLineWt">-1</SimpleData>
		<SimpleData name="Handle">281</SimpleData>
		<SimpleData name="EntLineWt">35</SimpleData>
		<SimpleData name="LTScale">1</SimpleData>
		<SimpleData name="BlkColor">0</SimpleData>
		<SimpleData name="LyrLnType">Continuous</SimpleData>
		<SimpleData name="LyrLock">0</SimpleData>
		<SimpleData name="LyrColor">10</SimpleData>
		<SimpleData name="DocVer">AC1032</SimpleData>
		<SimpleData name="Linetype">Continuous</SimpleData>
		<SimpleData name="DocPath">C:\Users\ilknur.gungormez\Desktop\KMZ ALAN\Drawing1.dwg</SimpleData>
		<SimpleData name="FID">2</SimpleData>
		<SimpleData name="Elevation">0</SimpleData>
		<SimpleData name="LyrVPFrzn">0</SimpleData>
		<SimpleData name="Field_1"></SimpleData>
		<SimpleData name="Layer">metrekare</SimpleData>
		<SimpleData name="Color">10</SimpleData>
		<SimpleData name="ExtZ">1</SimpleData>
		<SimpleData name="ExtY">0</SimpleData>
		<SimpleData name="ExtX">0</SimpleData>
		<SimpleData name="LyrLineWt">53</SimpleData>
		<SimpleData name="LineWt">35</SimpleData>
		<SimpleData name="DocName">Drawing1.dwg</SimpleData>
		<SimpleData name="DocType">DWG</SimpleData>
		<SimpleData name="EntLinetype">Continuous</SimpleData>
	</SchemaData></ExtendedData>
      <LineString><coordinates>28.9539286994772,41.0067721240561 28.9539286987133,41.0067721284497 28.9539497879247,41.0068190491921 28.9540077255278,41.0069234908124 28.9540389298605,41.0069813577457 28.9540704557316,41.0069651415193 28.9541519095541,41.0070743825059 28.9542148961554,41.007053246543 28.9542213867354,41.0070749255275 28.954247664181,41.0072079667155 28.9542031623903,41.0072467247249 28.9539636780162,41.0073003883966 28.9537722585149,41.0073325173579 28.9537642947398,41.0076233794346 28.9537978204856,41.0076503296105 28.9537933948245,41.0077609581652 28.9537556222656,41.0077867343922 28.9537510447407,41.0078769008391 28.9537352165583,41.0081621195678 28.9537724549188,41.0081873349846 28.9537661647834,41.0083225376978 28.9537260205979,41.0083547223863 28.953701973236,41.0088780700498 28.9537351387478,41.0089020563198 28.9531392748067,41.0089155879932 28.9531120978519,41.0089267176451 28.9531378603128,41.0083714372241 28.9531187928942,41.008198271221 28.9531524680432,41.0081677207699 28.9531751011781,41.007775431246 28.9531383231262,41.007742460823 28.9531341709978,41.007633980169 28.9531803063294,41.0076090103576 28.9531915057183,41.0071863843324 28.9531473365357,41.007158613653 28.9531578482978,41.0070327193841 28.9531971408515,41.0070076252816 28.9532105363039,41.0066250143584 28.9531779292126,41.0065981407674 28.9532077755048,41.0065252966073 28.9532198235096,41.0064958916733 28.9532104330288,41.0064090029395 28.9532225287212,41.0063969118123 28.9532541680981,41.0054704708113 28.9532550874565,41.0054435503254 28.9532553302947,41.0054364395756 28.9532453657792,41.0053922130387 28.9532561224152,41.0050927032051 28.9533437353826,41.005062701937 28.953347503181,41.0050669178026 28.9533772351576,41.0050568723311 28.9533383718865,41.0049896454168 28.9533179185037,41.0049542644499 28.9532944274786,41.0049136288141 28.9532906971522,41.0049071759539 28.9532692738266,41.0048757522837 28.9532442853703,41.0047158834085 28.9530658233733,41.0046373800632 28.9530887475493,41.0045962706217 28.9531244956567,41.0045837018943 28.9531713095583,41.0045017133178 28.9530841754704,41.0044057100438 28.9532342642082,41.0041455101167 28.9531505496456,41.0040515451769 28.9532457911366,41.0038865560011 28.953027188568,41.0038158307942 28.9529403532956,41.0038220276152 28.953061771356,41.0036225413863 28.9531694436457,41.0034338399889 28.9532115448058,41.0033836363774 28.9532834192392,41.0032474507668 28.9540326523595,41.0035263786968 28.9540045583706,41.0035884675254 28.9539893901689,41.0036219897994 28.9538982979324,41.0038371516227 28.953896928982,41.0038404002143 28.9538797131796,41.0038846490739 28.9538795906566,41.0038849529215 28.9538794256567,41.0038853460644 28.9538790705319,41.0038861905009 28.9538526225338,41.0039492074097 28.9537573664586,41.0042875865694 28.9537570364925,41.0042913526988 28.9537550853265,41.0043135827445 28.953812239515,41.0043181084997 28.9538484230775,41.0043283417828 28.9538444849655,41.0043537588248 28.9539118375048,41.004366063266 28.9539287138586,41.0043691463515 28.95397919007,41.0043783676681 28.9539162817492,41.0046566644315 28.9539573045258,41.0046617775675 28.9540092275959,41.0046738588337 28.9539543415796,41.0049161056355 28.953911438855,41.0050010682229 28.9539015046431,41.0050165304878 28.9538755210987,41.005076967314 28.9538594434747,41.0051085484484 28.9539233106539,41.0052567321025 28.9540081721607,41.0054479582603 28.9540340250766,41.0054998890263 28.9540987592187,41.0057059931514 28.9541336716097,41.0058417904728 28.9541555244901,41.0058470699562 28.9541206330752,41.0058475937214 28.9540663866331,41.0058494281263 28.9540373980941,41.0058504083961 28.9540377028919,41.0058588402032 28.9540379347539,41.005865254343 28.9539174473461,41.0058693654234 28.9538320270944,41.0059011392828 28.9538324973974,41.0059439253272 28.9538644092579,41.0059698289343 28.953885863876,41.006092354939 28.9538422385024,41.0061145825693 28.9538433943303,41.0062819148894 28.9538314256368,41.0063432496752 28.9538289235528,41.0064859577326 28.953865403373,41.0065179510628 28.9539286994772,41.0067721240561</coordinates></LineString>
  </Placemark>', CAST(41.009813 AS Decimal(9, 6)), CAST(28.953605 AS Decimal(9, 6)), 0xE6100000010C00000000000000000000000000000000, NULL, NULL, N'28.9539286994772,41.0067721240561 28.9539286987133,41.0067721284497 28.9539497879247,41.0068190491921 28.9540077255278,41.0069234908124 28.9540389298605,41.0069813577457 28.9540704557316,41.0069651415193 28.9541519095541,41.0070743825059 28.9542148961554,41.007053246543 28.9542213867354,41.0070749255275 28.954247664181,41.0072079667155 28.9542031623903,41.0072467247249 28.9539636780162,41.0073003883966 28.9537722585149,41.0073325173579 28.9537642947398,41.0076233794346 28.9537978204856,41.0076503296105 28.9537933948245,41.0077609581652 28.9537556222656,41.0077867343922 28.9537510447407,41.0078769008391 28.9537352165583,41.0081621195678 28.9537724549188,41.0081873349846 28.9537661647834,41.0083225376978 28.9537260205979,41.0083547223863 28.953701973236,41.0088780700498 28.9537351387478,41.0089020563198 28.9531392748067,41.0089155879932 28.9531120978519,41.0089267176451 28.9531378603128,41.0083714372241 28.9531187928942,41.008198271221 28.9531524680432,41.0081677207699 28.9531751011781,41.007775431246 28.9531383231262,41.007742460823 28.9531341709978,41.007633980169 28.9531803063294,41.0076090103576 28.9531915057183,41.0071863843324 28.9531473365357,41.007158613653 28.9531578482978,41.0070327193841 28.9531971408515,41.0070076252816 28.9532105363039,41.0066250143584 28.9531779292126,41.0065981407674 28.9532077755048,41.0065252966073 28.9532198235096,41.0064958916733 28.9532104330288,41.0064090029395 28.9532225287212,41.0063969118123 28.9532541680981,41.0054704708113 28.9532550874565,41.0054435503254 28.9532553302947,41.0054364395756 28.9532453657792,41.0053922130387 28.9532561224152,41.0050927032051 28.9533437353826,41.005062701937 28.953347503181,41.0050669178026 28.9533772351576,41.0050568723311 28.9533383718865,41.0049896454168 28.9533179185037,41.0049542644499 28.9532944274786,41.0049136288141 28.9532906971522,41.0049071759539 28.9532692738266,41.0048757522837 28.9532442853703,41.0047158834085 28.9530658233733,41.0046373800632 28.9530887475493,41.0045962706217 28.9531244956567,41.0045837018943 28.9531713095583,41.0045017133178 28.9530841754704,41.0044057100438 28.9532342642082,41.0041455101167 28.9531505496456,41.0040515451769 28.9532457911366,41.0038865560011 28.953027188568,41.0038158307942 28.9529403532956,41.0038220276152 28.953061771356,41.0036225413863 28.9531694436457,41.0034338399889 28.9532115448058,41.0033836363774 28.9532834192392,41.0032474507668 28.9540326523595,41.0035263786968 28.9540045583706,41.0035884675254 28.9539893901689,41.0036219897994 28.9538982979324,41.0038371516227 28.953896928982,41.0038404002143 28.9538797131796,41.0038846490739 28.9538795906566,41.0038849529215 28.9538794256567,41.0038853460644 28.9538790705319,41.0038861905009 28.9538526225338,41.0039492074097 28.9537573664586,41.0042875865694 28.9537570364925,41.0042913526988 28.9537550853265,41.0043135827445 28.953812239515,41.0043181084997 28.9538484230775,41.0043283417828 28.9538444849655,41.0043537588248 28.9539118375048,41.004366063266 28.9539287138586,41.0043691463515 28.95397919007,41.0043783676681 28.9539162817492,41.0046566644315 28.9539573045258,41.0046617775675 28.9540092275959,41.0046738588337 28.9539543415796,41.0049161056355 28.953911438855,41.0050010682229 28.9539015046431,41.0050165304878 28.9538755210987,41.005076967314 28.9538594434747,41.0051085484484 28.9539233106539,41.0052567321025 28.9540081721607,41.0054479582603 28.9540340250766,41.0054998890263 28.9540987592187,41.0057059931514 28.9541336716097,41.0058417904728 28.9541555244901,41.0058470699562 28.9541206330752,41.0058475937214 28.9540663866331,41.0058494281263 28.9540373980941,41.0058504083961 28.9540377028919,41.0058588402032 28.9540379347539,41.005865254343 28.9539174473461,41.0058693654234 28.9538320270944,41.0059011392828 28.9538324973974,41.0059439253272 28.9538644092579,41.0059698289343 28.953885863876,41.006092354939 28.9538422385024,41.0061145825693 28.9538433943303,41.0062819148894 28.9538314256368,41.0063432496752 28.9538289235528,41.0064859577326 28.953865403373,41.0065179510628 28.9539286994772,41.0067721240561', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:29:13.3247488' AS DateTime2), CAST(N'2021-08-23T14:03:40.7430959' AS DateTime2), NULL)
GO
INSERT [dbo].[ProjectField] ([ProjectFieldID], [ProjectID], [IsProjectInIstanbul], [DistrictID], [ProjectAddress], [ProjectCost], [ProjectArea], [ProjectConstructionArea], [ProjectPaysageArea], [ProjectPaftaAdaParsel], [KML], [ProjectLongitude], [ProjectLatitude], [ProjectPoint], [ProjectLineString], [ProjectPolygon], [coordinates], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, 1529, 1, 421, N'fghgfhfgh', NULL, 345345, 45646, 45345, N'8789/jb', NULL, CAST(56.345000 AS Decimal(9, 6)), CAST(34.654500 AS Decimal(9, 6)), 0xE6100000010C00000000000000000000000000000000, NULL, NULL, NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T14:09:39.7913390' AS DateTime2), CAST(N'2021-08-23T14:13:33.7104062' AS DateTime2), NULL)
GO
SET IDENTITY_INSERT [dbo].[ProjectField] OFF
GO
SET IDENTITY_INSERT [dbo].[Phase] ON 
GO
INSERT [dbo].[Phase] ([PhaseID], [PhaseTitle], [PhaseOrder], [PhaseDescription], [PreviousPhaseID], [isPresentation], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, N'Öneri', 1, N'Öneri', NULL, 0, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Phase] ([PhaseID], [PhaseTitle], [PhaseOrder], [PhaseDescription], [PreviousPhaseID], [isPresentation], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, N'Etüt ve Fizibilite', 2, N'Etüt ve Fizibilite', NULL, 0, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Phase] ([PhaseID], [PhaseTitle], [PhaseOrder], [PhaseDescription], [PreviousPhaseID], [isPresentation], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (3, N'Proje Yöneticisi Atama', 3, N'Proje Yöneticisi Atama', NULL, 0, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Phase] ([PhaseID], [PhaseTitle], [PhaseOrder], [PhaseDescription], [PreviousPhaseID], [isPresentation], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (4, N'Proje Çizim', 4, N'Proje Çizim', NULL, 0, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Phase] ([PhaseID], [PhaseTitle], [PhaseOrder], [PhaseDescription], [PreviousPhaseID], [isPresentation], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (5, N'Proje Yöneticisi Atama (Yapım)', 5, N'Proje Yöneticisi Atama (Yapım)', NULL, 0, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Phase] ([PhaseID], [PhaseTitle], [PhaseOrder], [PhaseDescription], [PreviousPhaseID], [isPresentation], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (6, N'Yapım', 6, N'Yapım', NULL, 0, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Phase] ([PhaseID], [PhaseTitle], [PhaseOrder], [PhaseDescription], [PreviousPhaseID], [isPresentation], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (7, N'Teslimat', 7, N'Teslimat', NULL, 0, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6133333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Phase] ([PhaseID], [PhaseTitle], [PhaseOrder], [PhaseDescription], [PreviousPhaseID], [isPresentation], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (8, N'Kapanış', 8, N'Kapanış', NULL, 0, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6133333' AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Phase] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectPhaseStatus] ON 
GO
INSERT [dbo].[ProjectPhaseStatus] ([ProjectPhaseStatusID], [ProjectPhaseStatusTitle], [ProjectPhaseStatusDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, N'Bitti', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-24T10:17:18.0582320' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ProjectPhaseStatus] ([ProjectPhaseStatusID], [ProjectPhaseStatusTitle], [ProjectPhaseStatusDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, N'Yapım', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-24T10:17:23.3596383' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ProjectPhaseStatus] ([ProjectPhaseStatusID], [ProjectPhaseStatusTitle], [ProjectPhaseStatusDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (3, N'Bekleme', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-24T10:17:27.5433327' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ProjectPhaseStatus] ([ProjectPhaseStatusID], [ProjectPhaseStatusTitle], [ProjectPhaseStatusDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (4, N'Deneme', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-24T10:17:33.9199734' AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[ProjectPhaseStatus] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectPhase] ON 
GO
INSERT [dbo].[ProjectPhase] ([ProjectPhaseID], [ProjectID], [PhaseID], [ProjectPhaseStatusID], [ProjectPhaseStatusDescription], [ProjectPhaseStart], [ProjectPhaseFinish], [ProjectPhaseRecordedStart], [ProjectPhaseRecordedFinish], [ProjectPhaseTimeExtension], [ProjectPhaseTimeExtentedFinish], [ProjectPhaseExtensionReason], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, 1528, 2, 1, N'werwer', CAST(N'2021-08-03T00:00:00.0000000' AS DateTime2), CAST(N'2021-08-28T00:00:00.0000000' AS DateTime2), CAST(N'2021-08-20T00:00:00.0000000' AS DateTime2), CAST(N'2021-08-19T00:00:00.0000000' AS DateTime2), 33, CAST(N'2021-09-05T00:00:00.0000000' AS DateTime2), N'erterte', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-24T10:29:42.0000000' AS DateTime2), CAST(N'2021-08-24T10:50:20.3437094' AS DateTime2), NULL)
GO
INSERT [dbo].[ProjectPhase] ([ProjectPhaseID], [ProjectID], [PhaseID], [ProjectPhaseStatusID], [ProjectPhaseStatusDescription], [ProjectPhaseStart], [ProjectPhaseFinish], [ProjectPhaseRecordedStart], [ProjectPhaseRecordedFinish], [ProjectPhaseTimeExtension], [ProjectPhaseTimeExtentedFinish], [ProjectPhaseExtensionReason], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1002, 1528, 1, 2, N'kjljkl', CAST(N'2021-07-15T00:00:00.0000000' AS DateTime2), CAST(N'2021-07-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-07-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-08-19T00:00:00.0000000' AS DateTime2), 2, CAST(N'2021-07-19T00:00:00.0000000' AS DateTime2), N'Asfalt gelmedi', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-24T20:31:16.6964378' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ProjectPhase] ([ProjectPhaseID], [ProjectID], [PhaseID], [ProjectPhaseStatusID], [ProjectPhaseStatusDescription], [ProjectPhaseStart], [ProjectPhaseFinish], [ProjectPhaseRecordedStart], [ProjectPhaseRecordedFinish], [ProjectPhaseTimeExtension], [ProjectPhaseTimeExtentedFinish], [ProjectPhaseExtensionReason], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1003, 1528, 3, 3, N'4565', CAST(N'2021-08-31T00:00:00.0000000' AS DateTime2), CAST(N'2021-09-05T00:00:00.0000000' AS DateTime2), CAST(N'2021-09-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-09-26T00:00:00.0000000' AS DateTime2), 4, CAST(N'2021-09-09T00:00:00.0000000' AS DateTime2), N'mallık', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-24T20:33:05.2793625' AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[ProjectPhase] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectBidding] ON 
GO
INSERT [dbo].[ProjectBidding] ([ProjectBiddingID], [ProjectID], [BiddingTitle], [ProjectPhaseID], [DepartmentID], [BiddingCode], [BiddingDate], [BiddingContractCost], [BiddingProgressPayment], [ContractorID], [BiddingDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, 1529, N'Cem', 2, 3, N'24243', CAST(N'2021-08-12T00:00:00.0000000' AS DateTime2), CAST(0.00 AS Decimal(18, 2)), CAST(4535345.32 AS Decimal(18, 2)), 1, N'dfgdfg', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-25T14:56:14.0498627' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ProjectBidding] ([ProjectBiddingID], [ProjectID], [BiddingTitle], [ProjectPhaseID], [DepartmentID], [BiddingCode], [BiddingDate], [BiddingContractCost], [BiddingProgressPayment], [ContractorID], [BiddingDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (3, 1528, N'Cem', 2, 2, N'werwr', CAST(N'2021-07-28T00:00:00.0000000' AS DateTime2), CAST(54575400.00 AS Decimal(18, 2)), CAST(45646.00 AS Decimal(18, 2)), 1, N'fgfhgh', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-25T15:01:09.9412364' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ProjectBidding] ([ProjectBiddingID], [ProjectID], [BiddingTitle], [ProjectPhaseID], [DepartmentID], [BiddingCode], [BiddingDate], [BiddingContractCost], [BiddingProgressPayment], [ContractorID], [BiddingDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (4, 1528, N'sdf', 2, 2, N'435345', CAST(N'2021-08-13T00:00:00.0000000' AS DateTime2), CAST(554645.00 AS Decimal(18, 2)), CAST(546464.44 AS Decimal(18, 2)), 1, N'fgggfg', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-25T15:05:11.7588541' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ProjectBidding] ([ProjectBiddingID], [ProjectID], [BiddingTitle], [ProjectPhaseID], [DepartmentID], [BiddingCode], [BiddingDate], [BiddingContractCost], [BiddingProgressPayment], [ContractorID], [BiddingDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (5, 1528, N'Cem', 2, 2, N'werwer', CAST(N'2021-07-30T00:00:00.0000000' AS DateTime2), CAST(78454874.00 AS Decimal(18, 2)), CAST(34.00 AS Decimal(18, 2)), 1, N'sdffsdf', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-25T15:08:40.9493847' AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[ProjectBidding] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectPerson] ON 
GO
INSERT [dbo].[ProjectPerson] ([ProjectPersonID], [IsInternal], [ProjectID], [PersonID], [JobTitleID], [JobFieldID], [ContractorID], [ProjectPersonDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, 0, 1529, NULL, NULL, NULL, 1, N'bvncn', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T14:12:06.2144401' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ProjectPerson] ([ProjectPersonID], [IsInternal], [ProjectID], [PersonID], [JobTitleID], [JobFieldID], [ContractorID], [ProjectPersonDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, 0, 1528, 2, NULL, NULL, 1, N'fbfgf', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T16:57:42.0000000' AS DateTime2), CAST(N'2021-08-23T17:06:33.3285824' AS DateTime2), NULL)
GO
INSERT [dbo].[ProjectPerson] ([ProjectPersonID], [IsInternal], [ProjectID], [PersonID], [JobTitleID], [JobFieldID], [ContractorID], [ProjectPersonDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (3, 1, 1528, 1, 1, NULL, NULL, N'ffff', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T17:06:44.8501243' AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[ProjectPerson] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectFeasibility] ON 
GO
INSERT [dbo].[ProjectFeasibility] ([ProjectFeasibilityID], [IsFeasibilityNeeded], [ProjectID], [ContractorID], [PersonID], [ProjectFeasibilityOutsource], [ProjectFeasibilityDate], [ProjectFeasibilityCost], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (6, 1, 1528, 1, 1, N'dfgdfg', CAST(N'2021-08-29T00:00:00.0000000' AS DateTime2), CAST(43534534.00 AS Decimal(18, 2)), (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T13:47:28.0000000' AS DateTime2), CAST(N'2021-08-24T11:57:59.8092755' AS DateTime2), NULL)
GO
INSERT [dbo].[ProjectFeasibility] ([ProjectFeasibilityID], [IsFeasibilityNeeded], [ProjectID], [ContractorID], [PersonID], [ProjectFeasibilityOutsource], [ProjectFeasibilityDate], [ProjectFeasibilityCost], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (8, 1, 1529, NULL, 1, N'dfgdfg', CAST(N'2021-08-05T00:00:00.0000000' AS DateTime2), CAST(10456456.00 AS Decimal(18, 2)), (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T14:08:00.0000000' AS DateTime2), CAST(N'2021-08-23T14:09:05.8745043' AS DateTime2), NULL)
GO
SET IDENTITY_INSERT [dbo].[ProjectFeasibility] OFF
GO
SET IDENTITY_INSERT [dbo].[Board] ON 
GO
INSERT [dbo].[Board] ([BoardID], [BoardTitle], [BoardDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, N'Örnek Kurum 1', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:24:56.0843359' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Board] ([BoardID], [BoardTitle], [BoardDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, N'Örnek Kurum 2', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:24:58.7365510' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Board] ([BoardID], [BoardTitle], [BoardDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (3, N'Örnek Kurum 3', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:25:01.5572689' AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Board] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectBoardApproval] ON 
GO
INSERT [dbo].[ProjectBoardApproval] ([ProjectBoardApprovalID], [ProjectID], [IsBoardApprovalNeeded], [BoardID], [ProjectBoardApprovalDate], [ProjectBoardApprovalReason], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, 1528, 1, 1, NULL, NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:29:13.3247488' AS DateTime2), CAST(N'2021-08-23T14:03:40.7430959' AS DateTime2), NULL)
GO
INSERT [dbo].[ProjectBoardApproval] ([ProjectBoardApprovalID], [ProjectID], [IsBoardApprovalNeeded], [BoardID], [ProjectBoardApprovalDate], [ProjectBoardApprovalReason], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, 1529, 1, 2, CAST(N'2021-08-12T00:00:00.0000000' AS DateTime2), N'dsfdsf', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T14:09:39.7913390' AS DateTime2), CAST(N'2021-08-23T14:13:33.7104062' AS DateTime2), NULL)
GO
SET IDENTITY_INSERT [dbo].[ProjectBoardApproval] OFF
GO
SET IDENTITY_INSERT [dbo].[ExpropriationStatus] ON 
GO
INSERT [dbo].[ExpropriationStatus] ([ExpropriationStatusID], [ExpropriationStatusTitle], [ExpropriationStatusDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, N'Durum 1', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:21:44.4483665' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ExpropriationStatus] ([ExpropriationStatusID], [ExpropriationStatusTitle], [ExpropriationStatusDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, N'Durum 2', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:21:47.7429707' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ExpropriationStatus] ([ExpropriationStatusID], [ExpropriationStatusTitle], [ExpropriationStatusDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (3, N'Durum 3', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:21:50.9538244' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[ExpropriationStatus] ([ExpropriationStatusID], [ExpropriationStatusTitle], [ExpropriationStatusDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (4, N'Durum 4', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:21:54.6039735' AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[ExpropriationStatus] OFF
GO
SET IDENTITY_INSERT [dbo].[PropertyStatus] ON 
GO
INSERT [dbo].[PropertyStatus] ([PropertyStatusID], [PropertyStatusTitle], [PropertyStatusDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, N'Durum 1', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:23:25.0865005' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[PropertyStatus] ([PropertyStatusID], [PropertyStatusTitle], [PropertyStatusDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, N'Durum 2', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:23:29.2715617' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[PropertyStatus] ([PropertyStatusID], [PropertyStatusTitle], [PropertyStatusDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (3, N'Durum 3', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:23:35.8883992' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[PropertyStatus] ([PropertyStatusID], [PropertyStatusTitle], [PropertyStatusDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (4, N'Durum 4', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:23:40.6247059' AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[PropertyStatus] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectExpropriation] ON 
GO
INSERT [dbo].[ProjectExpropriation] ([ProjectExpropriationID], [ProjectID], [PropertyStatusID], [PropertyStatusDescription], [ExpropriationStatusID], [ProjectExpropriationDescription], [ProjectNeedsExpropriation], [ProjectExpropriationDate], [ProjectExpropriationCost], [ProjectExpropriationStatusDesc], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, 1528, NULL, NULL, NULL, NULL, 1, NULL, CAST(0.00 AS Decimal(18, 2)), NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:29:13.3247488' AS DateTime2), CAST(N'2021-08-23T14:03:40.7430959' AS DateTime2), NULL)
GO
INSERT [dbo].[ProjectExpropriation] ([ProjectExpropriationID], [ProjectID], [PropertyStatusID], [PropertyStatusDescription], [ExpropriationStatusID], [ProjectExpropriationDescription], [ProjectNeedsExpropriation], [ProjectExpropriationDate], [ProjectExpropriationCost], [ProjectExpropriationStatusDesc], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, 1529, 3, N'asds', 3, NULL, 1, CAST(N'2021-08-19T00:00:00.0000000' AS DateTime2), CAST(23423434.44 AS Decimal(18, 2)), N'ertert', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T14:09:39.7913390' AS DateTime2), CAST(N'2021-08-23T14:13:33.7104062' AS DateTime2), NULL)
GO
SET IDENTITY_INSERT [dbo].[ProjectExpropriation] OFF
GO
SET IDENTITY_INSERT [dbo].[Organization] ON 
GO
INSERT [dbo].[Organization] ([OrganizationID], [OrganizationTitle], [OrganizationDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, N'Belediye 1', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:24:16.6214697' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Organization] ([OrganizationID], [OrganizationTitle], [OrganizationDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, N'Belediye 2', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:24:19.2138803' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Organization] ([OrganizationID], [OrganizationTitle], [OrganizationDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (3, N'Belediye 3', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:24:22.1558467' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Organization] ([OrganizationID], [OrganizationTitle], [OrganizationDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (4, N'Belediye 4', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:24:25.3963200' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Organization] ([OrganizationID], [OrganizationTitle], [OrganizationDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (5, N'Belediye 5', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:24:29.8467965' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Organization] ([OrganizationID], [OrganizationTitle], [OrganizationDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (6, N'Belediye 6', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:24:34.9798551' AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Organization] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectPermission] ON 
GO
INSERT [dbo].[ProjectPermission] ([ProjectPermissionID], [ProjectID], [OrganizationID], [IsPermissionNeeded], [ProjectPermissionDate], [ProjectPermissionReason], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, 1528, NULL, 1, NULL, NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:29:13.3247488' AS DateTime2), CAST(N'2021-08-23T14:03:40.7430959' AS DateTime2), NULL)
GO
INSERT [dbo].[ProjectPermission] ([ProjectPermissionID], [ProjectID], [OrganizationID], [IsPermissionNeeded], [ProjectPermissionDate], [ProjectPermissionReason], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, 1529, 4, 1, CAST(N'2021-08-23T00:00:00.0000000' AS DateTime2), N'ertt', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T14:09:39.7913390' AS DateTime2), CAST(N'2021-08-23T14:13:33.7104062' AS DateTime2), NULL)
GO
SET IDENTITY_INSERT [dbo].[ProjectPermission] OFF
GO
SET IDENTITY_INSERT [dbo].[RelationType] ON 
GO
INSERT [dbo].[RelationType] ([RelationTypeID], [RelationTypeTitle], [RelationTypeDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, N'Deneme 1', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T14:12:18.5089270' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[RelationType] ([RelationTypeID], [RelationTypeTitle], [RelationTypeDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, N'Deneme 2', NULL, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T14:12:21.7037842' AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[RelationType] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectRelation] ON 
GO
INSERT [dbo].[ProjectRelation] ([ProjectRelationID], [ProjectID], [RelatedProjectID], [RelationTypeID], [ProjectRelationDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, 1529, 1528, 2, N'fdg', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T14:12:39.0000000' AS DateTime2), CAST(N'2021-08-23T14:12:46.3781047' AS DateTime2), NULL)
GO
INSERT [dbo].[ProjectRelation] ([ProjectRelationID], [ProjectID], [RelatedProjectID], [RelationTypeID], [ProjectRelationDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, 1528, 1528, 2, N'ghgg', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T17:06:54.9918639' AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[ProjectRelation] OFF
GO
SET IDENTITY_INSERT [dbo].[Authority] ON 
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, N'A PLANI (MÜDÜRLÜK ÜSTÜ MAKAMLAR)', N'A PLANI (MÜDÜRLÜK ÜSTÜ MAKAMLAR)', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5833333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (2, N'ADALAR BELEDİYE BAŞKANLIĞI', N'ADALAR BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (3, N'ALTYAPI HİZMETLERİ  MÜDÜRLÜĞÜ', N'ALTYAPI HİZMETLERİ  MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (4, N'ALTYAPI PROJELER MÜDÜRLÜĞÜ', N'ALTYAPI PROJELER MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (5, N'ANADOLU YAKASI İTFAİYE MÜDÜRLÜĞÜ', N'ANADOLU YAKASI İTFAİYE MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (6, N'ANADOLU YAKASI PARK VE BAHÇELER MÜDÜRLÜĞÜ', N'ANADOLU YAKASI PARK VE BAHÇELER MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (7, N'ANADOLU YAKASI YOL BAKIM VE ONARIM MÜDÜRLÜĞÜ', N'ANADOLU YAKASI YOL BAKIM VE ONARIM MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (8, N'ARNAVUTKÖY BELEDİYE BAŞKANLIĞI', N'ARNAVUTKÖY BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (9, N'ARŞİV MÜDÜRLÜĞÜ', N'ARŞİV MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (10, N'ASKERİ BİRİMLER', N'ASKERİ BİRİMLER', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (11, N'ATIK YÖNETİMİ MÜDÜRLÜĞÜ', N'ATIK YÖNETİMİ MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (12, N'AVCILAR BELEDİYE BAŞKANLIĞI', N'AVCILAR BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (13, N'AVRUPA YAKASI İTFAİYE MÜDÜRLÜĞÜ', N'AVRUPA YAKASI İTFAİYE MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (14, N'AVRUPA YAKASI PARK VE BAHÇELER MÜDÜRLÜĞÜ', N'AVRUPA YAKASI PARK VE BAHÇELER MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (15, N'AVRUPA YAKASI YOL BAKIM VE ONARIM MÜDÜRLÜĞÜ', N'AVRUPA YAKASI YOL BAKIM VE ONARIM MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (16, N'BAĞCILAR BELEDİYE BAŞKANLIĞI', N'BAĞCILAR BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5866667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (17, N'BAHÇELİEVLER BELEDİYE BAŞKANLIĞI', N'BAHÇELİEVLER BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (18, N'BAHÇELİEVLER KAYMAKAMLIĞI', N'BAHÇELİEVLER KAYMAKAMLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (19, N'BAKIRKÖY BELEDİYE BAŞKANLIĞI', N'BAKIRKÖY BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (20, N'BASIN YAYIN VE HALKLA İLİŞKİLER DAİRE BAŞKANLIĞI', N'BASIN YAYIN VE HALKLA İLİŞKİLER DAİRE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (21, N'BAŞAKŞEHİR BELEDİYE BAŞKANLIĞI', N'BAŞAKŞEHİR BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (22, N'BAŞAKŞEHİR KAYMAKAMLIĞI', N'BAŞAKŞEHİR KAYMAKAMLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (23, N'BAŞBAKANLIK', N'BAŞBAKANLIK', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (24, N'BAŞKANLIK MAKAMI', N'BAŞKANLIK MAKAMI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (25, N'BAYRAMPAŞA  BELEDİYE BAŞKANLIĞI', N'BAYRAMPAŞA  BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (26, N'BELEDİYELER (İL DIŞI)', N'BELEDİYELER (İL DIŞI)', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (27, N'BELTUR AŞ', N'BELTUR AŞ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (28, N'BEŞİKTAŞ BELEDİYE BAŞKANLIĞI', N'BEŞİKTAŞ BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (29, N'BEYKOZ BELEDİYE BAŞKANLIĞI', N'BEYKOZ BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (30, N'BEYKOZ KAYMAKAMLIĞI', N'BEYKOZ KAYMAKAMLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (31, N'BEYLİKDÜZÜ BELEDİYE BAŞKANLIĞI', N'BEYLİKDÜZÜ BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (32, N'BEYOĞLU BELEDİYE BAŞKANLIĞI', N'BEYOĞLU BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (33, N'BOĞAZİÇİ İMAR MÜDÜRLÜĞÜ', N'BOĞAZİÇİ İMAR MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (34, N'BÜYÜKÇEKMECE BELEDİYE BAŞKANLIĞI', N'BÜYÜKÇEKMECE BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (35, N'CEMİYETLER', N'CEMİYETLER', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (36, N'CUMHURBAŞKANLIĞI', N'CUMHURBAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (37, N'ÇATALCA BELEDİYE BAŞKANLIĞI', N'ÇATALCA BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5900000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (38, N'ÇEKMEKÖY BELEDİYE BAŞKANLIĞI', N'ÇEKMEKÖY BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (39, N'ÇEVRE KORUMA MÜDÜRLÜĞÜ', N'ÇEVRE KORUMA MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (40, N'DENİZ HİZMETLERİ  MÜDÜRLÜĞÜ', N'DENİZ HİZMETLERİ  MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (41, N'DENİZ KUVVETLERİ KOMUTANLIĞI', N'DENİZ KUVVETLERİ KOMUTANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (42, N'DESTEK HİZMETLERİ DAİRE BAŞKANLIĞI', N'DESTEK HİZMETLERİ DAİRE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (43, N'DEVLET BAKANLIKLARI', N'DEVLET BAKANLIKLARI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (44, N'DİĞER MAKAMLAR', N'DİĞER MAKAMLAR', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (45, N'DİYANET İŞLERİ BAŞKANLIĞI', N'DİYANET İŞLERİ BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (46, N'ELEKTRONİK SİSTEMLER MÜDÜRLÜĞÜ', N'ELEKTRONİK SİSTEMLER MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (47, N'EMLAK MÜDÜRLÜĞÜ', N'EMLAK MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (48, N'EMLAK YÖNETİMİ DAİRE BAŞKANLIĞI', N'EMLAK YÖNETİMİ DAİRE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (49, N'EMNİYET GENEL MÜDÜRLÜĞÜ', N'EMNİYET GENEL MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (50, N'EMNİYET MÜDÜRLÜĞÜ (İST)', N'EMNİYET MÜDÜRLÜĞÜ (İST)', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (51, N'ENERJİ AŞ', N'ENERJİ AŞ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (52, N'ENERJİ VE TABİİ KAYNAKLAR BAKANLIĞI', N'ENERJİ VE TABİİ KAYNAKLAR BAKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (53, N'ENGELLİLER MÜDÜRLÜĞÜ', N'ENGELLİLER MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (54, N'ESENLER BELEDİYE BAŞKANLIĞI', N'ESENLER BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (55, N'ESENYURT BELEDİYE BAŞKANLIĞI', N'ESENYURT BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5933333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (56, N'ETÜD VE PROJELER DAİRE BAŞKANLIĞI', N'ETÜD VE PROJELER DAİRE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (57, N'EYÜP BELEDİYE BAŞKANLIĞI', N'EYÜP BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (58, N'FATİH BELEDİYE BAŞKANLIĞI', N'FATİH BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (59, N'FEN İŞLERİ DAİRE BAŞKANLIĞI', N'FEN İŞLERİ DAİRE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (60, N'GAZİOSMANPAŞA BELEDİYE BAŞKANLIĞI', N'GAZİOSMANPAŞA BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (61, N'GENÇLİK VE SPOR  MÜDÜRLÜĞÜ', N'GENÇLİK VE SPOR  MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (62, N'GENÇLİK VE SPOR İL MÜDÜRLÜĞÜ', N'GENÇLİK VE SPOR İL MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (63, N'GENEL SEKRETER YARDIMCISI (1)', N'GENEL SEKRETER YARDIMCISI (1)', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (64, N'GENEL SEKRETER YARDIMCISI (3)', N'GENEL SEKRETER YARDIMCISI (3)', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (65, N'GENEL SEKRETERLİK', N'GENEL SEKRETERLİK', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (66, N'GÜNGÖREN  BELEDİYE BAŞKANLIĞI', N'GÜNGÖREN  BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (67, N'HAL MÜDÜRLÜĞÜ', N'HAL MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (68, N'HALK EKMEK AŞ', N'HALK EKMEK AŞ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (69, N'HALKLA  İLİŞKİLER  MÜDÜRLÜĞÜ', N'HALKLA  İLİŞKİLER  MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (70, N'HAYAT BOYU ÖĞRENME MÜDÜRLÜĞÜ', N'HAYAT BOYU ÖĞRENME MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (71, N'İÇİŞLERİ BAKANLIĞI', N'İÇİŞLERİ BAKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (72, N'İETT İŞLETMELERİ GENEL MÜDÜRLÜĞÜ', N'İETT İŞLETMELERİ GENEL MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.5966667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (73, N'İL ÇEVRE VE ŞEHİRCİLİK MÜDÜRLÜĞÜ', N'İL ÇEVRE VE ŞEHİRCİLİK MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (74, N'İL MİLLİ EĞİTİM MÜDÜRLÜGÜ', N'İL MİLLİ EĞİTİM MÜDÜRLÜGÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (75, N'İSKİ GENEL MÜDÜRLÜĞÜ', N'İSKİ GENEL MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (76, N'İSPARK AŞ', N'İSPARK AŞ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (77, N'İSTANBUL CUMHURİYET BAŞSAVCILIĞI', N'İSTANBUL CUMHURİYET BAŞSAVCILIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (78, N'İSTANBUL DARÜLACEZE MÜDÜRLÜĞÜ', N'İSTANBUL DARÜLACEZE MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (79, N'İSTANBUL JANDARMA KOMUTANLIĞI', N'İSTANBUL JANDARMA KOMUTANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (80, N'İSTANBUL MÜFTÜLÜĞÜ', N'İSTANBUL MÜFTÜLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (81, N'İSTANBUL VALİLİĞİ', N'İSTANBUL VALİLİĞİ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (82, N'İTFAİYE DAİRE BAŞKANLIĞI', N'İTFAİYE DAİRE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (83, N'İTFAİYE DESTEK HİZMETLERİ MÜDÜRLÜĞÜ', N'İTFAİYE DESTEK HİZMETLERİ MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (84, N'JANDARMA GENEL KOMUTANLIĞI', N'JANDARMA GENEL KOMUTANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (85, N'KAĞITHANE BELEDİYE BAŞKANLIĞI', N'KAĞITHANE BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (86, N'KARTAL BELEDİYE BAŞKANLIĞI', N'KARTAL BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (87, N'KARTAL KAYMAKAMLIĞI', N'KARTAL KAYMAKAMLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (88, N'KENTSEL DÖNÜŞÜM MÜDÜRLÜĞÜ', N'KENTSEL DÖNÜŞÜM MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (89, N'KENTSEL TASARIM MÜDÜRLÜĞÜ', N'KENTSEL TASARIM MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (90, N'KIPTAŞ AŞ', N'KIPTAŞ AŞ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (91, N'KÜÇÜKÇEKMECE BELEDİYE BAŞKANLIĞI', N'KÜÇÜKÇEKMECE BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (92, N'KÜLTÜR AŞ', N'KÜLTÜR AŞ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (93, N'KÜLTÜR VARLIKLARI PROJELER MÜDÜRLÜĞÜ', N'KÜLTÜR VARLIKLARI PROJELER MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6000000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (94, N'KÜLTÜREL MİRAS KORUMA MÜDÜRLÜĞÜ', N'KÜLTÜREL MİRAS KORUMA MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (95, N'KÜTÜPHANE VE MÜZELER MÜDÜRLÜĞÜ', N'KÜTÜPHANE VE MÜZELER MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (96, N'LEVAZIM VE AYNİYAT MÜDÜRLÜĞÜ', N'LEVAZIM VE AYNİYAT MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (97, N'MALTEPE BELEDİYE BAŞKANLIĞI', N'MALTEPE BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (98, N'MESKEN MÜDÜRLÜĞÜ', N'MESKEN MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (99, N'MEZARLIKLAR MÜDÜRLÜĞÜ', N'MEZARLIKLAR MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (100, N'MİLLİ SAVUNMA BAKANLIĞI', N'MİLLİ SAVUNMA BAKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (101, N'MUHTARLIKLAR GIDA TARIM VE HAYVANCILIK DAİRE BAŞKANLIĞI', N'MUHTARLIKLAR GIDA TARIM VE HAYVANCILIK DAİRE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (102, N'MÜDÜRLÜKLER (DIŞ BİRİM)', N'MÜDÜRLÜKLER (DIŞ BİRİM)', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (103, N'MÜDÜRLÜKLER (İÇ BİRİM)', N'MÜDÜRLÜKLER (İÇ BİRİM)', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (104, N'ORDU KOMUTANLIKLARI', N'ORDU KOMUTANLIKLARI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (105, N'ORTAÖĞRETİM OKULLARI', N'ORTAÖĞRETİM OKULLARI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (106, N'PARK BAHÇE VE YESIL ALAN DAİRE BAŞKANLIĞI', N'PARK BAHÇE VE YESIL ALAN DAİRE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (107, N'PENDİK BELEDİYE BAŞKANLIĞI', N'PENDİK BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (108, N'SAĞLIK VE HIFZISSIHHA MÜDÜRLÜĞÜ', N'SAĞLIK VE HIFZISSIHHA MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (109, N'SANCAKTEPE BELEDİYE BAŞKANLIĞI', N'SANCAKTEPE BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (110, N'SARIYER BELEDİYE BAŞKANLIĞI', N'SARIYER BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6033333' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (111, N'SATINALMA  MÜDÜRLÜĞÜ', N'SATINALMA  MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (112, N'SAVCILIKLAR', N'SAVCILIKLAR', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (113, N'SİLİVRİ BELEDİYE BAŞKANLIĞI', N'SİLİVRİ BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (114, N'SOSYAL HİZMETLER DAİRE BAŞKANLIĞI', N'SOSYAL HİZMETLER DAİRE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (115, N'SOSYAL HİZMETLER MÜDÜRLÜĞÜ', N'SOSYAL HİZMETLER MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (116, N'SOSYAL VE İDARİ İŞLER MÜDÜRLÜĞÜ', N'SOSYAL VE İDARİ İŞLER MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (117, N'SPOR AŞ', N'SPOR AŞ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (118, N'SPOR KULÜPLERİ', N'SPOR KULÜPLERİ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (119, N'SU ÜRÜNLERİ HALİ MÜDÜRLÜĞÜ', N'SU ÜRÜNLERİ HALİ MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (120, N'SULTANBEYLİ BELEDİYE BAŞKANLIĞI', N'SULTANBEYLİ BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (121, N'SULTANGAZİ BELEDİYE BAŞKANLIĞI', N'SULTANGAZİ BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (122, N'ŞEHİR HATLARI AŞ', N'ŞEHİR HATLARI AŞ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (123, N'ŞEHİR TİYATROLARI MÜDÜRLÜĞÜ', N'ŞEHİR TİYATROLARI MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (124, N'ŞİLE BELEDİYE BAŞKANLIĞI', N'ŞİLE BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (125, N'ŞİRKETLER', N'ŞİRKETLER', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (126, N'Talep Sahibi', N'Talep Sahibi', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (127, N'TOKİ BAŞKANLIĞI', N'TOKİ BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6066667' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (128, N'TOPLU ULAŞIM HİZMETLERİ MÜDÜRLÜĞÜ', N'TOPLU ULAŞIM HİZMETLERİ MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (129, N'TUZLA BELEDİYE BAŞKANLIĞI', N'TUZLA BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (130, N'ULAŞIM DAİRE BAŞKANLIĞI', N'ULAŞIM DAİRE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (131, N'ULAŞIM KOORDİNASYON MÜDÜRLÜĞÜ', N'ULAŞIM KOORDİNASYON MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (132, N'ULAŞIM PLANLAMA  MÜDÜRLÜĞÜ', N'ULAŞIM PLANLAMA  MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (133, N'ÜMRANİYE BELEDİYE BAŞKANLIĞI', N'ÜMRANİYE BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (134, N'ÜNİVERSİTE VE YÜKSEK OKULLAR', N'ÜNİVERSİTE VE YÜKSEK OKULLAR', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (135, N'ÜSKÜDAR BELEDİYE BAŞKANLIĞI', N'ÜSKÜDAR BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (136, N'ÜSKÜDAR KAYMAKAMLIĞI', N'ÜSKÜDAR KAYMAKAMLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (137, N'ÜSTYAPI PROJELER MÜDÜRLÜĞÜ', N'ÜSTYAPI PROJELER MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (138, N'VAKIFLAR', N'VAKIFLAR', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (139, N'VETERINER HİZMETLERİ  MÜDÜRLÜĞÜ', N'VETERINER HİZMETLERİ  MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (140, N'YAPI  İŞLERİ  MÜDÜRLÜĞÜ', N'YAPI  İŞLERİ  MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (141, N'YEŞİL ALAN VE TESİSLER YAPIM MÜDÜRLÜĞÜ', N'YEŞİL ALAN VE TESİSLER YAPIM MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (142, N'YOL BAKIM VE ALTYAPI KOORDINASYON', N'YOL BAKIM VE ALTYAPI KOORDINASYON', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (143, N'YOL BAKIM VE ONARIM MÜDÜRLÜĞÜ', N'YOL BAKIM VE ONARIM MÜDÜRLÜĞÜ', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6100000' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Authority] ([AuthorityID], [AuthorityTitle], [AuthorityDescription], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (144, N'ZEYTİNBURNU BELEDİYE BAŞKANLIĞI', N'ZEYTİNBURNU BELEDİYE BAŞKANLIĞI', (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:18:30.6100000' AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Authority] OFF
GO
SET IDENTITY_INSERT [dbo].[Shortcuts] ON 
GO
INSERT [dbo].[Shortcuts] ([ShortcutsID], [ShortcutsType], [ShortcutsProjectID], [ShortcutsUserID], [UserID], [CreationDate], [UpdateDate], [DeletionDate]) VALUES (1, 0, 1528, 0, (SELECT TOP 1 [Id] FROM [dbo].[User]), CAST(N'2021-08-23T11:26:40.1910212' AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Shortcuts] OFF
GO
