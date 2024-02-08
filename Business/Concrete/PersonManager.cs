using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;

namespace Business.Concrete
{
    //Ciplak class kalmasin
    public class PersonManager : IApplicantService
    {
        //encapsulation
        public void ApplyForMask(Person person)
        {

        }

        public List<Person> GetList()
        {
            return null;
        }

        //Ptt bu kisinin dogrulugunu(vatandas mi?) kontrol edecek.Mernise baglanacak.Kisinin dogrulugunu kontrol edecek.
        public bool CheckPerson(Person person)
        {

            //Burada mernis kontrolu yapilacak.
            return true;
        }
    }
}
