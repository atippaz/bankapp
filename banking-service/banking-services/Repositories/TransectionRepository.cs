using banking_service.DB;
using Microsoft.EntityFrameworkCore;

namespace banking_service.Repositories
{
    public class TransectionRepository
    {
        ContextDB database;
        public TransectionRepository(ContextDB database)
        {
            this.database = database;
        }
        public async Task<List<Transection>> GetAll()
        {
            return await database.Transections.ToListAsync();
        }
    }
}
