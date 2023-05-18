# OAuthPOC
## JwtDemo
This acts as the remote server which is responsible for generating token and sending it to the **ConsumingAPI** project.
## ConsumingAPI
This is the main project. The **LoginController** has a Login method which inputs the username and password and consumes the **JwtDemo** and gets the token from there.
## Users
Username  | Password | Role
------------- | ------------- | -------------
Ramu  | password | Admin
Shyamu  | password | User

The full user details are in the **UserConstants.cs** in JwtDemo
