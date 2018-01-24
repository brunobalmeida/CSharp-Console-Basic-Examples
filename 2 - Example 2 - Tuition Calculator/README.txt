Example 2 - Tuition calculator - Console Application

Create a C# Console Application project to compute the tuition fee a student should pay.
You are required to create a C# Console Application project.

Step 1: Ask if a student is a Canadian Citizen or an International Student. Also ask for their age. You must use an If-Else-Elseif statement.
Logic:
* If the student's age is 18 or below, they must pay $300 + 13% HST
* If the student is aged 19 to 49, they must pay $500 + 13% HST
* If the student is aged 50 or above, they must pay $400 + 13% HST
* If the student is an international student, they must pay an extra $100 before tax is applied.

Step 2: Ask for the month the student registered. You must use a switch statement.
Logic:
* If they registered in any of the Fall months (Sept., Oct., Nov., or Dec.), add $250 + 13% HST
* If they registered in any of the Winter months (Jan., Feb., Mar. or Apr.), add $220 + 13% HST
* If they registered in any of the Summer months (May, Jun., Jul. or Aug.), add $150 + 13% HST

Calculate the total tuition a student owes by adding up the value obtained in Step 1 and Step 2.
Show the total tuition fee on the C# Console application. The display will look something contain:

The Student's age (as entered)
International Student (or not) (as entered)
Registration Semester (as entered)
Base Tuition (as calculated by the application)
International Student fee (if applicable, as calculated by the application)
Registration Fee for semester (as calculated by the application)
HST (as calculated by the application)
Final Total (as calculated by the application)