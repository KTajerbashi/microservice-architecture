using Grpc.Net.Client;
using GRPC_App.Protos;

namespace GRPC_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //https://localhost:7200
            var channel = GrpcChannel.ForAddress("https://localhost:7200");

            var productClient = new ProductService.ProductServiceClient(channel);

            var response = productClient.AddNewProduct(new RequestAddProductDTO()
            {
                Name = "Glaxy S20",
                Brand = "Samsung",
                Price = 900
            });

            Console.WriteLine($"Response = {response.IsSuccess}");

            Console.ReadLine();
        }
    }
}
