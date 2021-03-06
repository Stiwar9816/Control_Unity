USE [control_unity]
GO
/****** Object:  Table [dbo].[booking_teacher]    Script Date: 3/01/2019 5:01:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[booking_teacher](
	[id_booking] [int] IDENTITY(1,1) NOT NULL,
	[cc_teacher] [nvarchar](50) NOT NULL,
	[nom_teacher] [nvarchar](50) NOT NULL,
	[programa_teacher] [nvarchar](50) NOT NULL,
	[datetime_in_teacher] [datetime] NOT NULL,
	[datetime_out_teacher] [datetime] NOT NULL,
	[reserve_implements_teacher] [nvarchar](50) NOT NULL,
	[reserve_salon_teacher] [nvarchar](50) NOT NULL,
	[delivered_by_teacher] [nvarchar](50) NOT NULL,
	[received_by_teacher] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_payment] PRIMARY KEY CLUSTERED 
(
	[id_booking] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[booking_user]    Script Date: 3/01/2019 5:01:18 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[booking_user](
	[id_user] [int] NOT NULL,
	[cc_user] [int] NOT NULL,
	[nom_user] [nvarchar](50) NOT NULL,
	[program_user] [nvarchar](50) NULL,
	[datetime_in_user] [datetime] NOT NULL,
	[datetime_out_user] [datetime] NOT NULL,
	[reserve_implements_user] [nvarchar](50) NOT NULL,
	[reserve_salon_user] [nvarchar](50) NOT NULL,
	[delivered_by_user] [nvarchar](50) NOT NULL,
	[received_by_user] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_otherUsers] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[implements]    Script Date: 3/01/2019 5:01:19 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[implements](
	[id_implements] [int] IDENTITY(1,1) NOT NULL,
	[cod_serie] [nvarchar](50) NOT NULL,
	[nom_implements] [nvarchar](50) NOT NULL,
	[datetime_register_implements] [datetime2](0) NOT NULL,
	[stock_implements] [int] NOT NULL,
	[brand] [nvarchar](50) NOT NULL,
	[description_implements] [nvarchar](50) NULL,
 CONSTRAINT [PK_implements_1] PRIMARY KEY CLUSTERED 
(
	[id_implements] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[salons]    Script Date: 3/01/2019 5:01:19 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[salons](
	[id_salon] [int] IDENTITY(1,1) NOT NULL,
	[nom_salon] [nvarchar](50) NOT NULL,
	[description_salon] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_salons] PRIMARY KEY CLUSTERED 
(
	[id_salon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[teacher]    Script Date: 3/01/2019 5:01:19 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[teacher](
	[id_teacher] [int] IDENTITY(1,1) NOT NULL,
	[cc_teacher] [int] NOT NULL,
	[nom_teacher] [nvarchar](50) NOT NULL,
	[program_teacher] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_profesores] PRIMARY KEY CLUSTERED 
(
	[id_teacher] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 3/01/2019 5:01:19 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id_user] [int] IDENTITY(1,1) NOT NULL,
	[cc_user] [int] NOT NULL,
	[nom_user] [nvarchar](50) NOT NULL,
	[password_user] [nvarchar](50) NOT NULL,
	[email_user] [nvarchar](50) NOT NULL,
	[datetime_user] [datetime] NOT NULL,
	[rol_user] [nvarchar](50) NOT NULL,
	[privilege_user] [int] NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[implements] ON 

INSERT [dbo].[implements] ([id_implements], [cod_serie], [nom_implements], [datetime_register_implements], [stock_implements], [brand], [description_implements]) VALUES (1, N'001', N'Video Beam', CAST(N'1900-01-01T00:00:00.0000000' AS DateTime2), 4, N'Epson', N'Puerto HDMI')
INSERT [dbo].[implements] ([id_implements], [cod_serie], [nom_implements], [datetime_register_implements], [stock_implements], [brand], [description_implements]) VALUES (2, N'002', N'Portatil', CAST(N'1900-01-01T00:00:00.0000000' AS DateTime2), 3, N'Lenovo', N'Negro')
INSERT [dbo].[implements] ([id_implements], [cod_serie], [nom_implements], [datetime_register_implements], [stock_implements], [brand], [description_implements]) VALUES (3, N'003', N'Marcador', CAST(N'1900-01-01T00:00:00.0000000' AS DateTime2), 2, N'Prueba', N'negro')
SET IDENTITY_INSERT [dbo].[implements] OFF
SET IDENTITY_INSERT [dbo].[salons] ON 

INSERT [dbo].[salons] ([id_salon], [nom_salon], [description_salon]) VALUES (1, N'Sala de sistemas 1', N'30 equipos de computo')
INSERT [dbo].[salons] ([id_salon], [nom_salon], [description_salon]) VALUES (2, N'Salon 101', N'Cupo para 30 personas, 3 puertos de red')
INSERT [dbo].[salons] ([id_salon], [nom_salon], [description_salon]) VALUES (1002, N'Salon 102', N'adsadsad')
INSERT [dbo].[salons] ([id_salon], [nom_salon], [description_salon]) VALUES (1003, N'asdasda', N'')
INSERT [dbo].[salons] ([id_salon], [nom_salon], [description_salon]) VALUES (1004, N'sdfsd', N'xzczxcz')
SET IDENTITY_INSERT [dbo].[salons] OFF
SET IDENTITY_INSERT [dbo].[teacher] ON 

INSERT [dbo].[teacher] ([id_teacher], [cc_teacher], [nom_teacher], [program_teacher]) VALUES (1005, 95022421, N'Andres Perez', N'Ingeniria Industrial')
INSERT [dbo].[teacher] ([id_teacher], [cc_teacher], [nom_teacher], [program_teacher]) VALUES (1006, 1002142151, N'Jorge Lopez', N'Ingles')
INSERT [dbo].[teacher] ([id_teacher], [cc_teacher], [nom_teacher], [program_teacher]) VALUES (1007, 950024122, N'Carlos stiwar apsrilla mosquera', N'Trabajo Social')
INSERT [dbo].[teacher] ([id_teacher], [cc_teacher], [nom_teacher], [program_teacher]) VALUES (1008, 230532882, N'Andres Mosquera', N'Ingeniria sistemas')
INSERT [dbo].[teacher] ([id_teacher], [cc_teacher], [nom_teacher], [program_teacher]) VALUES (1009, 120302112, N'Manuel Moya', N'Ingeniria Industrial')
INSERT [dbo].[teacher] ([id_teacher], [cc_teacher], [nom_teacher], [program_teacher]) VALUES (1010, 971212424, N'Jhon Moreno', N'Ingeniria Industrial')
INSERT [dbo].[teacher] ([id_teacher], [cc_teacher], [nom_teacher], [program_teacher]) VALUES (2002, 356001232, N'Jorge Molina', N'Ingles')
SET IDENTITY_INSERT [dbo].[teacher] OFF
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([id_user], [cc_user], [nom_user], [password_user], [email_user], [datetime_user], [rol_user], [privilege_user]) VALUES (1, 1003929968, N'Carlos Siwar Asprilla Mosquera', N'1234', N'stiwar.asprilla1998@gmail.com', CAST(N'1900-01-01T00:00:26.670' AS DateTime), N'Developer', 0)
SET IDENTITY_INSERT [dbo].[users] OFF
/****** Object:  Index [IX_cc_otherUsers]    Script Date: 3/01/2019 5:01:19 p. m. ******/
ALTER TABLE [dbo].[booking_user] ADD  CONSTRAINT [IX_cc_otherUsers] UNIQUE NONCLUSTERED 
(
	[cc_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_cod_serie_implements]    Script Date: 3/01/2019 5:01:19 p. m. ******/
ALTER TABLE [dbo].[implements] ADD  CONSTRAINT [IX_cod_serie_implements] UNIQUE NONCLUSTERED 
(
	[cod_serie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_profesores]    Script Date: 3/01/2019 5:01:19 p. m. ******/
ALTER TABLE [dbo].[teacher] ADD  CONSTRAINT [IX_profesores] UNIQUE NONCLUSTERED 
(
	[cc_teacher] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_cc_user]    Script Date: 3/01/2019 5:01:19 p. m. ******/
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [IX_cc_user] UNIQUE NONCLUSTERED 
(
	[cc_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_email]    Script Date: 3/01/2019 5:01:19 p. m. ******/
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [IX_email] UNIQUE NONCLUSTERED 
(
	[email_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SP_BUSCAR_PROFESOR]    Script Date: 3/01/2019 5:01:19 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_BUSCAR_PROFESOR]
@cc_teacher INT
AS
BEGIN
SELECT cc_teacher, nom_teacher, program_teacher
FROM teacher WHERE cc_teacher LIKE '%'+@cc_teacher+'%'
END
GO
/****** Object:  StoredProcedure [dbo].[SP_REGISTAR_PROFESOR]    Script Date: 3/01/2019 5:01:19 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REGISTAR_PROFESOR]
@cc_teacher int,
@nom_teacher NVARCHAR(50),
@program_teacher NVARCHAR(50),
@ultimo_id INT OUTPUT
as
begin 
INSERT INTO teacher(cc_teacher, nom_teacher, program_teacher) VALUES (@cc_teacher,@nom_teacher,@program_teacher)
SET @ultimo_id = SCOPE_IDENTITY()
RETURN @ultimo_id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_REGISTRAR_IMPLEMENTO]    Script Date: 3/01/2019 5:01:19 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REGISTRAR_IMPLEMENTO]
@cod_serie NVARCHAR(50),
@nom_implements NVARCHAR(50),
@datetime_register_implements DATETIME2(0),
@stock_implements INT ,
@brand NVARCHAR(50),
@description_implements NVARCHAR(50),
@ultimo_id INT OUTPUT
AS 
BEGIN
INSERT INTO implements (cod_serie, nom_implements, datetime_register_implements, stock_implements, brand, description_implements)
VALUES (@cod_serie,@nom_implements,@datetime_register_implements,@stock_implements,@brand,@description_implements)
SET @ultimo_id = SCOPE_IDENTITY()
RETURN @ultimo_id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_REGISTRAR_SALON]    Script Date: 3/01/2019 5:01:19 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REGISTRAR_SALON]
@nom_salon NVARCHAR(50),
@description_salon NVARCHAR(50),
@ultimo_id INT OUTPUT
as
begin
INSERT INTO salons (nom_salon, description_salon)
VALUES(@nom_salon,@description_salon)
SET @ultimo_id = SCOPE_IDENTITY()
RETURN @ultimo_id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_REGISTRAR_USUARIO]    Script Date: 3/01/2019 5:01:19 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REGISTRAR_USUARIO]
@cc_user INT,
@nom_user NVARCHAR(50),
@password_user NVARCHAR(50),
@email_user NVARCHAR(50),
@datetime_user TIMESTAMP,
@rol_user NVARCHAR(50),
@privilege_user INT,
@ultimo_id INT OUTPUT
AS 
BEGIN
INSERT INTO users (cc_user, nom_user, password_user, email_user, datetime_user, rol_user, privilege_user)
VALUES (@cc_user,@nom_user,@password_user,@email_user,@datetime_user,@rol_user,@privilege_user)
SET @ultimo_id = SCOPE_IDENTITY()
RETURN @ultimo_id
END
GO
/****** Object:  StoredProcedure [dbo].[SPIniciarSesion]    Script Date: 3/01/2019 5:01:19 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPIniciarSesion]
@Usuario nvarchar(50),
@Password nvarchar(50)
as
SELECT * FROM users
WHERE cc_user=@Usuario AND password_user=@Password;
GO
