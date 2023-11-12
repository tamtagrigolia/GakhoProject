using GakhoProject.Models;

namespace GakhoProject.Services.Interfaces
{
	public interface IPolitPartieService
	{

		Task<List<PolitParties>> GetAllPolitParties();
		Task Add(PolitParties model);
		Task<PolitParties> GetPolitParts(int id);
		Task DeletePolitParties(PolitParties model);
		void Update(PolitParties politParties);
	}
}
