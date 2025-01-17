using System;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using ApplicationCore;
using System.Threading.Tasks;
namespace Infrastructure.Persistence.Repos
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        protected new GreenairContext Context => base.Context as GreenairContext;
        public PersonRepository(GreenairContext context) : base(context)
        {

        }

        private async Task changePersonStatus(string person_id, STATUS status)
        {
            try
            {
                var person = await this.GetByAsync(person_id);
                person.Status = status;
                this.Context.Update(person);
                await this.Context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine("ChangeAccountStatus() Unexpected: " + e);
            }
        }

        public async Task activate(string person_id)
        {
            await this.changePersonStatus(person_id, STATUS.AVAILABLE);
        }

        public async Task disable(string person_id)
        {
            await this.changePersonStatus(person_id, STATUS.DISABLED);
        }
    }
}