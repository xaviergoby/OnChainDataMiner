using System.Text.Json.Serialization;

namespace NearScanJSONRPCAPImplementationTest1.Models;

public class AzeroWalletBalanceResult
{
    [JsonPropertyName("code")]
    public long Code { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }

    [JsonPropertyName("generated_at")]
    public long GeneratedAt { get; set; }

    [JsonPropertyName("data")]
    public AzeroWalletBalanceResultData Data { get; set; }
};



public partial class AzeroWalletBalanceResultData
{
    [JsonPropertyName("native")]
    public List<AzeroWalletBalanceResultNative> Native { get; set; }
};

public partial class AzeroWalletBalanceResultNative
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }

    [JsonPropertyName("unique_id")]
    public string UniqueId { get; set; }

    [JsonPropertyName("decimals")]
    public long Decimals { get; set; }

    [JsonPropertyName("balance")]
    public string Balance { get; set; }

    [JsonPropertyName("lock")]
    public string Lock { get; set; }

    [JsonPropertyName("reserved")]
    public long Reserved { get; set; }

    [JsonPropertyName("bonded")]
    public string Bonded { get; set; }

    [JsonPropertyName("unbonding")]
    public long Unbonding { get; set; }

    [JsonPropertyName("democracy_lock")]
    public long DemocracyLock { get; set; }

    [JsonPropertyName("election_lock")]
    public long ElectionLock { get; set; }

    [JsonPropertyName("vesting")]
    public AzeroWalletBalanceResultVesting Vesting { get; set; }
};

public partial class AzeroWalletBalanceResultVesting
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("total_locked")]
    public string TotalLocked { get; set; }

    [JsonPropertyName("pallet_schedules")]
    public List<AzeroWalletBalanceResultSchedule> PalletSchedules { get; set; }
}

public partial class AzeroWalletBalanceResultSchedule
{
    [JsonPropertyName("locked")]
    public string Locked { get; set; }

    [JsonPropertyName("per_block")]
    public string PerBlock { get; set; }

    [JsonPropertyName("starting_block")]
    public long StartingBlock { get; set; }
}