using FarmServiceApplication.Data;
using FarmServiceApplication.Db;
using Microsoft.EntityFrameworkCore;

namespace FarmServiceApplication.Services
{
    public class IncomeService
    {
        private readonly AppDbContext _context;

        public IncomeService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Income>> GetAllIncome()
        {
            return await _context.Incomes.ToListAsync();
        }
        public async Task<bool> AddNewIncomeDetails(Income income)
        {
            await _context.Incomes.AddAsync(income);
            await _context.SaveChangesAsync();
            return true;
        }


    }
}
