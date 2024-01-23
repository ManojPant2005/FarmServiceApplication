using FarmServiceApplication.Data;
using FarmServiceApplication.Db;
using Microsoft.EntityFrameworkCore;

namespace FarmServiceApplication.Services
{
    public class ExpenseService
    {
        private readonly AppDbContext _context;

        public ExpenseService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Expense>> GetAllExpense()
        {
            return await _context.Expenses.ToListAsync();
        }

        //Add New Record
        public async Task<bool> AddNewExpenseDetails(Expense  expense)
        {
            await _context.Expenses.AddAsync(expense);
            await _context.SaveChangesAsync();
            return true;
        }
        //GetEmployee Records by ID
        public async Task<Expense> GetExpenseById(int id)
        {
            Expense farm = await _context.Expenses.FirstOrDefaultAsync(x => x.ExpensesId == id);
            return farm;
        }

        //Update Employee Data
        public async Task<bool> UpdateExpenseDetails(Expense expense)
        {
            _context.Expenses.Update(expense);
            await _context.SaveChangesAsync();
            return true;

        }

        //Delete Employee Data
        public async Task<bool> DeleteExpenseDetails(Expense expense)
        {
            _context.Expenses.Remove(expense);
            await _context.SaveChangesAsync();
            return true;

        }
    }
}
