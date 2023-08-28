

using ConsoleApp2;
//Pointer p = new Pointer(1, 5);
//p.showData();
//Console.WriteLine(p.ToString());




//--------------------------------------------//

//Counter a=new Counter(0,100);
//Console.WriteLine(a.getCurrent());
//a.increment();
//Console.WriteLine(a.getCurrent());
//a.decrement();
//Console.WriteLine(a.getCurrent());
//a.decrement();
//Console.WriteLine(a.getCurrent());
//a.increment();
//Console.WriteLine(a.getCurrent());
Fraction a = new Fraction(3, 4);
Fraction b = new Fraction(2, 3);

Fraction result = a.Add(b); 
Console.WriteLine(result.ToString());

result = a.Multiply(b);
Console.WriteLine(result.ToString());

result = a.Divide(b); 
Console.WriteLine(result.ToString());

result = a.Subtract(b); 
Console.WriteLine(result.ToString());

