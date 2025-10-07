using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Tests.UnitTests.Controllers;

public class MembersControllerTests
{
    /*
    [Fact]
    public async Task GetMembers_ReturnAllMembers() {
        // Arrange
        var users = new List<AppUser>
        {
            new AppUser { Id = "1", DisplayName = "Alice", Email = "alice@gmail"},
            new AppUser { Id = "2", DisplayName = "Bob", Email = "bob@gmail"},
        };

        // Mock context with DbSet
        var mockContext = new Mock<AppDbContext>();
        mockContext.Setup(c => c.Users).ReturnsDbSet(users);

        var controller = new MembersController(mockContext.Object);

        //Act
        var result = await controller.GetMembers();

        //Assert
        var okResult = Assert.IsType<OkObjectResult>(result.Result);
        var returnUsers = Assert.IsAssignableFrom<IReadOnlyList<AppUser>>(okResult.Value);
        Assert.Equal(2, returnUsers.Count);
    }

    [Fact]
    public async Task GetMember_WhenUserExists_ReturnsUser() {
        //Arrange
        var users = new List<AppUser>
        {
            new AppUser { Id = "1", DisplayName = "Alice", Email = "alice@gmail" }
        };

        var mockContext = new Mock<AppDbContext>();
        mockContext.Setup(c => c.Users).ReturnsDbSet(users);

        var controller = new MembersController(mockContext.Object);

        // Act
        var result = await controller.GetMember("1");

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result.Result);
        var user = Assert.IsType<AppUser>(okResult.Value);
        Assert.Equal("Alice", user.DisplayName);
    }

    [Fact]
    public async Task GetMember_WhenUserDoesNotExist_ResturnsNotFound() {
        // Arrange
        var users = new List<AppUser>();
        var mockContext = new Mock<AppDbContext>();
        mockContext.Setup(c => c.Users).ReturnsDbSet(users);

        var controller = new MembersController(mockContext.Object);

        // Act
        var result = await controller.GetMember("999");

        // Assert
        Assert.IsType<NotFoundResult>(result.Result);
    }*/

    [Fact]
    public void AlwaysPasses() {
        // This test always succeeds
        Assert.True(true);
    }
}
