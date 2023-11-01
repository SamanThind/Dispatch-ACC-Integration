using BAL;
using Microsoft.Extensions.Hosting;
using LogisticsLib.DBTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatch_ACC_Integration
{
    public class StartUp : BackgroundService
    {
        private IEquipments userService = null;
        public StartUp(IEquipments user)
        {
            userService = user;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            userService.GetDriversByCompanyId(0).ForEach(m =>
            {
                Console.WriteLine(m.carrierId);
            });

            await Task.CompletedTask;
        }
    }
}
