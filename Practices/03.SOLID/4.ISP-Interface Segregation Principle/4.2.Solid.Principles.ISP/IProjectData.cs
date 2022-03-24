using System;
using System.Collections.Generic;
using Solid.Principles.Dto;

namespace Solid.Principles
{
    public interface IProjectData
    {
        /// <summary>
        /// Get the Pjoects from table
        /// </summary>
        /// <returns>Projects Dto List</returns>
        List<ProjectDto> GetProjects();
    }
}
