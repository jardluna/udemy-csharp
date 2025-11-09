using _62HerancaComInterface.Entities;
using _62HerancaComInterface.Entities.Interfaces;
using System.Drawing;
using Rectangle = _62HerancaComInterface.Entities.Rectangle;

IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };

Console.WriteLine(s1);
Console.WriteLine(s2);