//Code for solving circle area

var radius = 0d; //0 double -- implicit initial declaration
var result = 0d; // if i use 0 only, it can be mistaken as an int

Console.WriteLine("Welcome!");
Console.WriteLine("Cirle area calculator");
//area = Pi * (radious*radius)
Console.WriteLine("Type radious value");
radius = Convert.ToDouble(Console.ReadLine());

result = Math.PI * radius * radius;

Console.WriteLine("Circle area is: " + result);
