// See https://aka.ms/new-console-template for more information

// C# Primitive Types

//Task 1: Declare variables of these types: int, double, string, bool. Print their values to the console.
using System.ComponentModel.DataAnnotations;

int employeeId = 1001;
string name = "Saleh";
double salary = 2500.5;
bool isEmployeed = true;

Console.WriteLine($" ID: {employeeId} \n Name: {name} \n Salary: {salary} \n Employment Status: {isEmployeed}");

Console.WriteLine("---------------------------------");

//Task 2: Experiment with number conversions. Try to predict the results.
int number = 5;
double result = Convert.ToDouble(number);

Console.WriteLine($" Result: {result + 1.1}");

Console.WriteLine("---------------------------------");

// Bonus:-
char departmentLocationZone = 'B';
Console.WriteLine($" Department Location Zone: {departmentLocationZone}");

Console.WriteLine("---------------------------------");

//C# Variables
// Task 1:-

string studentName = "Saleh Bin Essa";

double studentGpa = 3.404;

string favoriteSubject = "Mathematics";

Console.WriteLine($"Student Name: {studentName}");
Console.WriteLine($"GPA: {studentGpa}");
Console.WriteLine($"Favorite Subject: {favoriteSubject}");

Console.WriteLine("---------------------------------");

// Task 2:

double width = 5.5;
double height = 3.2;

double area = width * height;

Console.WriteLine($"The area of the rectangle is: {area}");

Console.WriteLine("---------------------------------");

// Bonus:-
const double Pi = 3.14;

double num = 55.5;

Console.WriteLine($"Pi = {Pi} num = {num}");
//Pi = 2.3;
 num = 66.3;

Console.WriteLine($"Pi = {Pi} num = {num}");


// Const values can not be updated, however values can be.
