using FarmServiceApplication.Data;
using FarmServiceApplication.Db;
using Microsoft.EntityFrameworkCore;

namespace FarmServiceApplication.Services
{
    public class CropService
    {
        private readonly AppDbContext _context;

        public CropService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Crop>> GetAllCrop()
        {
            return await _context.Crops.ToListAsync();
        }

        //Add New Record
        public async Task<bool> AddNewCropDetails(Crop crops)
        {
            await _context.Crops.AddAsync(crops);
            await _context.SaveChangesAsync();
            return true;
        }
        //GetEmployee Records by ID
        public async Task<Crop> GetCropeById(int id)
        {
            Crop farm = await _context.Crops.FirstOrDefaultAsync(x => x.CropId == id);
            return farm;
        }

        //Update Employee Data
        public async Task<bool> UpdateCropsDetails(Crop farm)
        {
            _context.Crops.Update(farm);
            await _context.SaveChangesAsync();
            return true;

        }

        //Delete Employee Data
        public async Task<bool> DeleteExpenseDetails(Crop farm)
        {
            _context.Crops.Remove(farm);
            await _context.SaveChangesAsync();
            return true;

        }
    }
}
