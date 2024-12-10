// Exercises to practice C# Course

//This code calculates the area of a rectangle or quarter

//Declaration of variables explicitly
//double sideA;
//double sideB;
//double result;

//Declaration of variables implicit
var sideA = 0.0;
var sideB = 0.0;
var result = 0.0;

Console.WriteLine("Rectangle and quarter area calculator");

Console.WriteLine("Type the side A value: ");
sideA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Type the side B value: ");
sideB = Convert.ToDouble(Console.ReadLine());

result = sideA * sideB;
Console.WriteLine("Side A is: " + sideA + " Side B is: " + " Area = " + result);




