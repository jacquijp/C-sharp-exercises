//Code for solving circle area//variables must always start with a lowercasevar radius = 0d; //0 double -- implicit initial declarationvar result = 0d; // if i use 0 only, it can be mistaken as an int


// constants will always start with an uppercase
// const double Pi = 4.14;Console.WriteLine("Welcome!");Console.WriteLine("Cirle area calculator");//area = Pi * (radious*radius)Console.WriteLine("Type radious value");radius = Convert.ToDouble(Console.ReadLine());result = Math.PI * radius * radius; // in this case we're using a made class called Math.PI - But for other cases,
// we could create our own constant values. See example of constant variable created above. // And see how it'd be used below.//result = Pi * radius *  radius -- exampleConsole.WriteLine("Circle area is: " + result);