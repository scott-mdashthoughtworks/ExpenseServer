using ExpenseRepository;
using ExpenseRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ExpenseServer.Controllers
{
    public class ExpenseController : ApiController
    {
        // GET: api/Expense
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Expense/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Expense
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Expense/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Expense/5
        //public void Delete(int id)
        //{
        //}

        [Route("Exp/GetCategories")]
        [HttpGet]
        public List<ExpCategory> GetCategories()
        {
            Task<List<ExpCategory>> t = ExpenseDataService.GetExpCategoryList();
            t.Wait();
            return t.Result ;
        }
        [Route("Exp/GetUserByEmail/{email}")]
        [HttpGet]
        public ExpUser GetUserByEmail(string email)
        {
            
            return  ExpenseDataService.GetUserByEmail(email);
        }
        [Route("Exp/GetUserById/{Id}")]
        [HttpGet]
        public ExpUser GetUserById(string Id)
        {

            return ExpenseDataService.GetUserById(Guid.Parse(Id));
        }
        [Route("Exp/GetUsers")]
        [HttpGet]
        public List<ExpUser> GetUsers()
        { 
            return ExpenseDataService.ListAllUsers();
        }
        //[Route("Exp/GetCategories")]
        //[HttpGet]
        //public List<ExpCategory> ListExpCategories()
        //{
        //    return ExpenseDataService.ListExpCategories();
        //}
        [Route("Exp/GetPersonalCategories/{user}")]
        [HttpGet]
        public List<ExpPersonalCategory> ListPersonalExpCategories(Guid user)
        {
            return ExpenseDataService.ListPersonalExpCategories(user);
        }
        [Route("Exp/ListExpenesForUser/{user}")]
        [HttpGet]
        public List<ExpenseRecord> ListExpensesForUser(Guid user)
        {
            return ExpenseDataService.ListExpensesForUser(user);
        }
        [Route("Exp/ListExpensesForUserAndDateRange/{user}/{date1}/{date2}")]
        [HttpGet]
        public List<ExpenseRecord> ListExpensesForUserAndDateRange(Guid OwnerId, DateTime date1, DateTime date2)
        {
            return ExpenseDataService.ListExpensesForUserAndDateRange( OwnerId,  date1,  date2);
        }

        [Route("Exp/ListExpensesForUserAndNotPosted/{user}")]
        [HttpGet]
        public  List<ExpenseRecord> ListExpensesForUserAndNotPosted(Guid user)
        {
            return ExpenseDataService.ListExpensesForUserAndNotPosted(user);
        }
        [Route("Exp/AddExpenseRecord")]
        [HttpPost]
        public void AddExpenseRecord([FromBody] ExpenseRecordType expData)
        {
            ExpenseDataService.AddExpenseRecord(expData);
        }
    }
}
