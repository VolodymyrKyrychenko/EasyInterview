using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DataAccess.Interfaces;
using Domain.Entities;
using Services.Enums;
using Services.Interfaces;

namespace Services.Services
{
    public class InterviewService : IInterviewService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDictionary<InterviewStatus, Expression<Func<Interview, bool>>> _filters;

        public InterviewService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            _filters = new Dictionary<InterviewStatus, Expression<Func<Interview, bool>>>
            {
                { InterviewStatus.NotStarted, interview => interview.Start > DateTime.UtcNow },
                { InterviewStatus.InProgress, interview => interview.Start <= DateTime.UtcNow && interview.Finish > DateTime.UtcNow },
                { InterviewStatus.Archived, interview => interview.Finish < DateTime.UtcNow }
            };
        }

        public async Task Create(Interview interview)
        {
            await _unitOfWork.InterviewRepository.CreateAsync(interview);

            await _unitOfWork.SaveAsync();
        }

        public async Task<string> GerReport(int interviewId)
        {
            var interview = await _unitOfWork.InterviewRepository.FindAsync(interviewId);

            return interview.Report;
        }

        public Task<IEnumerable<Interview>> Get(InterviewStatus status)
        {
            return _unitOfWork.InterviewRepository.GetAsync(_filters[status]);
        }

        public Task Update(Interview interview)
        {
            _unitOfWork.InterviewRepository.Update(interview);

            return _unitOfWork.SaveAsync();
        }
    }
}
