using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseRepository;


namespace ExpenseRepository.Cache
{
    
    public static class ExpCategoryCache
    {
        private static List<ExpCategory> items = null; 
         
        public static   List<ExpCategory>  Items
        {   get
            {
                if (items == null)
                {
                    lock (items)
                    {
                         LoadData();
                    }
                }
                return items;
            }
            set
            {
                lock(items)
                { 
                    items = value;
                }
            }
        }


        private static async void LoadData()
        {
            items =  await ExpenseDataService.GetExpCategoryList();
        }

        public static void Clear()
        {
            Items.Clear();
        }

        public static void Refresh()
        {
            lock(items)
            {
                LoadData();
            }
        }

        public static ExpCategory get(int id)
        {
            return Items.FirstOrDefault(a => a.id == id);
        }
        public static ExpCategory get(string name)
        {
            return Items.FirstOrDefault(a => a.Name == name);
        }
        public static IQueryable<ExpCategory> GetList()
        {
            return Items.AsQueryable();
        }
        public static ExpCategory AddItem(ExpCategory expCat)
        {
            expCat.id = ExpenseDataService.AddExpCategory(expCat);
            Refresh();
            return expCat;
        }
        public static void UpdateExpCategory (ExpCategory expCat)
        {
            ExpenseDataService.UpdateExpCategory(expCat);
            Refresh(); 
        }
    }
}
