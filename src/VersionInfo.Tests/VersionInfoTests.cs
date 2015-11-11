using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System.Diagnostics;
using System.Reflection;
using Assert = NUnit.Framework.Assert;

namespace VersionInfo.Tests
{
    [TestFixture]
    [TestClass]
    public class VersionInfoTests
    {
        [Test]
        [TestMethod]
        public void GetMajorVersion()
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName();

            Assert.IsTrue(assemblyName.Version.Major >= 0);
        }

        [Test]
        [TestMethod]
        public void GetMinorVersion()
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName();

            Assert.IsTrue(assemblyName.Version.Minor >= 0);
           
        }

        [Test]
        [TestMethod]
        public void GetPatchVersion()
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName();

            Assert.IsTrue(assemblyName.Version.Revision >= 0);
        }

        [Test]
        [TestMethod]
        public void GetBuildVersion()
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName();

            Assert.IsTrue(assemblyName.Version.Build >= 0);
        }

        [Test]
        [TestMethod]
        public void GetVersion()
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName();

            Assert.IsNotNull(assemblyName.Version);
        }

        [Test]
        [TestMethod]
        public void GetFileVersion()
        {
            var fileVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);

            Assert.IsNotNull(fileVersion.FileVersion);
        }

        [Test]
        [TestMethod]
        public void GetProductVersion()
        {
            var fileVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);

            Assert.IsNotNull(fileVersion.ProductVersion);
        }
    }
}
