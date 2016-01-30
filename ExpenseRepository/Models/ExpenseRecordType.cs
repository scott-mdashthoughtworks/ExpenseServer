using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseRepository.Models
{
    public class ExpenseRecordType
    {
        /// <summary>
        /// record id
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// OwnerId - the account this record belongs to.
        /// </summary>
        public Guid OwnerId { get; set; }
        /// <summary>
        /// Date of Expense
        /// </summary>
        public DateTime ExpDate { get; set; }
        /// <summary>
        /// Description of Expense
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Amount of Expense
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// Date Posted - null is not posted.
        /// </summary>
        public DateTime? Posted { get; set; }
        /// <summary>
        /// Personal Category Id 
        /// </summary>
        public int? PersonalCatId { get; set; }
        /// <summary>
        /// Expense Category Id
        /// </summary>
        public int? CatId { get; set; }

        public static ExpenseRecordType Load(ExpenseRecord expData)
        {
            return new ExpenseRecordType()
            {
                Amount = expData.Amount,
                CatId = expData.CategoriesId,
                Description = expData.Description,
                Id = expData.id,
                ExpDate = expData.ExpDate,
                OwnerId = expData.OwnerId,
                PersonalCatId = expData.PersonalCategoryId,
                Posted = expData.Posted
            };
        }
    }
}
