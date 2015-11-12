using NUnit.Framework;
using System.Diagnostics;
using System.Reflection;
using Assert = NUnit.Framework.Assert;

namespace VersionInfo.Tests
{
    [TestFixture]
    public class VersionInfoTests
    {
        [Test]
        public void GetMajorVersion()
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName();

            Assert.IsTrue(assemblyName.Version.Major >= 0);
        }

        [Test]
        public void GetMinorVersion()
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName();

            Assert.IsTrue(assemblyName.Version.Minor >= 0);
           
        }

        [Test]
        public void GetPatchVersion()
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName();

            Assert.IsTrue(assemblyName.Version.Revision >= 0);
        }

        [Test]
        public void GetBuildVersion()
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName();

            Assert.IsTrue(assemblyName.Version.Build >= 0);
        }

        [Test]
        public void GetVersion()
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName();

            Assert.IsNotNull(assemblyName.Version);
        }

        [Test]
        public void GetFileVersion()
        {
            var fileVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);

            Assert.IsNotNull(fileVersion.FileVersion);
        }

        [Test]
        public void GetProductVersion()
        {
            var fileVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);

            Assert.IsNotNull(fileVersion.ProductVersion);
        }
    }
}
