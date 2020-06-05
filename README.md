# ProperNameFormattingLibrary

// -------------------------------------
// Kodapor, Friday challange "ProperNameFormattingLibrary" 2020-06-05 (ISO 8601-date format)
// Issues and suggestments for improvement is appreciated. Just add yourself as contributor 
// and add the issue or mejl directly to me at uppdrag@connywesth.se
// -------------------------------------
// Challange: Create a DLL component that manages all the testcases in the unit test.
// -------------------------------------
// Prerequsites: Test framework used is MSTest 
// and the development environment beeing used is: 
// Microsoft Visual Studio 2019 version 16.6.1 Community Edition. (latest update at 2020-06-05)
// -------------------------------------
// Please use C#, VB.NET, C++ or another programming language 
// availible in the specified version of Visial Studio.
// -------------------------------------
// Create the most elegant object oriented solution.
// No "cheating" by using other peoples published 
// work as your own. It has to be your own solution and code.
// 
// The solution should format the names to proper 
// casing as specified in the test suite.
// -------------------------------------
// I found a mighty old book in my bookshelf about 
// design patterns in VB.NET and VB6 published 
// in 2002  written by James W. Cooper.
// By playing with those simple designpatterns like 
// the factory pattern in the book inspired med to 
// create this challange for other code monkeys like myself.
//
// Jag gjorde ett exempel för formattering av 
// personnamn och efter lite "lekande" med olika 
// lösningar så tänkte jag att detta kanske kunde 
// vara en lekfull och kul utmaning för andra Kodapor.
// 
// Jag tillhandahåller en påbörjad lösning, men 
// du får göra din lösning på ditt sätt, bara 
// enhetstestaerna Test 211-Test 218 + proper 
// casing går igenom felfritt.
// -------------------------------------
// Användning .NET Framework eller .NET Core är valfritt.
// -------------------------------------
// Vinnaren får respekt, ära och berömmelse!
// -------------------------------------
// Använd valfri licensmodell. Projektet är en 
// lekfull utmaning Kodapor emellan, inte kommerciellt.
// -------------------------------------
// Lösningen kan publiceras exempelvis på ditt 
// GitHub-konto och länk i tråden på Kodapor, 
// om admin tillåter det, annars kan du mejla 
// mig en länk till ditt GitHub-projektet.
// -------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProperNameFormattingLibrary;

namespace ProperNameFormattingLibrary_MSTest_UnitTestProject1
{
    [TestClass]
    public class ProperNameFormattingLibrary_UnitTest1
    {
        [DataTestMethod]
        [DataRow("Test 211:", "Sandy Amanda Georgina", "Smith-Wesson")]
        [DataRow("Test 212:", "Sven-Göran Gunnar Torsten-Helmer", "Smith-Wesson")]
        [DataRow("Test 213:", "Sven-Göran Gunnar-Torsten Helmer", "af Smith-Wesson")]
        [DataRow("Test 214:", "Sven-Göran Gunnar Torsten Helmer", "von Smith-Wesson")]
        [DataRow("Test 215:", "Sven Göran-Gunnar Torsten Helmer", "van der Smith-Wesson")]
        [DataRow("Test 216:", "Sven-Göran Gunnar Torsten Helmer", "den Smith-Wesson")]
        [DataRow("Test 217:", "Sven-Göran Gunnar Torsten Helmer", "van der Holstein-Magdeburg-Wesson-Smith")]
        [DataRow("Test 218:", "Francois Jean-Paul Gerald Torsten Helmer", "de Gaul-du Pellier")]
        public void TestProperNameFormattingMethod(string testName, string firstName, string lastName)
        {
            string originalFirstNameLastName = $"{firstName} {lastName}";
            string originalLastNameFirstName = $"{lastName}, {firstName}";

            ProperNameFormattingClass namerPrimaryLower = new NameFactory().GetProperName(originalFirstNameLastName.ToLower());
            Assert.AreEqual(expected: originalFirstNameLastName, actual: $"{namerPrimaryLower}", message:$"Primary Lower A: {testName}");
            Assert.AreEqual(expected: originalFirstNameLastName, actual: namerPrimaryLower.FirstAndLastName(), message: $"Primary Lower B: {testName}");
            Assert.AreEqual(expected: originalLastNameFirstName, actual: namerPrimaryLower.LastAndFirstName(), message: $"Primary Lower C: {testName}");

            ProperNameFormattingClass namerSecondaryLower = new NameFactory().GetProperName(originalLastNameFirstName.ToLower());
            Assert.AreEqual(expected: originalFirstNameLastName, actual: $"{namerSecondaryLower}", message: $"Secondary Lower A: {testName}");
            Assert.AreEqual(expected: originalFirstNameLastName, actual: namerSecondaryLower.FirstAndLastName(), message: $"Secondary Lower B: {testName}");
            Assert.AreEqual(expected: originalLastNameFirstName, actual: namerSecondaryLower.LastAndFirstName(), message: $"Secondary Lower C: {testName}");

            ProperNameFormattingClass namerPrimaryUpper = new NameFactory().GetProperName(originalFirstNameLastName.ToUpper());
            Assert.AreEqual(expected: originalFirstNameLastName, actual: $"{namerPrimaryUpper}", message: $"Primary Upper A: {testName}");
            Assert.AreEqual(expected: originalFirstNameLastName, actual: namerPrimaryUpper.FirstAndLastName(), message: $"Primary Upper B: {testName}");
            Assert.AreEqual(expected: originalLastNameFirstName, actual: namerPrimaryUpper.LastAndFirstName(), message: $"Primary Upper C: {testName}");

            ProperNameFormattingClass namerSecondaryUpper = new NameFactory().GetProperName(originalLastNameFirstName.ToUpper());
            Assert.AreEqual(expected: originalFirstNameLastName, actual: $"{namerSecondaryUpper}", message: $"Secondary Upper A: {testName}");
            Assert.AreEqual(expected: originalFirstNameLastName, actual: namerSecondaryUpper.FirstAndLastName(), message: $"Secondary Upper B: {testName}");
            Assert.AreEqual(expected: originalLastNameFirstName, actual: namerSecondaryUpper.LastAndFirstName(), message: $"Secondary Upper C: {testName}");

        }
    }
}

