CREATE TABLE Users (
    ID INT PRIMARY KEY,
    Name VARCHAR(50),
    Age INT
);

INSERT INTO Users (ID, Name, Age) VALUES (1, 'Alice', 25);
INSERT INTO Users (ID, Name, Age) VALUES (2, 'Bob', 30);
SELECT * FROM Users;