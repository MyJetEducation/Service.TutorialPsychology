﻿using System.Threading.Tasks;
using Service.Education.Contracts;
using Service.Education.Contracts.Task;
using Service.Education.Structure;
using Service.TutorialPsychology.Helper;
using static Service.Education.Helpers.AnswerHelper;

namespace Service.TutorialPsychology.Services
{
	public partial class TutorialPsychologyService
	{
		private static readonly EducationStructureUnit Unit5 = TutorialHelper.StructureTutorial.Units[5];

		public async ValueTask<TestScoreGrpcResponse> Unit5TextAsync(TaskTextGrpcRequest request)
			=> await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit5, Unit5.Tasks[1], request.IsRetry, request.Duration);

		public async ValueTask<TestScoreGrpcResponse> Unit5TestAsync(TaskTestGrpcRequest request)
		{
			ITaskTestAnswer[] answers = request.Answers;

			int progress = CheckAnswer(20, answers, 1, 2)
				+ CheckAnswer(20, answers, 2, 2)
				+ CheckAnswer(20, answers, 3, 1)
				+ CheckAnswer(20, answers, 4, 1, 2, 3)
				+ CheckAnswer(20, answers, 5, 1);

			return await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit5, Unit5.Tasks[2], request.IsRetry, request.Duration, progress);
		}

		public async ValueTask<TestScoreGrpcResponse> Unit5VideoAsync(TaskVideoGrpcRequest request) =>
			await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit5, Unit5.Tasks[3], request.IsRetry, request.Duration);

		public async ValueTask<TestScoreGrpcResponse> Unit5CaseAsync(TaskCaseGrpcRequest request) =>
			await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit5, Unit5.Tasks[4], request.IsRetry, request.Duration, CountProgress(request.Value == 1));

		public async ValueTask<TestScoreGrpcResponse> Unit5TrueFalseAsync(TaskTrueFalseGrpcRequest request)
		{
			ITaskTrueFalseAnswer[] answers = request.Answers;

			int progress = CheckAnswer(20, answers, 1, true)
				+ CheckAnswer(20, answers, 2, false)
				+ CheckAnswer(20, answers, 3, true)
				+ CheckAnswer(20, answers, 4, false)
				+ CheckAnswer(20, answers, 5, false);

			return await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit5, Unit5.Tasks[5], request.IsRetry, request.Duration, progress);
		}

		public async ValueTask<TestScoreGrpcResponse> Unit5GameAsync(TaskGameGrpcRequest request) =>
			await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit5, Unit5.Tasks[6], request.IsRetry, request.Duration);
	}
}
