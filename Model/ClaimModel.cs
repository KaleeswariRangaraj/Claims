using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClaimsbyMember.Model
{
    public class ClaimModel
    {
        [Key]
        public int MemberID { get; set; }
        public DateTime ClaimDate { get; set; }
        public Decimal ClaimAmount { get; set; }
    }
}
