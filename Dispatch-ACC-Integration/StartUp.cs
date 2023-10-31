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
        private IUser userService = null;
        public StartUp(IUser user)
        {
            userService = user;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            userService.GetById().ForEach(m =>
            {
                Console.WriteLine(m.WorkOrderId);
            });

            await Task.CompletedTask;
        }
    }
}
