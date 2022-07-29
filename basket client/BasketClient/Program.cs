using System.Threading.Tasks;
using Grpc.Net.Client;
using Discount;
using Discount.Grpc.Protos;
// using Basket.Api.GrpcServices;


// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("http://localhost:5008");
//  var discountRequest = new GetDiscountRequest { ProductName = "Asus Laptop" };
// return await _discountProtoService.GetDiscountAsync(discountRequest);
// private readonly DiscountGrpcService _discountGrpcService;

// var client = new DiscountProtoService.DiscountProtoServiceClient(channel);
// var reply = await client.GetTestDiscountAsync(new GetTestDiscountRequest  {ProductName = 9 });



// var client = new Greeter.GreeterClient(channel);
// var client = new Inventory.InventoryClient(channel);
// var reply = await client.GetDiscountAsync(new GetDiscountRequest  {ProductName = 9 });




 // Grpc Configuration
// AddGrpcClient<DiscountProtoService.DiscountProtoServiceClient>
//     (o => o.Address = new Uri(builder.Configuration.GetValue<string>("GrpcSettings:DiscountUrl"))); 
// builder.Services.AddScoped<DiscountGrpcService>();





var client = new DiscountProtoService.DiscountProtoServiceClient(channel);
var reply = await client.GetDiscountAsync(new GetDiscountRequest  {ProductName = "Asus Laptop"  });
//  var discountRequest = new GetDiscountRequest { ProductName = "Asus Laptop" };

Console.WriteLine("Books: " + reply.Amount);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();