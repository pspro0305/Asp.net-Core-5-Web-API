using democoreapi.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace democoreapi.Data.Interface
{
    public interface IMembers
    {
        List<Member> GetAllMember();
        Member GetMember(int id);
    }
}
