# Crud Application Using C#
 
Desktop CRUD App Written In C#(.NET Framework)
 
 
## Preview
 ![Screenshot 2024-09-10 210308](https://github.com/user-attachments/assets/d33e751e-6f45-4868-80c1-156abecc19d0)
 
 
 
### Bulit With
- C#(.Net Framework)
- Microsoft Sql
- Visual Studio 2022
 
 
## Features
 
- Add Data
- Update Data
- Delete Data
- Clear Data
- Empty table Data
 
 
## SQL Query
#### Design Table
```bash
CREATE TABLE [dbo].[Contact] (
    [Contact ID] INT           NOT NULL,
    [First Name] NVARCHAR (50) NOT NULL,
    [Last Name]  NVARCHAR (50) NOT NULL,
    [Contact No] NVARCHAR (50) NOT NULL,
    [Gender]     NVARCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([Contact ID] ASC)
);
```
#### Add Data
```bash
"INSERT INTO Contact ([Contact ID], [First Name], [Gender], [Last Name], [Contact No]) " +
                "VALUES ('" + ContactIdTb.Text + "', '" + FirstNameTb.Text + "', '" + GenderCb.SelectedItem.ToString() + "', '" + LastNameTb.Text + "', '" + ContactNoTb.Text + "')";

```
#### Updata Data
```bash
"UPDATE Contact SET [First Name] = '" + FirstNameTb.Text + "', [Last Name] = '" + LastNameTb.Text + "', [Contact No] = '" + ContactNoTb.Text + "', [Gender] = '" + GenderCb.SelectedItem.ToString() + "' WHERE [Contact ID] = '" + ContactIdTb.Text + "'";

```
#### Delete Data
```bash
"DELETE FROM Contact WHERE [Contact ID] = '" + ContactIdTb.Text + "'";

```
#### Clear Data
```bash
ContactIdTb.Clear();
FirstNameTb.Clear();
  LastNameTb.Clear();
  ContactNoTb.Clear();
  GenderCb.SelectedIndex = -1;
```
#### Empty table Data
"DELETE FROM Contact";
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

