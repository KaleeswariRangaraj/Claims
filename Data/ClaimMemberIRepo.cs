using ClaimsbyMember.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaimsbyMember.Data
{
    public interface ClaimMemberIRepo
    {
        List<MemberModel> GetClaimMember(DateTime ClaimDate1, DateTime ClaimDate2);


    }
}
