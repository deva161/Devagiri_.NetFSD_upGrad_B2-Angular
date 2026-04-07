
using System.Collections.Generic;

public interface IContactRepository
{
    IEnumerable<ContactInfo> GetAllContacts();
    ContactInfo GetContactById(int id);
    void AddContact(ContactInfo contact);
    void UpdateContact(ContactInfo contact);
    void DeleteContact(int id);

    IEnumerable<Company> GetCompanies();
    IEnumerable<Department> GetDepartments();
}
