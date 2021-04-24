using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClaimsbyMember.Data;
using ClaimsbyMember.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ClaimsbyMember.Controllers
{
    [Route("api/[controller]")]
    
    public class ClaimMemberController : ControllerBase
    {
        ClaimMemberIRepo cmrepo;
        public ClaimMemberController(ClaimMemberIRepo cm_repo)
        {
            cmrepo = cm_repo;
        }

     [HttpGet]
     public  List<MemberModel>GetClaimsMembers(DateTime CDate1,DateTime CDate2)
        {
            return cmrepo.GetClaimMember(CDate1, CDate2);
        }
    }
 }
