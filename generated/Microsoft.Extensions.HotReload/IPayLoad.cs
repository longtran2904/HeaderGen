#region Microsoft.Extensions.DotNetDeltaApplier, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\Microsoft Visual Studio\2022\community\common7\ide\commonextensions\microsoft\hotreload\Microsoft.Extensions.DotNetDeltaApplier.dll
#endregion

using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Extensions.HotReload
{
    public interface IPayLoad
    {
        bool ReplyExpected { get; }

        ValueTask WriteAsync(Stream stream, CancellationToken cancellationToken);
    }
}
