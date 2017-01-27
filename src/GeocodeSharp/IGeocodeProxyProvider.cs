using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace GeocodeSharp
{
    public interface IGeocodeProxyProvider
    {
        Task<Stream> GetStreamAsync(string url);
    }
}
