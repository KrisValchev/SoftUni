using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    internal class Family
    {
        private List<Person> members=new List<Person>();

		public List<Person> Members
		{
			get { return members; }
			set { members = value; }
		}
		public void AddMember(Person member)
		{
			Members.Add(member);
		}
        public Person GetOldestMember()
        {
			return Members.OrderByDescending(x=>x.Age).First();
        }
    }
}
