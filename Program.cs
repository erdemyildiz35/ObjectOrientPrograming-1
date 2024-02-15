// See https://aka.ms/new-console-template for more information
Console.WriteLine("ürün adet");

int adet= int.Parse(Console.ReadLine());

Product[] products= new Product[adet];
Product prd;
int i= 0;


do
{
    prd = new Product();
    Console.WriteLine("urun adi");
    prd.Name = Console.ReadLine();

    Console.WriteLine("Urun Fiyat");
    prd.price = int.Parse(Console.ReadLine());

    Console.WriteLine("Aciklama: ");
    prd.Description = Console.ReadLine();

    products[i] = prd;
    i++;

} while (adet>i);


Console.WriteLine("-------");



foreach(var urun in products)
{
    Console.WriteLine($"ürün adi : {urun.Name} ürün fiyati : {urun.price} ürün aciklama : {urun.Description}");
}

/*
 * for döngüsü kullanımı 
 * 
 * for(int a=0; a < products.Length; a++)
{
    Console.WriteLine($"ürün adi : {products[a].Name} ürün fiyati : {products[a].price} ürün aciklama : {products[a].Description}");    
}
 */

public class Product()
{

    public string Name { get; set; }

    public double price {  get; set; }

    public string Description { get; set; }


}