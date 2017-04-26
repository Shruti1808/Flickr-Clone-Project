using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FlickrClone.Controllers;
using FlickrClone.Models;
using Xunit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace FlickrClone.Tests.ControllerTests
{
    public class ImagesControllerTest
    {
    private readonly ApplicationDbContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            ImagesController controller = new ImagesController(_userManager, _db);

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
