// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio 1: operaciones aritmeticas");

Console.WriteLine("Ingrese un numero");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese otro numero");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese otro numero");
int c= Convert.ToInt32(Console.ReadLine());

double n3 = n1;
double n4 = n2; 
int suma = n1 + n2;
int resta = n1 - n2;
int multi = n1 * n2;
double division = (double)n1 / n2;
int div = n1 / n2;
int mod = n1 % n2;
Console.WriteLine(n1 + " + " + n2 + "=" + suma);
Console.WriteLine(n1 + " - " + n2 + "=" + resta);
Console.WriteLine(n1 + " * " + n2 + "=" + multi);
Console.WriteLine(n1 + " / " + n2 + "=" + division);
Console.WriteLine(n1 + " / " + n2 + "=" + div);
Console.WriteLine(n1 + " % " + n2 + "=" + mod);

Console.WriteLine("Ejercicio 2: operaciones boolaneas");

Console.WriteLine(n1 < n2);
Console.WriteLine(n1 > n2);
Console.WriteLine(n1 == n2);

Console.WriteLine("Ejercicio 3: jerarquia de operaciones");

int op1 = n1 * n2 + c;
int op2 = n1 * (n2 + c);
double op3 = n1 / (n2 * c);
double op4 = (3 * n1 + 2 * n2) / (c * c);
Console.WriteLine(n1 + " * " + n2 + " + " + c + " = " + op1);
Console.WriteLine(n1 + " * (" + n2 + " + " + c + ") = " + op2);
Console.WriteLine(n1 + " / " + n2 + " * " + c + " = " + op3);
Console.WriteLine("3("+n1 + ") + 2(" + n2 + ") / " + c + "^2 = " + op4);

Console.WriteLine("Ejercicio 4: resultado de una expresion cuadratica");
double raiz = Math.Sqrt((n2*n2)-4*n1*c);
double x = -n2 + raiz / (2 * n1);
double x2 = -n2 - raiz / (2 * n1);
Console.WriteLine("x1 es igual a "+x);
Console.WriteLine("x2 es igual a " + x2);