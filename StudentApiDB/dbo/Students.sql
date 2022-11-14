CREATE TABLE [dbo].[Students]
(
  [StudentId]        INT            IDENTITY (1, 1) NOT NULL,
    [fname]            VARCHAR (50)   NOT NULL,
    [lname]            VARCHAR (50)   NOT NULL,
    [age]              INT            NOT NULL,
    [dateOfEnrollment] DATE           NULL,
    [grade]            INT            NULL,
    [GPA]              DECIMAL (3, 2) NULL,
    PRIMARY KEY CLUSTERED ([StudentId] ASC)
)
