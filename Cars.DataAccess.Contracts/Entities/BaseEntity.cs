using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.DataAccess.Contracts.Entities
{
    public  class BaseEntity
    {
        public int CreateUserId { get; set; }

        public int UpdateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public void SetAudit(EntityState state)
        {
            var now = DateTime.UtcNow;
            if (state == EntityState.Added)
            {
                if (CreateDate == default(DateTime))
                {
                    CreateDate = now;
                }
            }

            UpdateDate = now;
        }

    }
}
