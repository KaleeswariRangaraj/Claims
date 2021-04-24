using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClaimsbyMember.Model
{
    public class MemberModel
    {
        [Key]
        public int MemberID { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<ClaimModel> ClaimDetail { get; set; }
    }
}
