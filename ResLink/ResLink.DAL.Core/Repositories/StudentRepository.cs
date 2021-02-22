using BackendlessAPI.Persistence;
using ResLink.BL.Models;
using ResLink.DL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ResLink.DAL.Repositories
{
    public class StudentRepository
    {
        private ResLinkDatabase db = null;
        protected static StudentRepository instance;
        private static DataQueryBuilder queryBuilder;

        static StudentRepository()
        {
            instance = new StudentRepository();
        }

        protected StudentRepository()
        {
            db = new ResLinkDatabase();
            queryBuilder = DataQueryBuilder.Create();
        }

        public static async Task<IEnumerable<Student>> GetStudent()
        {
            return await instance.db.GetItems<Student>();
        }

        public static async Task<Student> GetStudentById(string id)
        {
            return await instance.db.GetItem<Student>(id);
        }

        public static async Task<IEnumerable<Student>> GetRegularStudents()
        {
            var user = await UserAccountRepository.GetRelations((await UserAccountRepository.GetCurrentlyLoggedAccount()).ObjectId);
            var loggedResidence = user.GetProperty("residence") as Residence;

            string whereClause = $"objectId in (Student[studentAccount.residence.objectId = '{loggedResidence.objectId}' and studentAccount.userRole.roleId = '2'].objectId)";

            queryBuilder.SetWhereClause(whereClause);
            queryBuilder.AddRelated("studentAccount.residence");
            queryBuilder.AddRelated("studentAccount.residence.residenceManager");
            queryBuilder.AddRelated("gender");

            return await instance.db.GetItems<Student>(queryBuilder);

        }

        public static async Task<Student> SaveStudent(Student item)
        {
            return await instance.db.SaveItem<Student>(item);
        }

        public static async Task DeleteStudent(string objectId)
        {
            await instance.db.DeleteItem<Student>(objectId);
        }

        public static async Task SetRelation<Student>(Student parentObject, string relationColumnName, object[] children)
        {
            await instance.db.SetRelation<Student>(parentObject, relationColumnName, children);
        }
    }
}
