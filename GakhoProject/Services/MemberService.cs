using GakhoProject.Models;
using GakhoProject.Repository;
using GakhoProject.Repository.Interfaces;
using GakhoProject.Services.Interfaces;

namespace GakhoProject.Services
{
	public class MemberService : IMemberService
	{
		private readonly IMemberRepository _memberRepository1;

		public MemberService(IMemberRepository memberRepository)
		{
			_memberRepository1 = memberRepository;
		}
		public async Task<List<Member>> GetAllMembers()
		{
			var result = await _memberRepository1.GetAll();
			if (result.Count() > 0)
			{
				return result.ToList();
			}
			else
			{
				throw new NullReferenceException();
			}

		}
	}
}
