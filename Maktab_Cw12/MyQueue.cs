using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Maktab_Cw12
{
    public class MyQueue<T> where T : Student
    {
        public List<T> list = new List<T>();
        public MyQueue()
        {
        }
        public void EnQueue(T item)
        {
            list.Add(item);
        }
        public T? DeQueue()
        {
            var temp = list.FirstOrDefault();
            if (temp != null)
            {
                list.Remove(temp);
            }
            return temp;
        }
        public List<T> SearchByFirstName(string firstName)
        {
            return list.Where(x => x.FirstName == firstName).ToList();
        }
        public List<string> GetLastNameByFirstName(string firstName)
        {
            return list.Where(x => x.FirstName == firstName).Select(x => x.GetFullName()).ToList();
            list.First();
        }

        public bool x(T item, string firstName)
        {
            return item.FirstName == firstName;
        }
    }
}
