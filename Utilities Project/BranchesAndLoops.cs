/* int a = 5;
int b = 3;
//basic if statement structure
if (a + b > 10)
{
    Console.WriteLine("The answer is greater than 10");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
}*/

/* int a = 5;
int b = 3;
int c = 4;
//&& means  "and also"
if ((a + b + c > 10) && (a == b))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to the second");
}*/

/* int a = 5;
int b = 3;
int c = 4;
//|| means "or"
if ((a + b + c > 10) || (a == b))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("Or the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("And the first number is not equal to the second");
}*/

/* 
//WHILE LOOP
//The while statement checks a condition and executes the statement following the while. It will repeat checking the condition and executing those statements until the condition is false.
int counter = 0;
while (counter < 10)
{
  Console.WriteLine($"Hello World! The counter is {counter}");
  counter++;
  //increment operator
}*/

/* 
//DO WHILE LOOP
//he do ... while loop executes the code first, and then checks the condition. 
int counter = 0;
do
{
  Console.WriteLine($"Hello World! The counter is {counter}");
  counter++;
} while (counter < 10);
*/

/* 
//FOR LOOP
//he first part is the for initializer: int counter = 0; declares that counter is the loop variable, and sets its initial value to 0.
//The middle part is the for condition: counter < 10 declares that this for loop continues to execute as long as the value of counter is less than 10.
//The final part is the for iterator: counter++ specifies how to modify the loop variable after executing the block following the for statement. Here, it specifies that counter should be incremented by 1 each time the block executes.
for(int counter = 0; counter < 10; counter++)
{
  Console.WriteLine($"Hello World! The counter is {counter}");
}
*/

int sum = 0;
for (int number = 1; number < 21; number++)
{
  if (number % 3 == 0)
  {
    sum = sum + number;
  }
}
Console.WriteLine($"The sum is {sum}");
//loop used to see if a number is divisible by 3