using AltV.Net;
using AltV.Net.Async;

namespace Main
{
    public class Main : AsyncResource
    {
        public Main() : base(false)
        {
            
        }

        public override void OnStart()
        {
            Alt.Export("broadcast", (string message) => { Alt.EmitAllClients("chatmessage", null, message); });
        }

        public override void OnStop()
        {
        }
    }
}