namespace NearscanProtocolMiner;

public class WalletBalanceQueryResult
{
    // "DTO" Id
    public Guid Id { get; set; }

    // "Addendum" info
    public string Info { get; set; }

    // Name of the blockchain network, e.g. "Bitcoin", "Ethereum", "Polkadot", "Near" etc
    public string BlockchainNetwork { get; set; }

    // Address of the wallet
    public  string Address { get; set; }

    // Total amount of [<native_token_of_concenred_blockchain>] in the wallet
    public decimal Balance { get; set; }
}