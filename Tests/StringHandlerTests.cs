using CommonFunctionalityLibrary;
using NUnit.Framework;

namespace CommonFunctionalityLibrary_Tests
{
    public class StringHandlerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StringHandlerValidOutput()
        {
            string source = "SonicScrewDriver";
            string expected = "Sonic Screw Driver";

            
            string actual = StringHandler.InsertSpacesInProductNames(source);

            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void StringHandleTestWithExistingSpaces()
        {
            string source = "Sonic Screw Driver";
            string expected = "Sonic Screw Driver";

          
            string actual = StringHandler.InsertSpacesInProductNames(source);

            Assert.AreEqual(expected, actual);
        }
        //TODO 1. All Uppercase 2. All Lowercase 3. nullOREmpty string...
    }
}