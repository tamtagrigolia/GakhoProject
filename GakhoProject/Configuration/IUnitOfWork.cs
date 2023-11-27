using GakhoProject.Repository.Interfaces;
using GakhoProject.Services.Interfaces;

namespace GakhoProject.Configuration
{
	public interface IUnitOfWork
	{
		Task Save();
		public IPolitPartiesRepository PolitParty { get; }
		public IMemberRepository Member
		{ get; }

		public IMemberService MemberService { get; }
        public IPolitPartieService PolitPartieService { get; }

    }
}
