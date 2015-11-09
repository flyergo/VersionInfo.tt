using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using System.Diagnostics;

namespace VersionInfo.Tests
{
    [TestClass]
    public class VersionInfoTests
    {
        [TestMethod]
        public void GetMajorVersion()
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName();

            Assert.IsTrue(assemblyName.Version.Major >= 0);
        }

        [TestMethod]
        public void GetMinorVersion()
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName();

            Assert.IsTrue(assemblyName.Version.Minor >= 0);
        }

        [TestMethod]
        public void GetPatchVersion()
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName();

            Assert.IsTrue(assemblyName.Version.Revision >= 0);
        }

        [TestMethod]
        public void GetBuildVersion()
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName();

            Assert.IsTrue(assemblyName.Version.Build >= 0);
        }

        [TestMethod]
        public void GetVersion()
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName();

            Assert.IsNotNull(assemblyName.Version);
        }

        [TestMethod]
        public void GetFileVersion()
        {
            var fileVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);

            Assert.IsNotNull(fileVersion.FileVersion);
        }

        [TestMethod]
        public void GetProductVersion()
        {
            var fileVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);

            Assert.IsNotNull(fileVersion.ProductVersion);
        }
    }
}
