using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDInWebAPIs.Data;
using CRUDInWebAPIs.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDInWebAPIs.Controllers
{
    //C : maloc() aloc() --> free()
    //C++ : new --> delete
    //C# or Java : new --> GarbageCollector
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        OrganizationDbContext myDbContext;

        public DepartmentsController(OrganizationDbContext myDbContext)
        {
            this.myDbContext = myDbContext;
        }

        // GET: api/Departments
        [HttpGet]
        public IEnumerable<Department> Get()
        {
            return myDbContext.Departments.ToList();            

            #region Dispose
            //OrganizationDbContext dbContext = new OrganizationDbContext();
            //var departments = dbContext.Departments.ToList();
            //dbContext.Dispose();
            //return departments; 
            #endregion

            #region Using
            //IEnumerable<Department> departments;
            //using(var dbContext = new OrganizationDbContext())
            //{
            //    departments = dbContext.Departments.ToList();
            //}            
            //return departments; 
            #endregion
        }

        //// GET: api/Departments/5
        [HttpGet("{id}", Name = "Get")]
        public Department Get(int id)
        {
            return myDbContext.Departments.Find(id);
        }

        //// POST: api/Departments
        [HttpPost]
        public void Post(Department department)
        {
            myDbContext.Departments.Add(department);
            myDbContext.SaveChanges();
        }

        //// PUT: api/Departments/5
        [HttpPut("{id}")]
        public void Put(int id, Department department)
        {
            myDbContext.Departments.Update(department);
            myDbContext.SaveChanges();
        }

        //// DELETE: api/Departments/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var department = myDbContext.Departments.Find(id);
            myDbContext.Departments.Remove(department);
            myDbContext.SaveChanges();
        }
    }

    #region Old Code
    //[Route("api/[controller]")]
    //[ApiController]
    //public class DepartmentsController : ControllerBase
    //{
    //    OrganizationDbContext myDbContext;

    //    public DepartmentsController()
    //    {
    //        myDbContext = new OrganizationDbContext();
    //    }

    //    // GET: api/Departments
    //    [HttpGet]
    //    public IEnumerable<Department> Get()
    //    {
    //        return myDbContext.Departments.ToList();
    //    }

    //    //// GET: api/Departments/5
    //    [HttpGet("{id}", Name = "Get")]
    //    public Department Get(int id)
    //    {
    //        return myDbContext.Departments.Find(id);
    //    }

    //    //// POST: api/Departments
    //    [HttpPost]
    //    public void Post(Department department)
    //    {
    //        myDbContext.Departments.Add(department);
    //        myDbContext.SaveChanges();
    //    }

    //    //// PUT: api/Departments/5
    //    [HttpPut("{id}")]
    //    public void Put(int id, Department department)
    //    {
    //        myDbContext.Departments.Update(department);
    //        myDbContext.SaveChanges();
    //    }

    //    //// DELETE: api/Departments/5
    //    [HttpDelete("{id}")]
    //    public void Delete(int id)
    //    {
    //        var department= myDbContext.Departments.Find(id);
    //        myDbContext.Departments.Remove(department);
    //        myDbContext.SaveChanges();
    //    }
    //} 
    #endregion
}
