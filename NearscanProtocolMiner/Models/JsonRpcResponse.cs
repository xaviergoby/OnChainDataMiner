using System.Text.Json.Serialization;

namespace Hodl.ExplorerAPI.Models;



internal class JsonRpcResponse
{
    [JsonPropertyName("jsonrpc")]
    public string Jsonrpc { get; set; }

    [JsonPropertyName("result")]
    public JsonRpcResponseResult? Result { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("error")]
    public JsonRpcResponseError? Error { get; set; }

    public DateTimeOffset TimeStamp { get; set; }
};


public class JsonRpcResponseResult
{
    [JsonPropertyName("amount")]
    public string Amount { get; set; }
    [JsonPropertyName("locked")]
    public string Locked { get; set; }
    [JsonPropertyName("code_hash")]
    public string CodeHash { get; set; }
    [JsonPropertyName("storage_usage")]
    public int StorageUsage { get; set; }
    [JsonPropertyName("storage_paid_at")]
    public int StoragePaidAt { get; set; }
    [JsonPropertyName("block_height")]
    public int BlockHeight { get; set; }
    [JsonPropertyName("block_hash")]
    public string BlockHash { get; set; }
};


public class JsonRpcResponseError
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("cause")]
    public JsonRpcResponseErrorCause Cause { get; set; }

    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }

    [JsonPropertyName("data")]
    public string Data { get; set; }
};


public class JsonRpcResponseErrorCause
{
    [JsonPropertyName("info")]
    public JsonRpcResponseErrorInfo Info { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
};


public class JsonRpcResponseErrorInfo
{
    [JsonPropertyName("block_hash")]
    public string BlockHash { get; set; }

    [JsonPropertyName("block_height")]
    public int BlockHeight { get; set; }

    [JsonPropertyName("requested_account_id")]
    public string RequestedAccountId { get; set; }
};


