

namespace CarService.Models.IssueTypes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    using static Data.DataConstants.IssueType;

    public class EditIssueTypeViewModel : IssueTypeViewModel
    {
        public int Id { get; set; }

    }
}

