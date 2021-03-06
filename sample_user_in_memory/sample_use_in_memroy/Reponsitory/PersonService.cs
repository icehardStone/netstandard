using System;
using sample_use_in_memroy.Model;
using System.Linq;

namespace sample_use_in_memroy.Reponsitory
{
    public class PersonService
    {
        private MemoryContext _context;
        public PersonService(MemoryContext context)
        {
            this._context = context;
        }

        public void Add(Person person )
        {
            _context.Perons.Add(person);
            _context.SaveChanges();
        }
        public Person Find(string id)
        {
            return _context.Perons
                .Where(o => o.ID == id)
                .FirstOrDefault();
        }
    }
}
