// See https://aka.ms/new-console-template for more information
using Quiz2_NikaKhorbaladze;
using Quiz2_NikaKhorbaladze.Task1;
using Quiz2_NikaKhorbaladze.Task2;
using Quiz2_NikaKhorbaladze.Task3;


//Task-1
Console.WriteLine("Task 1");

DataHandler<int> intData = new DataHandler<int>();

for (int i = 10; i < 50; i = i + 10)
{
    intData.AddData(i);
}

int ind1 = 2;
int ind2 = 3;

try
{
    int data1 = intData.RetrieveData(ind1);
    int data2 = intData.RetrieveData(ind2);

    Console.WriteLine($"Data on index {ind1}: {data1}");
    Console.WriteLine($"Data on index {ind2}: {data2}");
}
catch (IndexOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}


Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();



//Task2
Console.WriteLine("Task2");

IDevice tv = new DeviceController("TV");
tv.Activate();
IDevice computer = new DeviceController("Computer");
computer.Activate();



Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();



//Task3
Console.WriteLine("Task3");

Vehicle car1 = new Car();
car1.StartEngine();
car1.Accelerate();

Vehicle bike1 = new Bike();
bike1.StartEngine();
bike1.Accelerate();
