using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlickrClone.Models;
using Xunit;

namespace FlickrClone.Tests
{
    public class ImageTest
     {
        [Fact]
        public void GetDescriptionTest()
        {
            //Arrange
            var image = new Image();
            image.Description = "This is a sunset";

            //Act
            var result = image.Description;

            //Assert
            Assert.Equal("This is a sunset", result);
        }
    }
}
