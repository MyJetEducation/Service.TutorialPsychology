using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.TutorialPsychology.Settings
{
	public class SettingsModel
	{
		[YamlProperty("TutorialPsychology.SeqServiceUrl")]
		public string SeqServiceUrl { get; set; }

		[YamlProperty("TutorialPsychology.ZipkinUrl")]
		public string ZipkinUrl { get; set; }

		[YamlProperty("TutorialPsychology.ElkLogs")]
		public LogElkSettings ElkLogs { get; set; }

		[YamlProperty("TutorialPsychology.EducationProgressServiceUrl")]
		public string EducationProgressServiceUrl { get; set; }

		[YamlProperty("TutorialPsychology.EducationRetryServiceUrl")]
		public string EducationRetryServiceUrl { get; set; }

		[YamlProperty("TutorialPsychology.UserRewardServiceUrl")]
		public string UserRewardServiceUrl { get; set; }

		[YamlProperty("TutorialPsychology.UserProgressServiceUrl")]
		public string UserProgressServiceUrl { get; set; }
	}
}