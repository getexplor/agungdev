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
        ContactViewModel contactVM = null;

        public ContactService(AgungDevContext context)
        {
            _context = context;
        }


        public ContactViewModel GetById(int id)
        {
            contactVM = _context.Contacts.Where(x => x.IdContact == id).Select(x => new ContactViewModel()
            {
                IdContact = x.IdContact,
                Address = x.Address,
                Email = x.Email,
                Facebook = x.Facebook,
                Github = x.Github,
                Instagram = x.Instagram,
                Linkedin = x.Linkedin,
                Phone = x.Phone,
                Twitter = x.Twitter
            }).FirstOrDefault<ContactViewModel>();
            return contactVM;
        }

        public IEnumerable<Contact> GetContact()
        {
            throw new NotImplementedException();
        }

        public ContactViewModel UpdateContact(ContactViewModel contactVM)
        {
            try
            {
                var data = _context.Contacts.Where(x => x.IdContact == contactVM.IdContact).FirstOrDefault();

                if (data != null)
                {
                    data.Address = contactVM.Address;
                    data.Phone = contactVM.Phone;
                    data.Email = contactVM.Email;

                    _context.SaveChanges();

                }
                return null;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public ContactViewModel UpdateSocialMedia(ContactViewModel contactVM)
        {
            try
            {
                var data = _context.Contacts.Where(x => x.IdContact == contactVM.IdContact).FirstOrDefault();
                if (data != null)
                {
                    data.Linkedin = contactVM.Linkedin;
                    data.Instagram = contactVM.Instagram;
                    data.Twitter = contactVM.Twitter;
                    data.Facebook = contactVM.Facebook;
                    data.Github = contactVM.Github;

                    _context.SaveChanges();
                }
                return null;
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
        ContactViewModel GetById(int id);
        ContactViewModel UpdateContact(ContactViewModel contactVM);
        ContactViewModel UpdateSocialMedia(ContactViewModel contactVM);
    }
}
