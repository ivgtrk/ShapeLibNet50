# ShapeLibNet50
Shape Lib's for testing skills
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.

Дополнительно к работоспособности оценим:
* Юнит-тесты
* Легкость добавления других фигур
* Вычисление площади фигуры без знания типа фигуры в compile-time
* Проверку на то, является ли треугольник прямоугольным
____
## How to use
In your project, add a link to the library and use the namespace 'ShapeLibNet50'.
Your code may look like this:
```c#
using ShapeLibNet50;

static void Main()
{
    Circle circ = new( 5.0 );
    Console.WriteLine( circ.ToString() );       // 78.540
    Console.WriteLine( circ.GetArea );          // 78,53981633

    Triangle triangle = new( 60, 91, 109 );
    Console.WriteLine( triangle.ToString() );   // 2730.000
    Console.WriteLine( triangle.IsRight() );    // True

    Console.ReadKey();
}
```
