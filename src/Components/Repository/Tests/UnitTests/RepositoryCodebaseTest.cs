using Bricks.RuntimeFramework;
using NUnit.Framework;
using Repository;

namespace White.Repository.UnitTests
{
    [TestFixture]
    public class RepositoryCodebaseTest
    {
        [Test]
        public void AllMethodsAreVirtual()
        {
            AssemblyTest.AllMethodsVirtual(typeof (ScreenRepository).Assembly);
        }
    }
}