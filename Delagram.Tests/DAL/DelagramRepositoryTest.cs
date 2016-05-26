using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Delagram.DAL;

namespace Delagram.Tests.DAL
{
    [TestClass]
    public class DelagramRepositoryTest
    {
        [TestMethod]
        public void RepoEnsureICanCreateAnInstance()
        {
            DelagramRepository repo = new DelagramRepository();
            Assert.IsNotNull(repo);
        }
    }
}
