using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThAmCo;
using ThAmCo.Controllers;
using Microsoft.AspNet.Identity;
//using Microsoft.AspNet.Identity.Owin;
using ThAmCo.Models;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


using ThAmCo.Models;

namespace ThAmCo.Tests.Controllers
{
    [TestClass]
    public class AdminControllerTest
    {
        private ApplicationUserManager _userManager;
        private ApplicationRoleManager _roleManager;

        [TestMethod]
        public void Test2()
        {
            // Arrange
            AdminController controller = new AdminController();
            string UserName = "Fred@fred.com";
            ApplicationUser user = _userManager.FindByName(UserName);
            List<UserRoleDTO> colUserRoleDTO =
                (from objRole in _userManager.GetRoles(user.Id)
                 select new UserRoleDTO
                 {
                     RoleName = objRole,
                     UserName = UserName
                 }).ToList();
            UserAndRolesDTO objUserAndRolesDTO =
                new UserAndRolesDTO();
            objUserAndRolesDTO.UserName = UserName;
            //objUserAndRolesDTO.colUserRoleDTO = colUserRoleDTO;
            Assert.IsNotNull(objUserAndRolesDTO.UserName);

            //var objExpandedUserDTO = controller.GetUserAndRoles(UserName); OLD
            //var result = objExpandedUserDTO.colUserRoleDTO;



            //// Act
            ////ContentResult operation = controller.UserManager.RemoveFromRoles(UserName, "Sales");

            ////var objExpandedUserDTO = controller.GetUserAndRoles(UserName);
            //var result = objExpandedUserDTO.colUserRoleDTO.Find(r => r.RoleName == "Sales");
            // Assert
            //Assert.AreEqual("Your application description page.", result.ViewBag.Message);


        }




    }
}