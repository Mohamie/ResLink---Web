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

        static StudentRepository()
        {
            instance = new StudentRepository();
        }

        protected StudentRepository()
        {
            db = new ResLinkDatabase();
        }

        public static async Task<IEnumerable<Student>> GetStudent()
        {
            return await instance.db.GetItems<Student>();
        }

        public static async Task<Student> GetStudentById(string id)
        {
            return await instance.db.GetItem<Student>(id);
        }

        public static async Task<Student> SaveStudent(Student item)
        {
            return await instance.db.SaveItem<Student>(item);
        }

        public static async Task DeleteStudent(string objectId)
        {
            await instance.db.DeleteItem<Student>(objectId);
        }

        public async Task SetRelation<Student>(Student parentObject, string relationColumnName, object[] children)
        {
            await instance.db.SetRelation<Student>(parentObject, relationColumnName, children);
        }
    }
}
