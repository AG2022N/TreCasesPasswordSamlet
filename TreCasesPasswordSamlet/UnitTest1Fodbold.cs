using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TreCasesPasswordSamlet
{
    public class UnitTest1Fodbold
    {
        [Test]
        public void HowHappyAreWeAboutThePasses_PassIsZero_Shh_Test()
        {
            var result = Case1Fodbold.AfleveringTjek(0);
            Assert.AreEqual("Shh", result);
        }
        [Test]
        public void HowHappyAreWeAboutThePasses_PassIstree_HuhHuhHuh_Test()
        {
            var result = Case1Fodbold.AfleveringTjek(3);
            Assert.AreEqual("Huh! Huh! Huh!", result);
        }
        [Test]
        public void HowHappyAreWeAboutThePasses_PassesIsTin_HighFiveJubel_Test()
        {
            var result = Case1Fodbold.AfleveringTjek(10);
            Assert.AreEqual("High Five – Jubel!!!", result);
        }
        [Test]
        public void WeCheerIfGoal_GoalIsMåL_OleOleOle_Test()
        {
            var result = Case1Fodbold.Mål("MåL");
            Assert.AreEqual("Olé olé olé", result);
        }
        //[Test]
        //public void WeCheerGoalOrPasses_GoalIsmÅl_OleOleOle_Test()
        //{
        //    var result = _football.WeCheerGoalOrPasses("mÅl", 4);
        //    Assert.AreEqual("Olé olé olé", result);
        //}
    }
}