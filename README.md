# CMPG-323-Project-2---25023055
This is my project to linked to the main project of my journey in CMPG 323 for my 5 projects. 


# Branching Strategy with diagram
When we look at we can look at all 5 projects, we will have one main project with all the Mile Stones and tasks that will be linked to 4 different repositories and the 5 repositories will be split entirely from each other, we will fork a repository of the similarities are the same and we can save time. Please see the image below.

![image](https://user-images.githubusercontent.com/90190484/185092065-9e8c4664-c915-4ff0-8a6e-54a6cf513078.png)

# Gitignore
We will use 1 single file per repository to save all the password information but will upload a dummy file so that anyone can change the password and username then everything will start working. The file will be called Autentication_Share, we will save all our details in the real Authentication file, but will not share it on Github, thus all the user has to do is rename the Authentication_Share file to the original name and everything should start working.

# Storage of credentials and sensitive information
We will store our authentication details in a text file, for now, we may move it to a database with all the details.

# Referencing used information
All the info I get from any 3rd parties will be referenced in the text and the links can be found in my referencing document found at CMPG-323-Overview-25023055/Referencing Document

# API Documentation

No credentials are stored in the code, please see and example of the files you can add appsettings.json

{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "ConnStr": "yourconnection string"
  },
  "JWT": {
    "ValidAudience": "http://localhost:4200",
    "ValidIssuer": "http://localhost:61955",
    "Secret": "your secret"
  }

}
 
All the endpoints are gaurded by authentications

Some tables are gaurded by admin auth and some users have access

Applying the [Authorize] attribute to a controller, action, or Razor Page, limits access to that component to authenticated users.

BG Bester 25023055
