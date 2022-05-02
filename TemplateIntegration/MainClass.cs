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

        public override string Name { get; } = "TemplateIntegration";
        public override string Author { get; } = "Killers0992";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override PoisonUserControl MainPanel { get; }
    }
}
