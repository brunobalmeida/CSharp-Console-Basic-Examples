Example 6 - Save and Load files 

Create a C# Console program that will demonstrate the use of File IO, Arrays.

1.Write a program that functions as a concert/restaurant/airplane/etc. reservation system. This system must be sufficiently complex, with a minimum of 4 rows with 4 seats in each row. You must display the seats on the screen in some manner and indicate which are available and which are taken, it is up to you to decide how to do this. You may display the seating in any display format that you feel is appropriate as long as it logically conveys the information to the user. 

Example seating chart:

*************************************
*Seat 1-1*Seat 1-2*Seat 1-3*Seat 1-4*
*Seat 2-1*Seat 2-2*Seat 2-3*Seat 2-4*
*Seat 3-1*Seat 3-2*Seat 3-3*Seat 3-4*
*Seat 4-1*Seat 4-2*Seat 4-3*Seat 4-4*
*************************************

2. Allow the user the following options:
a. Add a customer to the seating plan                                                                            
i. Request the customer's name
ii. Display a list of the seats in the venue
iii. If seats are available, let the customer choose a seat. Add the customer to the seating chart on the application.
For example, after adding a customer the seating chart would become:
*************************************
*Seat 1-1*Seat 1-2*Seat 1-3*S. Claus*
*Seat 2-1*Seat 2-2*Seat 2-3*Seat 2-4*
*Seat 3-1*Seat 3-2*Seat 3-3*Seat 3-4*
*Seat 4-1*Seat 4-2*Seat 4-3*Seat 4-4*
*************************************

iv. If no seats are available, inform the user
b. Remove a customer from the seating plan                                                                  
i. Request the customer's name or seat number
ii. Search the seating chart for the customer's name or seat number and delete it

3. Your system should show validation whenever appropriate, and function in a logical manner. For example, the system should not shut down after each operation, if a user has to fix an entry the system should not start over, etc.                                                                                            

4. Your system should also have File IO such that the reserved seats with who reserved them is not lost when your program shuts down.                                                                                  
