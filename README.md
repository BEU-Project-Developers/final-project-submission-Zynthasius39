# BankingAPP

## Gringotts Wizarding Bank

### Key Features

 - Account managment
    - Delete Account
    - Change Password
 - Bank Account managment
    - Quick Pay
    - Transfer
    - Freeze account
    - Exchange currency
    - Donate
 - Moderator dashboard
 - Modern & Responsive design
 - Dynamic bank accounts, payments, transcation history

**IDE:** Microsoft Visual Studio 2022
- .NET 9.0
- Windows Forms
- MaterialUI Framework
- Npgsql
- Postgres Database


### Database

You need a Postgres server. You can deploy one with Docker, or install with an isntaller

**DB:** PostgreSQL 17.2
- Debian 17.2-1.pgdg120+1
- on Docker
    - docker.io/library/postgres:latest

#### Docker/Podman run command:
```bash
podman run -d --name bankingdb -v $(pwd)/logintest:/
var/lib/postgresql -p 55433:5432 -e POSTGRES_PASSWORD=S3CUREP4SSW0RD docker.io/postgres:latest
```

#### Restoring PostgreSQL Database using SQL Dumps

Using CLI
```bash
psql -U postgres -d postgres < postgres-202501211801.sql
```
Using DBeaver
```bash
 - Add new PostgreSQL database connection
 - Right click on default (postgres) database
 - Tools > Restore > Backup file
 - Select one of SQL files (postgres-202501211801.sql)
 - Start (You may ignore warnings)
```

### Demo User
E-Mail & Password: 
```bash
zuleyxa@proton.me
1234
```

### Enable offline users
```c#
...
// Uncomment to enable offline mode
//Customer customer = FormHelpers.OfflineUser;
// Comment next line too
Customer customer = CustomerService.GetCustomer(email_box.Text.Trim());
...
-----------------------
    LoginForm.cs Ln:164
```
Don't forget to change Connection String in **app.config**. Enjoy

### Screenshots

![image](https://github.com/user-attachments/assets/ac562720-764a-4bd3-9524-51fc9b820648)
![image](https://github.com/user-attachments/assets/e91d7b1e-d01d-437d-8997-9b72990f5f28)
![image](https://github.com/user-attachments/assets/752c01ec-66c6-4954-bd87-6f6a7c707bbc)
![image](https://github.com/user-attachments/assets/21d39238-ecb9-4dde-a625-c14ddfe2fee9)