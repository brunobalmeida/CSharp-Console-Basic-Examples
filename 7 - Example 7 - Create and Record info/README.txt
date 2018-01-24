Example 7 - Basic Class fundamentals

Create a C# console program that creates and records information about a dog. When the program is run, the following main menu is displayed:

A. Display the name, breed, colour, and gender of the dog (if one already exists)
B. Add a new dog
C. Edit an existing dog
D. Exit the program

After a choice from the main menu is selected:
* The program accurately performs the necessary operations and returns to the main menu unless option "D" is selected. 
* For option "A" the program displays the name, breed, colour and gender of the dog. The program displays "No dog record exists" when no dog has previously been added. [2 points]
* For option "B" the program displays "Dog record already exists" when a dog has previously been created. Otherwise, the program prompts the user to input the following information for the dog:
* Name 
* Breed
* Colour 
* Gender [Must validate to be a "Male" or "Female"] 
In case of an invalid input, the user is prompted to re-enter the value until a valid value has been entered. 
* For option "C" if no dog record exists, the program displays "No dog record exists." When a dog record does exist, display a list of the dog's name, breed, colour and gender, and prompt the user to enter new values for each. Perform the same validation for the new values as done for option "B." 
In your program, you must create and use a C# class that represents the dog record using appropriate fields and methods. Your class must not have any public fields. You must create this file as a separate file. 

Your class has, at a minimum, two public methods with the following names: 
* DisplayDogInformation
* EditDogInformation

Your class has a non-default constructor that is used to initialize the dog record information. 
Your class has a default constructor (even if it is not used by your program)
Note: The purpose of this assignment is to apply your knowledge of C# classes. If your program does not contain a separate class for "dog record," no credit is given for this assignment. 