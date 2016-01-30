using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseRepository.Models
{
    public class UserType
    {
        public System.Guid id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> OrgId { get; set; }

        public static UserType ConvertFromGetUserById_Result(GetUserById_Result s)
        {
            return new UserType()
            {
                id = s.id,
                email = s.email,
                password = s.password,
                FirstName = s.FirstName,
                LastName = s.LastName,
                OrgId = s.OrgId
            };
        }

        public static UserType ConvertFromGetUserByEmail_Result(GetUserByEmail_Result s)
        {
            return new UserType()
            {
                id = s.id,
                email = s.email,
                password = s.password,
                FirstName = s.FirstName,
                LastName = s.LastName,
                OrgId = s.OrgId
            };
        }

        public static UserType ConvertFromListAllUsers_Result(ListAllUsers_Result s)
        {
            return new UserType()
            {
                id = s.id,
                email = s.email,
                password = s.password,
                FirstName = s.FirstName,
                LastName = s.LastName,
                OrgId = s.OrgId
            };
        }
    }
}
