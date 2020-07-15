USE MvcMovieContext
GO

CREATE TABLE Movie ( ID INT IDENTITY(1,1),
					Genre NVARCHAR(MAX) NULL,
					Price DECIMAL(18,0) NOT NULL,
					ReleaseDate DATETIME NOT NULL,
					Title NVARCHAR(MAX) NULL,
					CONSTRAINT PK_Movie PRIMARY KEY (ID ASC) )
GO
GO

INSERT INTO dbo.Movie
(
    Genre,
    Price,
    ReleaseDate,
    Title
)
VALUES
(   N'Phim Truyền Hình',       -- Genre - nvarchar(max)
    168000,      -- Price - decimal(18, 0)
    '01/01/1986', -- ReleaseDate - datetime
    N'Tây Du Ký'        -- Title - nvarchar(max)
    )

INSERT INTO dbo.Movie
(
    Genre,
    Price,
    ReleaseDate,
    Title
)
VALUES
(   N'Siêu anh hùng',       -- Genre - nvarchar(max)
    210000,      -- Price - decimal(18, 0)
    '01/19/2013', -- ReleaseDate - datetime
    N'Deadpool'        -- Title - nvarchar(max)
    )
INSERT INTO dbo.Movie
(
    Genre,
    Price,
    ReleaseDate,
    Title
)
VALUES
(   N'Hành Động',       -- Genre - nvarchar(max)
    175000,      -- Price - decimal(18, 0)
    '11/09/2016', -- ReleaseDate - datetime mm/dd/yyyy
    N'Hai Phượng'        -- Title - nvarchar(max)
    )