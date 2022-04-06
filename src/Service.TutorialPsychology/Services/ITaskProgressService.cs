using System;
using System.Threading.Tasks;
using Service.Education.Structure;
using Service.TutorialPsychology.Grpc.Models.State;
using Service.TutorialPsychology.Grpc.Models.Task;
using Service.TutorialPsychology.Models;

namespace Service.TutorialPsychology.Services
{
	public interface ITaskProgressService
	{
		ValueTask<TestScoreGrpcResponse> SetTaskProgressAsync(string userId, EducationStructureUnit unit, EducationStructureTask task, bool isRetry, TimeSpan duration, int? progress = null);

		ValueTask<StateGrpcModel> GetUnitProgressAsync(string userId, int unit);

		ValueTask<TaskTypeProgressInfo> GetTotalProgressAsync(string userId, int? unit = null);
	}
}
