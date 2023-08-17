using System;
using System.Threading.Tasks;
using Grpc.Core;
using GrpcService2;

namespace GrpcService2.Services
{
    public class TimeService: Time.TimeBase
    {
        public override Task<TimeResponse> GetCurrentTime(Empty request, ServerCallContext context)
        {
            // var currentTime = DateTime.Now.ToString("HH:mm:ss");
            // return new TimeResponse { CurrentTime = currentTime };
            return Task.FromResult(new TimeResponse {
                CurrentTime = DateTime.Now.ToString("HH:mm:ss"),
                CurrentDate = DateTime.Now.ToString("dd:MM:yyyy")
            }); 
        }
    }
}
