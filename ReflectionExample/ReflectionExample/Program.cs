using ReflectionExample;
using System.Reflection;

Car car = new Car();

car.GetType().GetProperties().ToList().ForEach(p =>
{
    if (p.Name == "No") 
    {
        p.SetValue(car, 1);
    }
    else if (p.Name == "Brand")
    {
        p.SetValue(car, "Peugeot");
    }
    else if (p.Name == "Model")
    {
        p.SetValue(car, "207");
    }
    else
    {
        p.SetValue(car, 2009);
    }

});
Console.WriteLine($"Marka:{car.Brand} \nModel:{car.Model} \nYıl:{car.Year}");