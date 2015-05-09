using NUnit.Framework;
using System;
using Translate;

namespace UnitTestProject1
{
    [TestFixture]
    public class TranslateLibTest
    {
        const string path = "";
        TranslateManager manager = new TranslateManager(path);
        
        [Test]
        public void InitManagerTest()
        {
            var manager = new TranslateManager(path);
            Assert.AreEqual(manager.IsReady, true);
        }

        [Test]
        public void successfulTranslateTest()
        {
            var resultString = manager.GetString("elsa", "main.header", "us");
            Assert.AreEqual(resultString, "Elsa - new page");
            resultString = manager.GetString("elsa", "main.header", "cz");
            Assert.AreEqual(resultString, "Elsa - new page");            
        }

        [Test]
        public void failLanguageTranslateTest()
        {
            var resultString = manager.GetString("elsa", "main.header", "de");
            Assert.AreEqual(resultString, "Elsa - new page");
        }

        [Test]
        public void failKeyTranslateTest()
        {
            var resultString = manager.GetString("elsa", "main.headerrr", "us");
            Assert.AreEqual(resultString, "Elsa - new page");
        }
    }
}
