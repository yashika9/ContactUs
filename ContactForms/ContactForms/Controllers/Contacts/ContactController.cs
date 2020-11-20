using ContactForms.ContactForm.Business;
using ContactForms.ContactForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ContactForms.Controllers.Contacts
{
    [RoutePrefix("api/Contact")]
    public class ContactController : ApiController
    {
        [HttpPost]
        [Route("saveContact")]
        public async Task<IHttpActionResult> SaveContact([FromBody]Contact contact)
        {
            try
            {
                //save contact from http request body
                ContactLogic contactLogic = new ContactLogic();
                var email = await contactLogic.SaveContacts(contact);
                return Ok(email);

            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }
        }
    }
}
