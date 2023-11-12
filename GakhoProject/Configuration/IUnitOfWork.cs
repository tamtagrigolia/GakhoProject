using GakhoProject.Repository.Interfaces;
using GakhoProject.Services.Interfaces;

namespace GakhoProject.Configuration
{
	public interface IUnitOfWork
	{
		Task Save();
		public IPolitPartiesRepository PolitParty { get; }
		public IPolitPartieService PolitPartieService { get; }
	}
}
