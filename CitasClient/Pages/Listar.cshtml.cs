using CitasServer;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace CitasClient.Pages
{
    public class ListarModel : PageModel
    {
        private readonly Greeter.GreeterClient client;
        private readonly ILogger<ListarModel> _logger;

        [BindProperty]
        public string Name { get; set; }

        public string Message { get; set; }

        public ListarModel(ILogger<ListarModel> logger)
        {
            var url = "https://localhost:5001/";
            var channel = GrpcChannel.ForAddress(url);
            client = new Greeter.GreeterClient(channel);

            _logger = logger;
        }

        public void OnGet()
        {

        }
        public async Task OnPost()
        {
            var helloRequest = new HelloRequest();
            helloRequest.Name = Name;
            var result = await client.SayHelloAsync(helloRequest);
            Message = result.Message;
        }
    }
}
