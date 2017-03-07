using System;
using System.Threading.Tasks;

namespace OrleansAP.Interfaces
{
    public interface IGoogleAnalyticsGrain : Orleans.IGrainWithGuidKey
    {
        Task<string> SayHello(string websiteCode);
    }
}