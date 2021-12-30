using System;
using System.IO;
using Chip.Project;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.Project {
    public sealed partial class ProjectLoaderTest {
        public static readonly String Root = ("C:" + Path.DirectorySeparatorChar + "temp");

        [TestMethod]
        public void Resolve() {
            String Out = ProjectLoader.Resolve(Root, "./example");

            Assert.AreEqual(Out, "C:" + Path.DirectorySeparatorChar + "temp" + Path.DirectorySeparatorChar + "example");

            Out = ProjectLoader.Resolve(Root, "../example");

            Assert.AreEqual(Out, "C:" + Path.DirectorySeparatorChar + "example");
        }
    }
}
