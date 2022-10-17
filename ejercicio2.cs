// Ejercicio 1

using System.Globalization;

Console.WriteLine("Nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine("Apellido: ");
string apellido = Console.ReadLine();
Console.WriteLine("Edad: ");
int edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sabe programar?");
bool sabe_programar = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("Nombre: " + nombre);
Console.WriteLine("Apellido: " + apellido);
Console.WriteLine("Edad: " + edad);
Console.WriteLine("Sabe programar: " + sabe_programar);

// Ejercicio 2

int puertas = 6;
int ruedas = 4;
string marca = "Chevrolet";
bool ITV_vigente = true;

float peso = 12.5f;
float largo = 20.5f;
String material = "madera";
String color = "verde";

Console.WriteLine("Objeto Coche");
Console.WriteLine("Puertas: " + puertas);
Console.WriteLine("Ruedas: " + ruedas);
Console.WriteLine("Marca: " + marca);
Console.WriteLine("ITV Vigente: " + ITV_vigente);

Console.WriteLine("Objeto Mesa");
Console.WriteLine("Peso: " + peso);
Console.WriteLine("Largo: " + largo);
Console.WriteLine("Material: " + material);
Console.WriteLine("Color : " + color);

// Ejercicio 3

int numero = 20;
char caracter = 'b';

Console.WriteLine((numero >= 18));
Console.WriteLine((caracter == 'a'));
Console.WriteLine((numero >= 18) && (caracter == 'a'));
Console.WriteLine((numero >= 18) || (caracter == 'a'));
