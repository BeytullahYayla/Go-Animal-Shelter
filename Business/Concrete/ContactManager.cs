using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal= contactDal;
        }
        
        public IResult Add(Contact contact)
        {
            _contactDal.Add(contact);
            return new SuccessResult("Basariyla Eklendi");
        }

        public IDataResult<List<Contact>> GetAll()
        {
            return new SuccessDataResult<List<Contact>>(_contactDal.GetAll(),"Basariyla Eklendi");
        }

        public IResult Remove(Contact contact)
        {
            _contactDal.Delete(contact);
            return new SuccessResult("Basariyla Silindi");
        }

        public IResult Update(Contact contact)
        {
            _contactDal.Update(contact);
            return new SuccessResult("Basariyla Guncellendi");
        }
    }
}
