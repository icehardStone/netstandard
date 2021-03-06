using Xunit;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using sample_use_in_memroy;
using sample_use_in_memroy.Model;
using sample_use_in_memroy.Reponsitory;

namespace sample_use_in_memroy_test
{
    public class InMemoryUnit
    {
        [Fact]
        public void IsUseMemory()
        {
            var options = new DbContextOptionsBuilder<MemoryContext>()
                .UseInMemoryDatabase(databaseName:"test")
                .Options;

            using(MemoryContext context = new MemoryContext(options))
            {
                var personService = new PersonService(context);
                Person p = new Person()
                {
                    ID = Guid.NewGuid().ToString(),
                    Name = "admas"
                };

                personService.Add(p);

                var temp = personService.Find(p.ID);

                Assert.NotNull(temp);
            }
        }
    }
}
