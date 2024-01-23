using FarmServiceApplication.Data;
using FarmServiceApplication.Db;
using Microsoft.EntityFrameworkCore;

namespace FarmServiceApplication.Services
{
    public class FarmService
    {
        private readonly AppDbContext _context;

        public FarmService(AppDbContext context)
        {
            _context = context;
        }
        public  async Task<List<Farm>> GetAllFarms()
        {
            return await _context.Farms.ToListAsync();
        }

        //Add New Record
        public async Task<bool> AddNewFarmDetails(Farm farm)
        {
            await _context.Farms.AddAsync(farm);
            await _context.SaveChangesAsync();
            return true;
        }
        //GetEmployee Records by ID
        public async Task<Farm> GetFarmsById(int FarmId)
        {
            Farm farm = await _context.Farms.FirstOrDefaultAsync(x => x.FarmId == FarmId);
            return farm;
        }

        //Update Employee Data
        public async Task<bool> UpdateFarmDetails(Farm farm)
        {
            _context.Farms.Update(farm);
            await _context.SaveChangesAsync();
            return true;

        }

        //Delete Employee Data
        public async Task<bool> DeleteFarmDetails(Farm farm)
        {
            _context.Farms.Remove(farm);
            await _context.SaveChangesAsync();
            return true;

        }
    }
}
