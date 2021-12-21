﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TMS.Application.Interfaces;
using TMS.Domain;

namespace TMS.Application.Project.Queries.GetProjectList
{
    public class GetProjectListQueryHandler : IRequestHandler<GetProjectListQuery, ProjectListVm>
    {
        private readonly ITmsDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetProjectListQueryHandler(ITmsDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ProjectListVm> Handle(GetProjectListQuery request, CancellationToken cancellationToken)
        {

            var projectsParticipant =  await _dbContext.Projects.Join(_dbContext.ProjectParticipants,
                    p => p.Id,
                    c => c.ProjectId,
                    (p, c) =>
                        new
                        {
                            Id = p.Id,
                            ProjectName = p.ProjectName,
                            ProjectStatusId = p.ProjectStatusId,
                            UserId = c.UserId,
                            date = p.AdditionDate
                        })
                .Where(e => e.UserId == request.UserId)
                .ToListAsync(cancellationToken);


            var result = new List<ProjectLookupDto>();

            projectsParticipant.ForEach(el =>
            {
                result.Add(
                new ProjectLookupDto(){
                    Id = el.Id,
                    ProjectStatusId = el.ProjectStatusId,
                    ProjectName = el.ProjectName
                });
            });


            return new ProjectListVm {Projects = result };
        }
    }

}