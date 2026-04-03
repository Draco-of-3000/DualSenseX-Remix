using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace NETWORKLIST;

[ComImport]
[Guid("dcb00d01-570f-4a9b-8d69-199fdba5723b")]
[ComEventInterface(typeof(INetworkEvents), typeof(INetworkEvents))]
public interface INetworkEvents_Event
{
}
