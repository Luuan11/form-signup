using BackEnd.Pages.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace UserRegistration.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationUser _auc;

        public UserController(ApplicationUser auc)
        {
            _auc = auc;
        }

        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
            User uc = new();
            return View(uc);
        }

        [HttpPost]
        public ActionResult AddOrEdit(User userModel)
        {
            _auc.Add(userModel);
            _auc.SaveChanges();

            ViewBag.SuccessMessage = "Registro feito com sucesso!";

            return View("AddOrEdit", new User());
        }

        protected void InsertUser()
        {
            try
            {
                string proc = "PROC_UserRegistration";

                using (SqlConnection cnn = new())
                {
                    cnn.Open();
                    
                }
            }
            catch(SqlException e)
            {

            }
        }
    }
}