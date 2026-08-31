-- 1. Switch to your database
USE StudentManagementDB;
GO

-- 2. View all data in the table
SELECT * FROM Students;

-- 3. View the table structure (columns, data types, nullability)
EXEC sp_help Students;

-- 4. View applied EF Core migrations
SELECT * FROM __EFMigrationsHistory;