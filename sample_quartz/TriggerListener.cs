using Quartz;
using System;
using Quartz.Core;
using Quartz.Impl;
using System.Threading.Tasks;
using System.Threading;

namespace sample_quartz
{
    public class TriggerListener : ITriggerListener
    {
        public string Name => "Trigger";

        public Task TriggerComplete(ITrigger trigger, IJobExecutionContext context, SchedulerInstruction triggerInstructionCode, CancellationToken cancellationToken = default)
        {
            // throw new NotImplementedException();
            return Console.Out.WriteLineAsync($"[{DateTime.Now}]that's threading is TriggerComplete!");
        }

        public Task TriggerFired(ITrigger trigger, IJobExecutionContext context, CancellationToken cancellationToken = default)
        {
            // throw new NotImplementedException();
            return Console.Out.WriteLineAsync($"[{DateTime.Now}]that's threading is TriggerFired!");
        }

        public Task TriggerMisfired(ITrigger trigger, CancellationToken cancellationToken = default)
        {
            return Task.Run(() => {
                Console.Out.WriteLine($"[{DateTime.Now}]that's threading is TriggerMisfired!");
            });
        }

        public Task<bool> VetoJobExecution(ITrigger trigger, IJobExecutionContext context, CancellationToken cancellationToken = default)
        {
            return Task<bool>.Run(() => {
                return true;
            });
        }
    }
}