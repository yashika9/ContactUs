using ContactForms.ContactForm.Model;
using ContactForms.ContactForm.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ContactForms.ContactForm.Business
{
    public class ContactLogic
    {
        public async Task<string> SaveContacts(Contact contact)
        {
            ContactRepo contactRepo = new ContactRepo();
            try
            {
                if (contact != null)
                {
                    return await contactRepo.SaveContact(contact);
                }
            }
            catch (Exception)
            {
                throw new Exception("Cannot save empty contact!");
            }
            return "";
        }
    }
}