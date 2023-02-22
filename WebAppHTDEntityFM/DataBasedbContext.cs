using Microsoft.EntityFrameworkCore;
namespace WebAppHTDEntityFM.Models
{
    public class DataBasedbContext : DbContext
    {
        public DataBasedbContext()
        {

        }
        public DataBasedbContext(DbContextOptions<DataBasedbContext> options) : base(options)
        {

        }
        public virtual DbSet<ProductsModel> PRODUCTSS { get; set; }
        public virtual DbSet<ItemsModel> ITEMS { get; set; }
        public virtual DbSet<StudentsModel> STUDENTS { get; set; }
        public virtual DbSet<EmployeeModel> EMPLOYEE { get; set; }
        public virtual DbSet<OrdersModel> Orderss { get; set; }
        public virtual DbSet<EmpModel> Employeee { get; set; }
        public virtual DbSet<EmpAddressModel> EmpAdd { get; set; }
        public virtual DbSet<Employee> employee1 { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<AutoData> AutoData { get; set; }
    }
}
