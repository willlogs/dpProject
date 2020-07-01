using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using PublicationSystem.Info;

namespace PublicationTest
{
    class UserManagerTest
    {
        [Test]
        public void UserCreationTest()
        {
            UserManager.CreateUser("mamad", "gholgholi", "male", new DateTime(1998, 5, 2));

            Assert.AreEqual(CodedPersonalInfo.infoList.Count, 1);
            Assert.AreEqual(CodedPersonalInfo.infoList[0].id, 0);
        }
    }
}
