// See https://aka.ms/new-console-template for more information
using SOLID_OCP;

/*
 * 6 + 12.56 + 4 = 22.56
 */
CalculadorAreas cal = new CalculadorAreas(
    [new Rectangulo(2, 3), 
    new Circulo(2), 
    new Triangulo(4,2)]);
cal.TotalArea();
