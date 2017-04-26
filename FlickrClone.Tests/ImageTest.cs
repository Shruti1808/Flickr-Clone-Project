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

            //Act
            var result = image.Description;

            //Assert
            Assert.Equal("Wash the dog", result);
        }
    }
}
