﻿using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Volo.CmsKit.Domain.Volo.CmsKit.Blogs
{
    public class Blog : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
    }
}