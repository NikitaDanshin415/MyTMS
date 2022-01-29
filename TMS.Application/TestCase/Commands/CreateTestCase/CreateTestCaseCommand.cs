using System;
using System.Collections.Generic;
using MediatR;
using TMS.Domain;

namespace TMS.Application.TestCase.Commands.CreateTestCase
{
    public class CreateTestCaseCommand : IRequest<Domain.TestCase>, IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int ProjectId { get; set; }
        public string UserId { get; set; }
        public List<TestCaseStep> Steps { get; set; }
    }
}