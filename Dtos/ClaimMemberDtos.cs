using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClaimsbyMember.Dtos
{
    public class ClaimMemberDtos
    {
        [Key]
        public int MemberID { get; set; }
        public DateTime ClaimDate { get; set; }
        public float ClaimAmount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
