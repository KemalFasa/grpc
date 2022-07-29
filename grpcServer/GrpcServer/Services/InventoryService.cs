using Grpc.Core;
using GrpcServer;

namespace GrpcServer.Services;

public class InventoryService : Inventory.InventoryBase
{
    private readonly ILogger<InventoryService> _logger;
    public InventoryService(ILogger<InventoryService> logger)
    {
        _logger = logger;
    }

  public override Task<GetBookListResponse> GetBookList(GetBookListRequest request, ServerCallContext context)
  {
    _logger.LogInformation("Received request to: GetBookList");
    var response = new GetBookListResponse();
    response.Books.Add(new Book
    {
      Title = "kemal fasa kemal fasa kemal fasa The Hitchhiker's Guide to the Galaxy",
      Author = "Douglas Adams",
      PageCount = 42
    });
    response.Books.Add(new Book
    {
      Title = "kemal fasa kemal fasa kemal  fasa The Lord of the Rings",
      Author = "J.R.R. Tolkien",
      PageCount = 1234
    });
    return Task.FromResult(response);
  }

   public override Task<GetDiscountResponse> GetDiscount(GetDiscountRequest request, ServerCallContext context)
  {
    _logger.LogInformation("Received request to: GetDiscount");
    var response = new GetDiscountResponse();
    response.Discount.Add(new Discount
    {
        Amount= request.ProductName
    });
    
    return Task.FromResult(response);
  }

  // public override Task<GetDiscountRequest> GetDiscount(GetDiscountRequest request, ServerCallContext context)
  // {
  //   _logger.LogInformation("Received request to: GetDiscount");
  //   var response = "4";
    
  //   return Task.FromResult(response);
  // }
}
