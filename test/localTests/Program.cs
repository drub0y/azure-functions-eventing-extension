﻿using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.EventGrid;

namespace EventGridBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new JobHostConfiguration();

            if (config.IsDevelopment)
            {
                config.UseDevelopmentSettings();
            }

            config.UseEventGrid();

            JobHost host = new JobHost(config);
            host.RunAndBlock();
        }
    }
}