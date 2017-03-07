using System;
using System.Threading.Tasks;
using OrleansAP.Interfaces;

namespace OrleansAP.Grains
{
    public class GoogleAnalyticsGrain : Orleans.Grain, IGoogleAnalyticsGrain
    {
        Task<string> IGoogleAnalyticsGrain.SayHello(string websiteCode)
        {
            return Task.FromResult("You said: '" + websiteCode + "', I say: Hello!");
        }
    }
}