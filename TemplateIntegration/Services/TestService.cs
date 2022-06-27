using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TemplateIntegration.Services
{
    public class TestService : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (true)
            {
                Logger.Info($"TMP", "Test service runner...", Color.Tomato, Color.Tan);
                await Task.Delay(3000);
            }
        }
    }
}
