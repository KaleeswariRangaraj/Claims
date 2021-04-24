using ClaimsbyMember.Model;
using CsvHelper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ClaimsbyMember.Data
{
    public class ClaimMemberData: ClaimMemberIRepo
    {
        //private readonly DataContext db;
        //private readonly IConfiguration config;
        //public ClaimMemberData(DataContext _db, IConfiguration _config)
        //{
        //    this.db = _db;
        //    this.config = _config;
        //}
        //List<Member> lstMembers = null;
        //List<Claim> lstClaims = null;
       
        IHostingEnvironment _hostingEnvironment;
        public List<MemberModel> GetClaimMember(DateTime ClaimDate1,DateTime ClaimDate2)
        {
            string filepath = _hostingEnvironment.ContentRootPath;
           
                try
                {
                List<ClaimModel> claimrecords = null;
                List<MemberModel> memberrecords = null;
                using (var reader = new StreamReader(Path.Combine(filepath,"ClaimDetailsByDate","Claim.csv")))
                    using (var csv = new CsvReader(reader))
                    {
                       // csv.Configuration.RegisterClassMap<StudentMap>();
                         claimrecords = csv.GetRecords<ClaimModel>().ToList();
                       // return records;
                    }

                    using (var reader = new StreamReader(Path.Combine(filepath, "MemberDetails", "Member.csv")))
                    using (var csv = new CsvReader(reader))
                    {
                        // csv.Configuration.RegisterClassMap<StudentMap>();
                         memberrecords = csv.GetRecords<MemberModel>().ToList();
                        // return records;
                    }
                    foreach(var mem in memberrecords)
                {
                    mem.ClaimDetail = claimrecords.Where(c => c.MemberID == mem.MemberID && c.ClaimDate>= ClaimDate1 && c.ClaimDate<=ClaimDate2).ToList();
                }
                return memberrecords.Where(m => m.ClaimDetail != null).ToList();

            }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
        }
    }
}
