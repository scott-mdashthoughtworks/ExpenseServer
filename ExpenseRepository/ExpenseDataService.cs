using ExpenseRepository.Cache;
using ExpenseRepository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseRepository
{
    public static class ExpenseDataService
    {
        public static MDashExpenseEntities GetConnection()
        {
            return new MDashExpenseEntities();
        }
        #region GetExpCategoryList()
        public static async Task<List<ExpCategory>> GetExpCategoryList()
        {
            List<ExpCategory> ret;
            try
            {
                using (MDashExpenseEntities ee = GetConnection())
                {
                    ret =  ee.ExpCategories
                        .OrderBy(a => a.SortOrder)
                        .OrderBy(a => a.Name)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("GetExpCategoryList Failed", ex);
            }
            return ret;
        }

        public static int AddExpCategory(ExpCategory expCat)
        {
            int ret = 0;
            try
            {
                using (MDashExpenseEntities ee = GetConnection())
                {
                    ee.ExpCategories.Add(expCat);
                    ee.SaveChanges();
                    ret = expCat.id;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("GetExpCategoryList Failed", ex);
            }
            return ret;
        }

        public static void UpdateExpCategory(ExpCategory expCat)
        {
            try
            {
                using (MDashExpenseEntities ee = GetConnection())
                {
                    ExpCategory expc = ee.ExpCategories.Find(expCat.id);
                    expc.Name = expCat.Name;
                    expc.SortOrder = expCat.SortOrder;
                    ee.Entry(expc).State = EntityState.Modified;
                    ee.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("UpdateExpCategory Failed", ex);
            }
        }
        #endregion

        public static void AddExpenseRecord(ExpenseRecordType expData)
        {
            try
            {
                using (MDashExpenseEntities ee = GetConnection())
                {
                    ee.AddExpenseRecord(expData.OwnerId, expData.ExpDate, expData.Description, expData.Amount, expData.Posted, expData.PersonalCatId, expData.CatId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("AddExpenseRecord Failed", ex);
            }
        }
        public static int AddExpPersonalCategory(Guid OwnerId, string Name, int SortOrder)
        {
            int ret = 0;
            try
            {
                using (MDashExpenseEntities ee = GetConnection())
                {
                    ret = ee.AddExpPersonalCategories(OwnerId, Name, SortOrder);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("AddExpPersonalCategory Failed", ex);
            }
            return ret;
        }

        public static int AddUser(Guid UserId, string Email, string password, string FirstName, string LastName, int OrgId)
        {
            int ret = 0;
            try
            {
                using (MDashExpenseEntities ee = GetConnection())
                {
                    ret = ee.addUser(UserId, Email, password, FirstName, LastName, OrgId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("AddUser Failed", ex);
            }
            return ret;
        }

        public static void DeleteExpCategories(int id)
        {
            try
            {
                using (MDashExpenseEntities ee = GetConnection())
                {
                    ee.DeleteExpCategories(id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DeleteExpCategories Failed", ex);
            }
        }

        public static void DeleteExpenseRecord(int id)
        {
            try
            {
                using (MDashExpenseEntities ee = GetConnection())
                {
                    ee.DeleteExpenseRecord(id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DeleteExpenseRecord Failed", ex);
            }
        }

        public static void DeleteExpPersonalCategory(int id)
        {
            try
            {
                using (MDashExpenseEntities ee = GetConnection())
                {
                    ee.DeleteExpPersonalCategories(id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DeleteExpPersonalCategory Failed", ex);
            }
        }

        public static void UpdateExpenseRecord(ExpenseRecordType expData)
        {
            try
            {
                using (MDashExpenseEntities ee = GetConnection())
                {
                    ee.UpdateExpenseRecord(expData.Id, expData.OwnerId, expData.ExpDate, expData.Description, expData.Amount, expData.Posted, expData.PersonalCatId, expData.CatId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("UpdateExpenseRecord Failed", ex);
            }
        }

        public static int updateUser(Guid UserId, string Email, string password, string FirstName, string LastName, int OrgId)
        {
            int ret = 0;
            try
            {
                using (MDashExpenseEntities ee = GetConnection())
                {
                    ret = ee.updateUser(UserId, Email, password, FirstName, LastName, OrgId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("updateUser Failed", ex);
            }
            return ret;
        }

        public static ExpUser GetUserByEmail(string Email)
        {
            ExpUser ret = null;
            try
            {
                using (MDashExpenseEntities ee = GetConnection())
                {
                    ret = ee.GetUserByEmail(Email).FirstOrDefault();
                }
                if (ret == null)
                {
                    throw new Exception($"Email {Email} Not Found");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("GetUserByEmail Failed", ex);
            }
            return ret;
        }
        public static ExpUser GetUserById(Guid id)
        {
            ExpUser ret = null;
            try
            {
                using (MDashExpenseEntities ee = GetConnection())
                {
                    ret = ee.GetUserById(id).FirstOrDefault();
                }
                if (ret == null)
                {
                    throw new Exception($"Id {id.ToString()} Not Found");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("GetUserById Failed", ex);
            }
            return ret;
        }

        public static List<ExpUser> ListAllUsers()
        {
            List<ExpUser> ret = null;
            try
            {
                using (MDashExpenseEntities ee = GetConnection())
                {
                    ret = ee.ListAllUsers().ToList();
                }
                if (ret == null)
                {
                    throw new Exception($"No Records Found");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ListAllUsers Failed", ex);
            }
            return ret;
        }
        public static List<ExpPersonalCategory> ListPersonalExpCategories(Guid User)
        {
            List<ExpPersonalCategory> ret = null;
            try
            {
                using (MDashExpenseEntities ee = GetConnection())
                {
                    ret = ee.ExpPersonalCategories.Where(a=> a.OwnerId ==User).ToList();
                }
                if (ret == null)
                {
                    throw new Exception($"No Records Found");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ListPersonalExpCategories Failed", ex);
            }
            return ret;
        }
        public static List<ExpCategory> ListExpCategories()
        {
            List<ExpCategory> ret = null;
            try
            {
                ret = ExpCategoryCache.Items.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("ListExpCategories Failed", ex);
            }
            return ret;
        }

        public static List<ExpenseRecord> ListExpensesForUser(Guid OwnerId)
        {
            List<ExpenseRecord> ret = null;
            try
            {
                using (MDashExpenseEntities ee = GetConnection())
                {
                    ret = ee.listExpensesForUser(OwnerId).ToList();
                }
                if (ret == null)
                {
                    throw new Exception($"No Records Found");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ListExpensesForUser Failed", ex);
            }
            return ret;
        }
        public static List<ExpenseRecord>ListExpensesForUserAndDateRange(Guid OwnerId, DateTime date1,DateTime date2 )
        {
            List<ExpenseRecord> ret = null;
            try
            {
                using (MDashExpenseEntities ee = GetConnection())
                {
                    ret = ee.listExpensesForUserAndDateRange(OwnerId, date1, date2 ).ToList();
                }
                if (ret == null)
                {
                    throw new Exception($"No Records Found");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ListExpensesForUserAndDateRange Failed", ex);
            }
            return ret;
        }
        public static List<ExpenseRecord> ListExpensesForUserAndNotPosted(Guid OwnerId)
        {
            List<ExpenseRecord> ret = null;
            try
            {
                using (MDashExpenseEntities ee = GetConnection())
                {
                    ret = ee.listExpensesForUserAndNotPosted(OwnerId).ToList();
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception("ListExpensesForUserAndNotPosted Failed", ex);
            }
            return ret;
        }
    }
}
