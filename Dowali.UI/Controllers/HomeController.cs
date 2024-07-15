using Core.Entities;
using Core.Interfaces;
using Dowali.Core.Entities;
using Dowali.Core.Interfaces;
using Dowali.UI.Dto;
using Microsoft.AspNetCore.Mvc;
using PlayApp.Extentions;

namespace PlayApp.Controllers;

//[Authorize]
public class HomeController : BaseController
{
    private readonly ILogger<HomeController> _logger;

    private readonly IUser _user;
    private readonly IProject _project;
    private readonly IInvestgator _invitgator;
    private readonly IFinancial _financial;


    public HomeController(ILogger<HomeController> logger, IUser user, IProject project, IInvestgator investgator, IFinancial financial)
    {
        _logger = logger;
        _user = user;
        _financial = financial;
        _project = project;
        _invitgator = investgator;
    }

    public IActionResult Index()
    {
        ProjectsDTO project = new ProjectsDTO
        {
            investigator = new(),
            Project = new(),
            Financial_Section = new(),
        };

        return View(project);
    }


    public async Task<IActionResult> CreateProject(ProjectsDTO ProjectData)
    {

        if (ModelState.IsValid)
        {
            Project project = ProjectData.Project;
            Investigator investigator = ProjectData.investigator;
            Financial_Section financial_Section = ProjectData.Financial_Section;

            var user = User.Identity.;


            BaseResponse res = await _project.CreateProject(project);
            if (res.IsSuccess == true)
            {
                await _invitgator.Create(investigator);

                Investigator Ex_Inv = new Investigator
                {
                    Academic_Rank = ProjectData.Ext_Inv_Academic_Rank,
                    Address_Of_Institiution = ProjectData.Ext_Inv_Address_Of_Institiution,
                    College_Center = ProjectData.Ext_inv_College_Center,

                };
            }
        }
        return View();
    }

    //[Authorize(Roles = "Super_Admin,Admin")]
    //public IActionResult Create()
    //{
    //    return View();
    //}

    //[Authorize(Roles = "Super_Admin,Admin")]
    //[HttpPost]
    //public async Task<IActionResult> Create(Service service)
    //{
    //    User createduser;
    //    if (User.Identity.Name != null)
    //    {
    //        createduser = await _user.GetByName(User.Identity.Name);
    //    }
    //    else
    //    {
    //        return RedirectToAction(nameof(Index));
    //    }

    //    if (ModelState.IsValid)
    //    {
    //        service.Create_At = DateTime.Now;
    //        service.Created_by = createduser.ID;
    //        BaseResponse res = await _services.Create(service);
    //        if (res.IsSuccess == true)
    //        {
    //            BasicNotification("تم اضافة البيانات بنجاح", NotificationType.Success);
    //            return RedirectToAction(nameof(Index));
    //        }
    //        else
    //        {
    //            BasicNotification(res.Message ?? "", NotificationType.Error);
    //            return RedirectToAction(nameof(Create), service);
    //        }
    //    }
    //    else
    //    {
    //        return View(service);
    //    }

    //}

    //[Authorize(Roles = "Super_Admin,Admin")]
    //public IActionResult Active(int Id)
    //{
    //    _services.Activate(Id);

    //    BasicNotification("تم تفعيل الخدمة ", NotificationType.Success);
    //    return RedirectToAction(nameof(Index));
    //}

    //[Authorize(Roles = "Super_Admin,Admin")]
    //public IActionResult DeActive(int Id)
    //{
    //    _services.DeActivate(Id);
    //    BasicNotification("تم الغاء تفعيل الخدمة ", NotificationType.Warning);
    //    return RedirectToAction(nameof(Index));
    //}

    //[Authorize(Roles = "Super_Admin,Admin")]
    //public async Task<IActionResult>  Edit(int Id) {
    //    Service service = await _services.GetById(Id);
    //    return View(service);
    //}

    //[Authorize(Roles = "Super_Admin,Admin")]
    //[HttpPost]
    //public async Task<IActionResult> Edit(Service service)
    //{
    //    User createduser;
    //    if (User.Identity.Name != null)
    //    {
    //        createduser = await _user.GetByName(User.Identity.Name);
    //    }
    //    else
    //    {
    //        return RedirectToAction(nameof(Index));
    //    }

    //    if (ModelState.IsValid)
    //    {
    //        service.Update_At = DateTime.Now;
    //        service.Updated_by = createduser.ID;
    //        BaseResponse res = await _services.Update(service);
    //        if (res.IsSuccess == true)
    //        {
    //            BasicNotification("تم اضافة البيانات بنجاح", NotificationType.Success);
    //            return RedirectToAction(nameof(Index));
    //        }
    //        else
    //        {
    //            BasicNotification(res.Message ?? "", NotificationType.Error);
    //            return RedirectToAction(nameof(Create), service);
    //        }
    //    }
    //    return View(service);
    //}

    //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    //public IActionResult Error()
    //{
    //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    //}
}