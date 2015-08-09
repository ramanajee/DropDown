using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UoWDemo.DAL;
using UoWDemo.Models;
using UoWDemo.Repository;

namespace UoWDemo.UoW
{
    public class UnitOfWork : IDisposable
    {
        private InformationContext context;
        private Repository<Employee> employeeRepository;
        private Repository<Student> studentRepository;
        public Repository<Employee> EmployeeRepository
        {
            get
            {
                if (this.employeeRepository == null)
                {
                    this.employeeRepository = new Repository<Employee>(context);
                }
                return this.employeeRepository;
            }
        }
        public Repository<Student> StudentRepository
        {
            get
            {
                if (this.studentRepository == null)
                {
                    this.studentRepository = new Repository<Student>(context);
                }
                return this.studentRepository;
            }
        }

        public InformationContext Context1
        {
            get
            {
                return context;
            }

            set
            {
                context = value;
            }
        }

        public void Save()
        {
           context.SaveChanges();
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
