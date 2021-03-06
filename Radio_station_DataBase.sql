USE [Radio_Station]
GO
/****** Object:  Table [dbo].[category]    Script Date: 8/9/2021 6:39:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category](
	[Category_Id] [int] NOT NULL,
	[Station_Category_Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_category] PRIMARY KEY CLUSTERED 
(
	[Category_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Language]    Script Date: 8/9/2021 6:39:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Language](
	[Language_Id] [smallint] NOT NULL,
	[Language_Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Language] PRIMARY KEY CLUSTERED 
(
	[Language_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Station]    Script Date: 8/9/2021 6:39:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Station](
	[Station_Id] [int] IDENTITY(1,1) NOT NULL,
	[Subcategory_Id] [int] NOT NULL,
	[Category_Id] [int] NOT NULL,
	[Station_Name] [nvarchar](150) NOT NULL,
	[Language_Id] [smallint] NOT NULL,
	[Station_Image_Url] [nvarchar](150) NULL,
 CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED 
(
	[Station_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[subcategory]    Script Date: 8/9/2021 6:39:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subcategory](
	[Subcategory_Id] [int] NOT NULL,
	[Category_Id] [int] NOT NULL,
	[Station_Type_Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_subcategory] PRIMARY KEY CLUSTERED 
(
	[Subcategory_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[category] ([Category_Id], [Station_Category_Name]) VALUES (1, N'Music')
INSERT [dbo].[category] ([Category_Id], [Station_Category_Name]) VALUES (2, N'Sports')
INSERT [dbo].[category] ([Category_Id], [Station_Category_Name]) VALUES (3, N'News')
INSERT [dbo].[Language] ([Language_Id], [Language_Name]) VALUES (1, N'Arabic')
INSERT [dbo].[Language] ([Language_Id], [Language_Name]) VALUES (2, N'English')
INSERT [dbo].[Language] ([Language_Id], [Language_Name]) VALUES (3, N'Spanish')
INSERT [dbo].[Language] ([Language_Id], [Language_Name]) VALUES (4, N'German')
INSERT [dbo].[Language] ([Language_Id], [Language_Name]) VALUES (5, N'chinese ')
SET IDENTITY_INSERT [dbo].[Station] ON 

INSERT [dbo].[Station] ([Station_Id], [Subcategory_Id], [Category_Id], [Station_Name], [Language_Id], [Station_Image_Url]) VALUES (4, 1, 1, N'Radio 9090', 1, N'https://www.9090.fm/uploads/images/2648_1577989261.png')
INSERT [dbo].[Station] ([Station_Id], [Subcategory_Id], [Category_Id], [Station_Name], [Language_Id], [Station_Image_Url]) VALUES (5, 2, 1, N'Radio 95 ', 1, N'https://4.bp.blogspot.com/-aTiedlwgPwE/WuCvlPt818I/AAAAAAAAFQM/qEWCoVazhrghX3JIBoVEwdvgpYLxGICOACLcBGAs/s1600/radio-95-fm-pop-live.jpg')
INSERT [dbo].[Station] ([Station_Id], [Subcategory_Id], [Category_Id], [Station_Name], [Language_Id], [Station_Image_Url]) VALUES (6, 3, 1, N'Rock Music', 2, N'https://yt3.ggpht.com/ytc/AKedOLRQUcHbXo5EwhJy8Pspsj4Mq6ZLGs-TRs1M2y5b=s900-c-k-c0x00ffffff-no-rj')
INSERT [dbo].[Station] ([Station_Id], [Subcategory_Id], [Category_Id], [Station_Name], [Language_Id], [Station_Image_Url]) VALUES (8, 4, 2, N'Foot Ball station', 2, N'https://www.nicepng.com/png/detail/28-285609_png-football-radio-station-graphic-design.png')
INSERT [dbo].[Station] ([Station_Id], [Subcategory_Id], [Category_Id], [Station_Name], [Language_Id], [Station_Image_Url]) VALUES (10, 5, 2, N'Hand Ball Station', 3, N'https://cdn.akamai.steamstatic.com/steam/apps/526980/ss_427c14078913036606463d022a006ee85c3893d5.1920x1080.jpg')
INSERT [dbo].[Station] ([Station_Id], [Subcategory_Id], [Category_Id], [Station_Name], [Language_Id], [Station_Image_Url]) VALUES (11, 6, 2, N'Tennis Sport Station', 2, N'https://m.media-amazon.com/images/I/41GyYNzH0OL._AC_.jpg')
INSERT [dbo].[Station] ([Station_Id], [Subcategory_Id], [Category_Id], [Station_Name], [Language_Id], [Station_Image_Url]) VALUES (12, 7, 3, N'BBC News', 2, N'https://upload.wikimedia.org/wikipedia/commons/thumb/f/f4/BBC_News_%282008%29.svg/1200px-BBC_News_%282008%29.svg.png')
INSERT [dbo].[Station] ([Station_Id], [Subcategory_Id], [Category_Id], [Station_Name], [Language_Id], [Station_Image_Url]) VALUES (13, 8, 3, N'Live News', 4, N'https://www.india.com/wp-content/uploads/2021/05/WhatsApp-Image-2021-04-09-at-4.05.01-PM-1.jpeg')
INSERT [dbo].[Station] ([Station_Id], [Subcategory_Id], [Category_Id], [Station_Name], [Language_Id], [Station_Image_Url]) VALUES (14, 9, 3, N'CRJ Sport News', 5, N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR0gmwYlIC-PXS1lCFYiQYxyRzISN2wGpWEn1wCphB9NiQuSXef8KdVGNi7kAx75kH8EiM&usqp=CAU')
SET IDENTITY_INSERT [dbo].[Station] OFF
INSERT [dbo].[subcategory] ([Subcategory_Id], [Category_Id], [Station_Type_Name]) VALUES (1, 1, N'Pop Music')
INSERT [dbo].[subcategory] ([Subcategory_Id], [Category_Id], [Station_Type_Name]) VALUES (2, 1, N'Classic Music')
INSERT [dbo].[subcategory] ([Subcategory_Id], [Category_Id], [Station_Type_Name]) VALUES (3, 1, N'ROCK MUSIC
')
INSERT [dbo].[subcategory] ([Subcategory_Id], [Category_Id], [Station_Type_Name]) VALUES (4, 2, N'Football')
INSERT [dbo].[subcategory] ([Subcategory_Id], [Category_Id], [Station_Type_Name]) VALUES (5, 2, N'handball')
INSERT [dbo].[subcategory] ([Subcategory_Id], [Category_Id], [Station_Type_Name]) VALUES (6, 2, N'tennis sport')
INSERT [dbo].[subcategory] ([Subcategory_Id], [Category_Id], [Station_Type_Name]) VALUES (7, 3, N'Country News')
INSERT [dbo].[subcategory] ([Subcategory_Id], [Category_Id], [Station_Type_Name]) VALUES (8, 3, N'Live News')
INSERT [dbo].[subcategory] ([Subcategory_Id], [Category_Id], [Station_Type_Name]) VALUES (9, 3, N'Sport News')
ALTER TABLE [dbo].[Station]  WITH CHECK ADD  CONSTRAINT [FK_Station_category] FOREIGN KEY([Category_Id])
REFERENCES [dbo].[category] ([Category_Id])
GO
ALTER TABLE [dbo].[Station] CHECK CONSTRAINT [FK_Station_category]
GO
ALTER TABLE [dbo].[Station]  WITH CHECK ADD  CONSTRAINT [FK_Station_Language] FOREIGN KEY([Language_Id])
REFERENCES [dbo].[Language] ([Language_Id])
GO
ALTER TABLE [dbo].[Station] CHECK CONSTRAINT [FK_Station_Language]
GO
ALTER TABLE [dbo].[Station]  WITH CHECK ADD  CONSTRAINT [FK_Station_subcategory] FOREIGN KEY([Subcategory_Id])
REFERENCES [dbo].[subcategory] ([Subcategory_Id])
GO
ALTER TABLE [dbo].[Station] CHECK CONSTRAINT [FK_Station_subcategory]
GO
ALTER TABLE [dbo].[subcategory]  WITH CHECK ADD  CONSTRAINT [FK_subcategory_category] FOREIGN KEY([Category_Id])
REFERENCES [dbo].[category] ([Category_Id])
GO
ALTER TABLE [dbo].[subcategory] CHECK CONSTRAINT [FK_subcategory_category]
GO
/****** Object:  StoredProcedure [dbo].[AddNewRadioStation]    Script Date: 8/9/2021 6:39:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddNewRadioStation]

(
@Station_Id int,
@Station_Name nvarchar(150)=null,
@Station_Image_Url nvarchar(150)=null,
@Category_Id int,
@Subcategory_Id int,
@Language_Id int
)

as


begin
insert into Station(Station_Id,Station_Name,Station_Image_Url,Category_Id,Subcategory_Id,Language_Id)
values (@Station_Id,@Station_Name,@Station_Image_Url,@Category_Id,@Subcategory_Id,@Language_Id);
end















GO
/****** Object:  StoredProcedure [dbo].[DeleteRadioStation]    Script Date: 8/9/2021 6:39:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteRadioStation]

(
@Station_Id int,
@Station_Name nvarchar(150)=null,
@Station_Image_Url nvarchar(150)=null,
@Category_Id int,
@Subcategory_Id int,
@Language_Id int
)

as

begin
DELETE FROM Station WHERE (Station_Id = @Station_Id)
end














GO
/****** Object:  StoredProcedure [dbo].[GetAllRadioStations]    Script Date: 8/9/2021 6:39:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllRadioStations]
as
	
begin
SELECT s.Station_Id,s.Station_Name,s.Station_Image_Url, c.Station_Category_Name , sb.Station_Type_Name,L.Language_Name
FROM Station s
JOIN category c ON s.Category_Id = c.Category_Id
JOIN subcategory sb ON s.Subcategory_Id = sb.Subcategory_Id
JOIN Language L ON s.Language_Id = L.Language_Id
end
GO
/****** Object:  StoredProcedure [dbo].[ManageRadioStation]    Script Date: 8/9/2021 6:39:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ManageRadioStation]

(
@check nchar(1),
@Station_Id int,
@Station_Name nvarchar(150)=null,
@Station_Image_Url nvarchar(150)=null,
@Category_Id int,
@Subcategory_Id int,
@Language_Id int
)

as

if @check ='a' begin 

insert into Station(Station_Id,Station_Name,Station_Image_Url,Category_Id,Subcategory_Id,Language_Id)
values (@Station_Id,@Station_Name,@Station_Image_Url,@Category_Id,@Subcategory_Id,@Language_Id);
end

if @check ='u' begin
update Station set

Station_Name = @Station_Name,
Station_Image_Url = @Station_Image_Url,
Category_Id = @Category_Id,
Subcategory_Id = @Subcategory_Id,
Language_Id = @Language_Id

where Station_Id = @Station_Id
end


if @check ='d' begin
DELETE FROM Station WHERE (Station_Id = @Station_Id)
end
return













GO
/****** Object:  StoredProcedure [dbo].[UpdateRadioStation]    Script Date: 8/9/2021 6:39:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateRadioStation]

(
@Station_Id int,
@Station_Name nvarchar(150)=null,
@Station_Image_Url nvarchar(150)=null,
@Category_Id int,
@Subcategory_Id int,
@Language_Id int
)

as
begin
update Station set

Station_Name = @Station_Name,
Station_Image_Url = @Station_Image_Url,
Category_Id = @Category_Id,
Subcategory_Id = @Subcategory_Id,
Language_Id = @Language_Id

where Station_Id = @Station_Id
end













GO
