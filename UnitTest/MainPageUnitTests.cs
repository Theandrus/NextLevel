using BLL;
using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MainPageUnitTests
{
    [TestClass]
    public class MainPageUnitTests
    {

        [TestMethod]
        public void AddRole_ShouldAddRoleToDatabase()
        {
            string roleName = "Naruto";
            int projectId = 1;

            var userQueriesMock = new Mock<IRolePageLogic>();

            userQueriesMock.Setup(x => x.AddRole(It.IsAny<string>(), It.IsAny<int>()));

            var loginSignupLogic = new RolesPageLogic(userQueriesMock.Object);

            RolesPageLogic.AddRole(roleName, projectId);

            var roles = RolesPageLogic.GetRolesByProjectId(projectId);

            Assert.IsNotNull(roles.Find(x => x.RoleName == roleName));
        }

        [TestMethod]
        public void GetRolesByProjectId_ShouldRemoveListWithCountGT0()
        {
            string roleName = "Naruto";
            int projectId = 1;

            var rolePageLogicMock = new Mock<IRolePageLogic>();
            rolePageLogicMock.Setup(x => x.RemoveRole(It.IsAny<string>(), It.IsAny<int>()));

            var rolesPageLogic = new RolesPageLogic(rolePageLogicMock.Object);

            RolesPageLogic.AddRole(roleName, projectId);

            var roles = RolesPageLogic.GetRolesByProjectId(projectId);

            Assert.IsTrue(roles.Count > 0);
        }
    }
}