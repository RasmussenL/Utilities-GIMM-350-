/*int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);

c = a - b;
Console.WriteLine(c);

c = a * b;
Console.WriteLine(c);

c = a / b;
Console.WriteLine(c);

a = 5;
b = 4;
c = 2;
int d = a + b * c;
//Multiplication and division take precedence over addition and subtraction
Console.WriteLine(d);

a = 5;
b = 4;
c = 2;
d = (a + b) * c;
Console.WriteLine(d);

d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
Console.WriteLine(d);

a = 7;
b = 4;
c = 3;
d = (a  + b) / c;
int e = (a + b) % c;
//You can get the remainder by using the modulo operator, the % character
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");

//int max = int.MaxValue;
//int min = int.MinValue;
//important for data type, these are the restraints of int
//Console.WriteLine($"The range of integers is {min} to {max}");

//int what = max + 3;
//Console.WriteLine($"An example of overflow: {what}");
//Notice that the answer is very close to the minimum (negative) integer. It's the same as min + 2. The addition operation overflowed the allowed values for integers. The answer is a very large negative number because an overflow "wraps around" from the largest possible integer value to the smallest.

double aa = 5;
double bb = 4;
double cc = 2;
double dd = (aa  + bb) / cc;
Console.WriteLine(d);
//The double numeric type represents a double-precision floating point number. Those terms may be new to you. A floating point number is useful to represent non-integral numbers that may be very large or small in magnitude.

//double max = double.MaxValue;
//double min = double.MinValue;
//Console.WriteLine($"The range of double is {min} to {max}");

double third = 1.0 / 3.0;
Console.WriteLine(third);
//Just like decimal numbers in math, doubles in C# can have rounding errors.*/

decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min} to {max}");
//The decimal type has a smaller range but greater precision than double. The term fixed point means that the decimal point (or binary point) doesn't move.

double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);
//The M suffix on the numbers is how you indicate that a constant should use the decimal type.

double radius = 2.50;
double area = Math.PI * radius * radius;
Console.WriteLine(area);
//Calculates the area of a circle with the radius 2.5
