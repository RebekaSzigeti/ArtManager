# ArtManager

# Art Gallery Management Project

This project is a **Windows Forms application** in C# for managing artworks and artists. It connects to a SQL Server database and provides functionalities to:

- Search and filter artworks
- Update artwork prices
- Delete artworks
- List artists

- ## Database Setup

1. Create a **database named `Galéria`** on your SQL Server.
2. Open the files in the `SQL` folder and run them 
3. Make sure to update the connection string in `DALGen.cs` (`strSqlConn`) to point to your SQL Server instance and the `Galéria` database.

## Notes

- The project uses **parameterized SQL queries** to prevent SQL injection.
- Artwork prices have a version number (`Verzioszam`) to track changes.
