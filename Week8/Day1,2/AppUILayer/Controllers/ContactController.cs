
using Microsoft.AspNetCore.Mvc;

[Route("contact")]
public class ContactController : Controller
{
    private readonly IContactRepository _repo;

    public ContactController(IContactRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("list")]
    public IActionResult ShowContacts()
    {
        return View(_repo.GetAllContacts());
    }

    [HttpGet("details/{id}")]
    public IActionResult Details(int id)
    {
        return View(_repo.GetContactById(id));
    }

    [HttpGet("add")]
    public IActionResult Add()
    {
        ViewBag.Companies = _repo.GetCompanies();
        ViewBag.Departments = _repo.GetDepartments();
        return View();
    }

    [HttpPost("add")]
    public IActionResult Add(ContactInfo c)
    {
        _repo.AddContact(c);
        return RedirectToAction("ShowContacts");
    }

    [HttpGet("edit/{id}")]
    public IActionResult Edit(int id)
    {
        ViewBag.Companies = _repo.GetCompanies();
        ViewBag.Departments = _repo.GetDepartments();
        return View(_repo.GetContactById(id));
    }

    [HttpPost("edit")]
    public IActionResult Edit(ContactInfo c)
    {
        _repo.UpdateContact(c);
        return RedirectToAction("ShowContacts");
    }

    [HttpGet("delete/{id}")]
    public IActionResult Delete(int id)
    {
        return View(_repo.GetContactById(id));
    }

    [HttpPost("delete")]
    public IActionResult DeleteConfirmed(int ContactId)
    {
        _repo.DeleteContact(ContactId);
        return RedirectToAction("ShowContacts");
    }
}
