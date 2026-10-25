using CrashKonijn.Goap.Core;
using CrashKonijn.Goap.Runtime;
using CrashKonijn.Docs.GettingStarted.Capabilities;

namespace CrashKonijn.Docs.GettingStarted.AgentTypes
{
    public class DemoAgentTypeFactory : AgentTypeFactoryBase
    {
        public override IAgentTypeConfig Create()
        {
            var factory = CreateBuilder("ScriptDemoAgent");
            
            factory.AddCapability<IdleCapabilityFactory>();

            return factory.Build();
        }
    }
}