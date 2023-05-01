

namespace NearscanProtocolMiner.Models;


/// <summary>
/// https://hyperchain.readthedocs.io/en/latest/JSON-RPC_manual.html
/// https://github.com/yallie/JsonServices/blob/0e4a7c132077ecac0707bfee93f41734efc6be52/src/JsonServices.Serialization.Newtonsoft/Internal/GenericMessage.cs
/// https://learn.microsoft.com/en-us/dotnet/api/system.runtime.serialization.datamemberattribute?view=net-8.0
/// </summary>
[DataContract()]
public class JSONRPCRequestObjectDataModel
{
    public string Method { get; set; }

    // The Parameters property on the DataMemberAttribute is set to "params".
    [DataMember(Name = "params")]
    public object Parameters { get; set; }

    public object Id { get; set; }
}