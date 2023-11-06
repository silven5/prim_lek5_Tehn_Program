// See https://aka.ms/new-console-template for more information
using prim2_lek5.Class;

IFigure ob1;
IFigure2D ob2;
Triangle ob3;
Rigth_Triangle ob4;
ob1 = new Rigth_Triangle(3, 4);
ob2 = new Rigth_Triangle(5, 6);
ob3 = new Rigth_Triangle(6, 7);
ob4 = new Rigth_Triangle(3, 4);
Console.WriteLine("Name = " + ob1.Name);
Console.WriteLine("S = " + ob1.S().ToString());
Console.WriteLine("P = " + ob2.P().ToString());
Console.WriteLine("r = " + ob3.r().ToString());
Console.WriteLine(ob4.C());
ob1 = new Cube();
Console.WriteLine("Name = " + ob1.Name);
var ob5=new Cube();
ob5.V();


