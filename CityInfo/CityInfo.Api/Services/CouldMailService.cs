﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Api.Services
{
    public class CouldMailService : IMailService
    {
        private readonly IConfiguration _configuration;
        public CouldMailService(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public void Send(string subject, string message)
        {
            Debug.WriteLine($"Mail From {_configuration["mailSettings:mailFromAddress"]} to {_configuration["mailSettings:mailToAddress"]}, with CloudMailService.");
            Debug.WriteLine($"Subject: {subject}");
            Debug.WriteLine($"Message: {message}");
        }
    }
}
