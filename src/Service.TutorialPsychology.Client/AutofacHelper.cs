using Autofac;
using Microsoft.Extensions.Logging;
using Service.Grpc;
using Service.TutorialPsychology.Grpc;

// ReSharper disable UnusedMember.Global

namespace Service.TutorialPsychology.Client
{
	public static class AutofacHelper
	{
		public static void RegisterTutorialPsychologyClient(this ContainerBuilder builder, string grpcServiceUrl, ILogger logger)
		{
			var factory = new TutorialPsychologyClientFactory(grpcServiceUrl, logger);

			builder.RegisterInstance(factory.GetTutorialPsychologyService()).As<IGrpcServiceProxy<ITutorialPsychologyService>>().SingleInstance();
		}
	}
}
