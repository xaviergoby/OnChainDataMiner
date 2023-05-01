using Microsoft.AspNetCore.Mvc;

namespace NearscanProtocolMiner.Controllers;

[ApiController]
[Route("[controller]")]
public class BlockchainAccountBalancesController : ControllerBase
{

    private readonly ILogger<BlockchainAccountBalancesController> _logger;

    public BlockchainAccountBalancesController(
        ILogger<BlockchainAccountBalancesController> logger
        )
    {
        _logger = logger;
    }

    [HttpGet(Name = "EthereumBalance")]
    public IEnumerable<WalletBalanceQueryResult> Get()
    {
        return Enumerable.Range(1, 5)
            .Select(index => new WalletBalanceQueryResult
            {
                Id = Guid.NewGuid()
            }).ToArray();

    }

    [HttpGet]
    [Route("get/{walletAddress}/balance")]
    //public async Task<ActionResult<AssetPriceStats>> AveragePrices(Guid baseAssetId, OrderDirection orderDirection = OrderDirection.Buy)
    public async Task<IActionResult> WalletBalanceQueryResult(string walletAddress)
    {
        //var walletAdress = "0xc1b0527aB9198083c9ab479CDBff578C6e77B337";
        var request = new HttpRequestMessage(HttpMethod.Post, "https://rpc.mainnet.near.org");

        //throw NotImplementedException();
        return Ok(new NotImplementedException().Message);
    }

}