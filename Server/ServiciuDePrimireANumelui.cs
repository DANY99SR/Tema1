using Grpc.Core;
using Generated;
using System.Threading.Tasks;

namespace Server
{
    internal class ServiciuDePrimireANumelui : Generated.ServiciuCerereNume.ServiciuCerereNumeBase
    {

        public override Task<Gol> AfiseazaNume(Nume request, ServerCallContext context)
        {
            System.Console.WriteLine("Hello {0}", request.Nume_ + "!");
           
            return Task.FromResult(new Gol() { });
        }
    }
}
