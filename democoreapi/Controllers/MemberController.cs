using democoreapi.Data.Interface;
using democoreapi.Data.Model;
using democoreapi.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace democoreapi.Controllers
{
    [ApiController]
    public class MemberController : Controller
    {
        private IMembers members = new MembersRepository();

        [HttpGet]
        [Route("api/member/GetAllMembers")]
        public ActionResult<IEnumerable<Member>> GetAllMembers()
        {
            return members.GetAllMember();
        }
        [HttpGet]
        [Route("api/member/GetMemberById")]
        public ActionResult<Member> GetMemberById(int id)
        {
            return members.GetMember(id);
        }
    }
}
