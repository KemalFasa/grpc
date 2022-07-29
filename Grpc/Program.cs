using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcServer;
// using Bookshop;
// using BookshopGrpc;

// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("http://localhost:5000");

// var client = new Greeter.GreeterClient(channel);
var client = new Inventory.InventoryClient(channel);
// var reply = await client.GetBookListAsync(new GetBookListRequest { });
// Console.WriteLine("Books: " + reply.Books);

var reply = await client.GetDiscountAsync(new GetDiscountRequest  {ProductName = 9 });
Console.WriteLine("Books: " + reply.Discount);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();