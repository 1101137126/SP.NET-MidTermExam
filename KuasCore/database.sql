
CREATE DATABASE [KUAS]
GO

USE [KUAS]
GO

CREATE TABLE [dbo].[Course](
	[CourseID]   [nvarchar](20) NOT NULL,
	[CourseName] [nvarchar](200) NOT NULL,
	[CourseDescription]  [nvarchar](1000) NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT [dbo].[Course] ([CourseID], [CourseName], [CourseDescription]) VALUES (N'1'  , N'C#', N'學C#');
INSERT [dbo].[Course] ([CourseID], [CourseName], [CourseDescription]) VALUES (N'2', N'ASP', N'學ASP.NET');
INSERT [dbo].[Course] ([CourseID], [CourseName], [CourseDescription]) VALUES (N'3'  , N'HTML5', N'學HTML5');
GO
