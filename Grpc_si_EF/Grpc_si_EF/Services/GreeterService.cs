using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clase.API;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace Grpc_si_EF
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<Reply> SayInsert(Comm comentariu, ServerCallContext context)
        {
            Functii.Inserare_com(comentariu.Nume, comentariu.Descriere);
            return Task.FromResult(new Reply
            {
                Result = "1"
            });
        }
    }
}
