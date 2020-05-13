using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace GrpcService
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }


        public override Task<ObiectNou1> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new ObiectNou1
            {
                Message1 = "nimic" + request.Name,
                Message = "Hello " + request.Name
            });
        }
    }
}
