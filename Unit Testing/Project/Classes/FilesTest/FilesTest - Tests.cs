using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.Project {
    public sealed partial class FilesTest {
        [TestMethod]
        public void NewPath() {
            String FN = Chip.Process.Files.NewPath("C:\\temp\\example\\project.json", "C:\\temp\\example", "D:\\output");

            Assert.AreEqual(FN, "D:\\output\\project.json");
        }
    }
}
