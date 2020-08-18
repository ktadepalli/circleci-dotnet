﻿using System;
using System.Collections.Generic;

namespace RecruitmentAPI.Models
{
    public partial class JobTitleMaster
    {
        public int JobTitleId { get; set; }
        public int DeptId { get; set; }
        public string Description { get; set; }
        public sbyte IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual DeptMaster Dept { get; set; }
    }
}
