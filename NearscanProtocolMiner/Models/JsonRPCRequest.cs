namespace Hodl.ExplorerAPI.Models;

public class JsonRPCRequest
{
    public string jsonrpc { get; set; }
    public string id { get; set; }
    public string method { get; set; }
    public JsonRPCRequestParams @params { get; set; }
    public DateTimeOffset TimeStamp { get; set; }
}


public class JsonRPCRequestParams
{
    public string request_type { get; set; }
    public string finality { get; set; }
    public string account_id { get; set; }
};