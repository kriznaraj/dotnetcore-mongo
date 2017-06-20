# dotnet core + mongod user regsitration sample

dotnet core + mongod user regsitration sample

To run
Setup mongo db
1) To run server
 - mongod --port 27017 --dbpath ..\mongodb\db

2) Makesure you have created an admin user
currently it is configured with admin:abc123!
use admin
db.createUser(
 {
	user: "admin",
	pwd: "abc123!",
	roles: [ { role: "root", db: "admin" } ]
  }
);
exit;

3) Add a collection named User

4) Install nuget dependencies
- dotnet restore

5) Run the app
- dotnet build
- dotnet run


