using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CIP.API.Models;
using Microsoft.AspNetCore.Cors;
using System.Security.Principal;
using System;

namespace CIP.API.Controllers
{
    [EnableCors("SiteCorsPolicy")]
    [Route("api/Todo")]
    public class CIPController : Controller
    {
        [HttpGet("{search}", Name = "GetTodo")]
        public JsonResult GetIndvidualContactById(string id, int ssn, int phone, string first, string last)
        {
            var currentUser = User.Identity.Name;

            var item = new CIPModel();
            if (id != null)
            {
                var cipRepo = new CIPRepository();
                item = cipRepo.GetCaseInfo(item);
                item.Indicators = cipRepo.GetCaseIndicators();
                item.CaseStatus = cipRepo.GetCaseStatuses();
                item.ToDoList = cipRepo.GetToDoList();
                item.CaseActivity = cipRepo.GetCaseActivity();
                item.CaseComments = cipRepo.GetCaseComments();
                item.CaseIndividuals = cipRepo.GetActiveIndividuals();
                item.IndivDetails = cipRepo.GetIndivDetails();
                item.CaseActivityDetails = cipRepo.GetActivityDetails();
            }
            return new JsonResult(item);
        }
    }
}