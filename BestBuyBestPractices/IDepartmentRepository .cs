using System.Collections.Generic;

namespace BestBuyBestPractices
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartments();
        void CreateDepartment(string Name);
    }
}