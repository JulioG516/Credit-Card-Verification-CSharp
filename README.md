# Credit Card Verification using Luhn Algorithm
This is a simple project in C# that implements the Luhn algorithm to verify the validity of a credit card number. The Luhn algorithm is a simple checksum formula used to validate a variety of identification numbers, including credit card numbers.

Luhn Algorithm
The Luhn algorithm is a simple checksum formula that can be used to validate a variety of identification numbers, such as credit card numbers, IMEI numbers, and National Provider Identifier numbers. The algorithm works by performing a series of steps on the digits of the number to be verified.

Starting from the rightmost digit and moving left, double every second digit.
If the result of a doubled digit is greater than or equal to 10, subtract 9 from the result.
Sum all the digits of the modified number.
If the sum is divisible by 10, the number is valid according to the Luhn formula.
Features
Verifies the validity of a credit card number using the Luhn algorithm
Implements the steps of the Luhn algorithm in C# code
Includes a user interface for inputting and verifying credit card numbers
Requirements
.NET Framework 4.7 or higher
Usage
To run the application, simply compile the source code using a C# compiler and run the executable. The user interface will appear and you can use the credit card verification tool by entering a credit card number and clicking the "Verify" button. The result of the verification will be displayed in the user interface.

Contributing
If you would like to contribute to this project, feel free to fork the repository and make pull requests with your changes.

License
This project is licensed under the MIT License. See the LICENSE file for more information.
