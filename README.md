Password Manager is a simple console application for managing passwords for various websites and services.

Upon running the application, the user is presented with three options:
Add Password
View Password
Quit

The user can choose to add a password by providing the name of the website or service and the password itself. The password will then be hashed using the SHA256 algorithm and stored in the application's memory.
To view a password, the user must provide the name of the website or service. If the website or service is found, the hashed password will be displayed.
The user can choose to quit the application at any time by selecting the "Quit" option.

Nite:

The passwords are hashed using the SHA-256 algorithm and then encoded as a Base64 string to be stored in a text form.The application allows for adding and displaying passwords.
