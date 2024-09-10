# Crud Application Using C#
 
Desktop CRUD App Written In C#(.NET Framework)
 
 
## Preview
 ![Screenshot 2024-09-10 210308](https://github.com/user-attachments/assets/d33e751e-6f45-4868-80c1-156abecc19d0)
 
 
 
### Bulit With
- C#(.Net Framework)
- Microsoft Sql
- VS Code
 
 
## Features
 
- Insert Data
- Delete Data
- Update Data
- Search Data
 
 
## SQL Query
#### Design Table
```bash
  CREATE TABLE [dbo].[CATable] (
    [id]   INT          NOT NULL,
    [name] VARCHAR (50) NULL,
    [age]  FLOAT (53)   NULL,
    CONSTRAINT [PK_CATable] PRIMARY KEY CLUSTERED ([id] ASC)
);
```
#### Insert Data
```bash
INSERT INTO CATable(id, name, age) VALUES(@id, @name, @age)
```
#### Delete Data
```bash
DELETE CATable WHERE id=@id
```
#### Update Data
```bash
UPDATE CATable SET name=@name, age=@age WHERE id=@id
```
#### Search Data
```bash
SELECT * FROM CATable WHERE id=@id
```
## Tech Stack
 
**Programming Language:** C# <br><br>
**Database:** SQL Server<br><br>
**Framework:** Windows Forms<br><br>
**UI Components:** <br>
    -Text Box for entering data.<br>
    - Button for response.<br>
    - Data Grid View for displaying and managing data
 
 
## 🛠 Skills
C#, .NET, SQL..

