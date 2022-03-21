using JetBrains.Annotations;
using Microsoft.Extensions.Logging;
using Service.Grpc;
using Service.TutorialPsychology.Grpc;

namespace Service.TutorialPsychology.Client
{
	[UsedImplicitly]
	public class TutorialPsychologyClientFactory : GrpcClientFactory
	{
		public TutorialPsychologyClientFactory(string grpcServiceUrl, ILogger logger) : base(grpcServiceUrl, logger)
		{
		}

		public IGrpcServiceProxy<ITutorialPsychologyService> GetTutorialPsychologyService() => CreateGrpcService<ITutorialPsychologyService>();
	}
}