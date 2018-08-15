## Project Files
All files are located in **ConsoleApp1** folder. Solution has 2 projects: **LoanCalculator** and **UnitTest**.

## Unit Testing
This project is just an example of how you can create a C# solution with unit test project.
Many developers mentioned that unit tests won't make software bug-free, but they would help to verify the behavior of tested code, 
and make it less stressful when we need to make a change to our code.

## Testing Tool
I'm using unit test project template of Visual Studio 2017 to test my application.  
To run all tests in VS 2017 select Menu **Test -> Run -> All Tests.**  
Alternatively, user may select to run only Failed Tests or Selected Test.

## Separation of Concerns
I've purposely simplified Wallet class to avoid adding multiple credit cards objects. 
All cards are added at once during the creation of object. This is because this challenge is about unit testing, 
and not about perfect OO class design.

## What would I do differently, starting from scratch?
I would redesigned Wallet class to have lists of cards, similar to the Person class. 
There should probably be more data for each user and wallet. 


