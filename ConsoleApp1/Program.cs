// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var a = new List<int>();
a.Add(1);
public interface ICar
{
    string Name { get; }
}
public interface ICarGenerator
{
    ICar GetByName(string name);
}
public class Car : ICar
{
    public string Name => throw new NotImplementedException();
    public string Id { get; set; }
}
public class Car2 : ICar
{
    public string Name => throw new NotImplementedException();
    public int id { get; set; }
}
public class CarGenerator : ICarGenerator
{
    public ICar GetByName(string name)
    {
        return new Car2();
    }
}
class Test
{
    void TestMethod()
    {
        var g = new CarGenerator();
        var car = g.GetByName("mm");
        
        if (car is Car2)
        {
            (car as Car2).id = 1;
        }
        else
        {
            var b = (Car)car;
            b.Id = "";
        }
    }
}
public class Product
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public long Price { get; set; }
    public string ProductId { get; set; }
    public int CountInStore { get; set; }
    public List<int> UserIds { get; set; }
    public List<string> Options { get; set; }
    public ProductType Type { get; set; }
}
public class ProductManager
{
    private readonly List<Product> _products;
    public ProductManager()
    {
        _products = new List<Product>();
    }
    void Test()
    {
        _products.Where(x => x.UserIds.Any(y => y == 1));
        foreach (var x in _products)
        {
            x.UserIds.Any(y => y == 1);
            foreach (var y in _products)
            {
                
            }

        }
        var a = _products.Where(x => x.Name == "bag").SelectMany(x => x.UserIds);
        var aa = a.ToList();
        var pr = new Product { Type = ProductType.vv };
    }
}
public enum ProductType
{
    nn= 0,
    vv =1
       
}
