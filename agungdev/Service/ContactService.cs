using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agungdev.Models;

namespace agungdev.Service
{
    public class ContactService : IContactService
    {
        private readonly AgungDevContext _context;

        public ContactService(AgungDevContext context)
        {
            _context = context;
        }


        public Contact GetById(int id)
        {
            if (id <= 0)
            {
                return null;
            }

            try
            {
                return _context.Contacts.Where(x => x.IdContact == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Contact> GetContact()
        {
            throw new NotImplementedException();
        }

        public Contact UpdateContact(Contact contact)
        {
            var data = _context.Contacts.Where(x => x.IdContact == contact.IdContact).FirstOrDefault();

            if (data != null)
            {
                data.Address = contact.Address;
                data.Phone = contact.Phone;
                data.Email = contact.Email;

                _context.SaveChanges();

                return data;
            }
            return null;
        }
        public Contact UpdateSocialMedia(Contact contact)
        {
            if (contact == null)
            {
                return null;
            }

            try
            {
                var data = _context.Contacts.Where(x => x.IdContact == contact.IdContact).FirstOrDefault();

                data.Linkedin = contact.Linkedin;
                data.Instagram = contact.Instagram;
                data.Twitter = contact.Twitter;
                data.Facebook = contact.Facebook;
                data.Github = contact.Github;

                _context.SaveChanges();

                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    public interface IContactService
    {
        IEnumerable<Contact> GetContact();
         Contact GetById(int id);
        Contact UpdateContact(Contact contact);
        Contact UpdateSocialMedia(Contact contact);
    }
}
