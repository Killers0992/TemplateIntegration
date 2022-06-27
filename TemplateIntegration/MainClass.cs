using CoreOSC;
using Microsoft.Extensions.DependencyInjection;
using System.Drawing;
using TemplateIntegration.Services;

namespace TemplateIntegration
{
    public class MainClass : VrcIntegration<IntegrationConfig>
    {
        public static MainClass Instance;

        public MainClass()
        {
            Instance = this;
            MainPanel = new MainPanel();
        }

        public override void OnRegister(ref IServiceCollection services)
        {
            services.AddHostedService<TestService>();
        }

        public override void OnReceiveOscMessage(string address, OscMessage message)
        {
            Logger.Info($"OscIn", $"Received osc from address {address}", Color.Aqua, Color.White);
        }

        public override string Name { get; } = "TemplateIntegration";
        public override string Author { get; } = "Killers0992";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override PoisonUserControl MainPanel { get; }
    }
}
