using ContactForms.ContactForm.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ContactForms.ContactForm.Repository
{
    public class ContactRepo
    {
        public async Task<string> SaveContact(Contact contact)
        {           
            var filename = "Contacts.txt";
            
            var contents = $"{Environment.NewLine}First Name: {contact.FirstName}{Environment.NewLine}Last Name: {contact.LastName}{Environment.NewLine}Email: {contact.Email}{Environment.NewLine}Message: {contact.Message}";
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + filename))
            {
                await Task.Run(() => File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + filename, contents));
            }
            else
            {
                await Task.Run(() => File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + filename, contents));
            }
            return contact.Email;
        }
        
    }
}