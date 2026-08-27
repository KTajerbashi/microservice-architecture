using Grpc.Core;
using GRPC_App.Protos;

namespace GRPC_App.GRPC;

public class Product
{
    public string Name { get; set; }
    public string Brand { get; set; }
    public int Price { get; set; }
}
public class ProductWebService : ProductService.ProductServiceBase
{
    static List<Product> Products = new()
    {
        new Product(){Name = "Iphone 17 promax", Brand ="Apple",Price = 1200}
    };
    public override Task<ResponseAddProductDTO> AddNewProduct(RequestAddProductDTO request, ServerCallContext context)
    {
        Products.Add(new Product()
        {
            Name = request.Name,
            Brand = request.Brand,
            Price = request.Price
        });

        Console.WriteLine($"Name is : {request.Name}");
        Console.WriteLine($"Brand is : {request.Brand}");
        Console.WriteLine($"Price is : {request.Price}");

        return Task.FromResult(new ResponseAddProductDTO()
        {
            IsSuccess = true
        });
        //return base.AddNewProduct(request, context);
    }

    public override Task<ResponseAllProductDTO> GetAllProduct(RequestAllProductDTO request, ServerCallContext context)
    {
        var result = new ResponseAllProductDTO();
        var data = Products
            //.Skip(request.Page * request.PageSize).Take(request.PageSize)
            .Select(x => new ProductItemDTO()
            {
                Brand = x.Brand,
                Name = x.Name,
                Price = x.Price
            }).ToList();

        result.Items.AddRange(data);

        return Task.FromResult(result);
        //return base.GetAllProduct(request, context);
    }

    public override Task<ResponseAllProductDTO> SearchProduct(RequestQueryProductDTO request, ServerCallContext context)
    {
        var result = new ResponseAllProductDTO();
        var data = Products
            .Where(x =>
                x.Name.Contains(request.Query) ||
                x.Brand.Contains(request.Query)
            )
            //.Skip(request.Page * request.PageSize).Take(request.PageSize)
            .Select(x => new ProductItemDTO()
            {
                Brand = x.Brand,
                Name = x.Name,
                Price = x.Price
            }).ToList();

        result.Items.AddRange(data);

        return Task.FromResult(result);
    }
}
