# DMS - Online Shopping Task

Foobar is a Python library for dealing with word pluralization.

## Technologies

* .Net Core MVC
* Entity framework CodeFirst
* DinkToPDF
* SQL Server


## Installation
 
before you run, make sure that you configured you sql server connection settings in appsettings.json file.
You can import database backup data from dms_db_1.bacpac.
In case you created a database without import the backup file, you will need to edit IsAdmin column in Customer Table after registration to change your account to be Admin.


## Usage

Admin
```python
Username: admin
Password: 123456
```
User
```python
Username: user
Password: 123456
```

## New
* Roles Middleware to prevent normal users to access Admin URLs
* Replace Ids with Names in admin panel
* Fixing Bugs