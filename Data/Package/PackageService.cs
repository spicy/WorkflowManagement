using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkflowManagement.Data
{
    public class PackageService
    {
        #region Property
        private readonly AppDBContext _appDBContext;
        #endregion

        #region Constructor
        public PackageService(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Packages
        public async Task<List<Package>> GetAllPackagesAsync()
        {
            return await _appDBContext.Packages.Include(p => p.Services).ToListAsync();
        }
        #endregion

        #region Insert Package
        public async Task<bool> InsertPackageAsync(Package package)
        {
            await _appDBContext.Packages.AddAsync(package);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> InsertPackageServiceAsync(PackageServices packageService)
        {
            await _appDBContext.PackageServices.AddAsync(packageService);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Package by Id
        public async Task<Package> GetPackageAsync(int Id)
        {
            Package package = await _appDBContext.Packages.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return package;
        }
        #endregion

        #region Get List of Services
        public async Task<List<PackageServices>> GetPackageServicesAsync(Package package)
        {
            return await _appDBContext.PackageServices.Where(x => x.Package == package).ToListAsync();
        }
        #endregion

        #region Update Package
        public async Task<bool> UpdatePackageAsync(Package package)
        {
            _appDBContext.Packages.Update(package);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Delete Package
        public async Task<bool> DeletePackageAsync(Package package)
        {
            _appDBContext.Remove(package);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
