﻿//////////////////////////////////////////////////
//Author    : Mohammed Gaffer Aidaab
//For       : King Faisual University
//Under     : ISB integrated sulution business Company
//App       : Dowali Application (())
//Date      : July - 2024
/////////////////////////////////////////////////////

using Core.Entities;
using Core.Interfaces;
using Dowali.Core.Entities;
using Dowali.Core.Interfaces;
using Dowali.UI.Dto;
using Dowali.UI.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlayApp.Extentions;
using UserServiceReference;

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

    public async Task<IActionResult> Index()
    {
        ProjectsDTO ProjectsData = new();

        if (User.IsInRole("Super_Admin") || User.IsInRole("Admin"))
        {
            ProjectsData.Projects = await _project.GetAllProjects();
            ProjectsData.ProjectInvestigators = await _invitgator.GetAllInvestgators();
            ProjectsData.Projectinancial_Section = await _financial.GetAllFinanctial();
        }

        ProjectsData.Projects = await _project.GetUserProjects(User.Identity.Name);
        //ProjectsData.ProjectInvestigators = await _invitgator.GetUserInvestgators();
        //ProjectsData.Projectinancial_Section = await _financial.GetUserFinanctial();


        return View(ProjectsData);

    }

    public async Task<IActionResult> Create()
    {
        ProjectsDTO project = new ProjectsDTO();
        try
        {
            //=================== Kfu Users Service =====================================

            UsersManagerClient ManagerClient = new UsersManagerClient();
            var users = await ManagerClient.FindUserInActiveDirectoryAsync(User.Identity.Name);

            {
                project.investigator = new()
                {
                    Name = users.FullNameAr,
                    Academic_Rank = Convert.ToInt32(users.GPA),
                    College_Center = users.ColleageName,
                    Department = users.DepartmentName,
                    Mobile_Number = Convert.ToInt32(users.Mobile),
                    Email = users.Email,
                    Office_Phone = Convert.ToInt32(users.Phone),

                };
                project.Project = new();
                project.Financial_Section = new();
            }
            return View(project);
        }
        catch (Exception Ex)
        {
            project.investigator = new();
            project.Project = new();
            project.Financial_Section = new();

            BasicNotification("لم نتمكن من الحصول على البيانات الرجاء التواصل مع تقنية المعلومات<BR><br>" + Ex.Message.ToString(), NotificationType.Warning);
            return View(project);


        }

    }

    public async Task<IActionResult> CreateProject(ProjectsDTO ProjectData)
    {
        User userdata = new();

        if (ProjectData.Project.File != null)
        {
            string ext = Path.GetExtension(ProjectData.Project.File.FileName);
            if (ext.ToLower() != ".pdf")
            {
                BasicNotification("الملفات المسموحة هي الملفات ذات الامتداد .PDF فقط ", NotificationType.Error);
                return View(nameof(Index));
            }
            else
            {
                var newfilename = await SaveFile(ProjectData.Project.File);
                ProjectData.Project.File_Path = newfilename;
            }
        }

        if (ModelState.IsValid == true)
        {
            if (User.Identity.Name != null)
            {
                userdata = await _user.GetByName(User.Identity.Name);

                ProjectData.Project.Create_At = DateTime.Now;
                ProjectData.Project.Created_by = userdata.ID;
                ProjectData.Project.satatus = null;    // project status on creation in null not checked 
                ProjectData.Project.owner = userdata.UserName;
            }
            else
            {
                BasicNotification("حدثت مشكلة الرجاء التواصل  مع مسؤول النظام", NotificationType.Error);
                return View(nameof(Index));
            }

            Project project = ProjectData.Project;
            Investigator investigator = ProjectData.investigator;
            Financial_Section financial = ProjectData.Financial_Section;

            BaseResponse res = await _project.CreateProject(project);

            if (res.IsSuccess == true)
            {
                Guid Project_ID = _project.GetProjectID(project);

                ProjectData.investigator.Project_Id = Project_ID;
                ProjectData.investigator.Inv_Type = 0;                  //Internal Investgator 

                investigator.Created_by = userdata.ID;
                investigator.Create_At = DateTime.Now;

                BaseResponse InvRes = await _invitgator.Create(investigator);

                if (InvRes.IsSuccess == true)
                {
                    Investigator Ex_Inv = new Investigator
                    {
                        Academic_Rank = ProjectData.Ext_Inv_Academic_Rank,
                        Address_Of_Institiution = ProjectData.Ext_Inv_Address_Of_Institiution,
                        College_Center = ProjectData.Ext_inv_College_Center,
                        Email = ProjectData.Ext_Inv_Email,
                        Name = ProjectData.Ex_Inv_Name,
                        Project_Id = Project_ID,
                        Inv_Type = 1,                                       //External Invetgator
                        Mobile_Number = ProjectData.Ext_Inv_Mobile_Number,
                        Office_Phone = ProjectData.Ext_Inv_Office_Phone,
                        Department = ProjectData.Ext_Inv_Department,
                        Create_At = DateTime.Now,
                        Created_by = userdata.ID,

                    };

                    BaseResponse ExInvRes = await _invitgator.Create(Ex_Inv);
                    if (ExInvRes.IsSuccess == true)
                    {
                        financial.Created_by = userdata.ID;
                        financial.Create_At = DateTime.Now;
                        financial.Project_Id = Project_ID;

                        BaseResponse FinRes = await _financial.Create(financial);
                        if (FinRes.IsSuccess == true)
                        {
                            BasicNotification("تم حفظ بيانات المشروع بنجاح", NotificationType.Success);
                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            BasicNotification("حدث خطأ في اضافة البانات المالية الرجاء التواصل مع مسؤول النظام ", NotificationType.Error);
                            return View(nameof(Create));
                        }
                    }
                    else
                    {
                        BasicNotification("حدث خطأ ف اضافة الباحث الخارجي الرجاء التواصل مع مسؤول النظام ", NotificationType.Error);
                        return View(nameof(Create));
                    }
                }
                else
                {
                    BasicNotification("توجد اشكالية في اضافة الباحثين", NotificationType.Error);
                    return View(ProjectData);

                }

            }
            else
            {
                BasicNotification("توجد مشكلة في اضافة بيانات المشروع", NotificationType.Error);
                return View(ProjectData);
            }
        }
        else
        {
            BasicNotification("الرجاء التحقق من تعبئة جميع الحقول", NotificationType.Info);
        }

        return View("Create", ProjectData);
    }

    public async Task<IActionResult> Details(Guid ProjectId)
    {
        ProjectsDTO Information = new ProjectsDTO()
        {
            Project = await _project.GetProjectByID(ProjectId),
            investigator = await _invitgator.GetInternalInvestgatorByProjectId(ProjectId),
            Financial_Section = await _financial.GetFinantialByProjectID(ProjectId),
        };
        var Ex_Inv = await _invitgator.GetExternalInvestgatorByProjectId(ProjectId);

        Information.Ext_Inv_Email = Ex_Inv.Email;
        Information.Ex_Inv_Name = Ex_Inv.Name;
        Information.Ext_Inv_Mobile_Number = Ex_Inv.Mobile_Number;
        Information.Ext_Inv_Office_Phone = Ex_Inv.Office_Phone;
        Information.Ext_Inv_Department = Ex_Inv.Department;
        Information.Ext_Inv_Academic_Rank = Ex_Inv.Academic_Rank;
        Information.Ext_Inv_Address_Of_Institiution = Ex_Inv.Address_Of_Institiution;
        Information.Ext_inv_College_Center = Ex_Inv.College_Center;


        return View(Information);
    }

    public async Task<IActionResult> ProjectConfirmation(Guid projectID)
    {
        BaseResponse res = await _project.projectConfirmation(projectID);
        if (res.IsSuccess == true)
        {
            BasicNotification("تم اعتماد المشروع", NotificationType.Success);
            return RedirectToAction(nameof(Index));
        }
        else
        {
            BasicNotification("حدثت مشكلة في اعتماد المشروع الرجاء التواصل مع مسؤول النظام ", NotificationType.Error);
            return RedirectToAction("Details", projectID);
        }
    }

    [AllowAnonymous]
    public async Task<IActionResult> ShowFile(string FileName)
    {
        var obj = new ManageFiles();
        var file = await obj.GetFileInBytes(FileName);
        return File(file, "application/pdf", "Project_Information" + ".pdf");
    }

    public async Task<string> SaveFile(IFormFile file)
    {
        try
        {
            ManageFiles obj = new ManageFiles();
            return await obj.Upload(file);
        }
        catch
        {
            return null;
        }
    }

    public async Task<string> ViewFile(string FileName)
    {
        try
        {
            ManageFiles obj = new ManageFiles();
            return await obj.View(FileName);
        }
        catch
        {
            return null;
        }
    }


}