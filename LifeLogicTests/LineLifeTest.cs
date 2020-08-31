using LifeLogic;
using NUnit.Framework;

namespace LifeLogicTests {
    public class Tests {
        LineLifeLogic simpleLogic;
        LineLifeLogic basicLogic;

        [SetUp]
        public void Setup () {
            simpleLogic = new LineLifeLogic (6);
            basicLogic = new LineLifeLogic (new bool[] { true, false, true, true, false });

        }

        [Test]
        public void LineLifeLogicSimpleCreation () {
            Assert.That (simpleLogic.Size, Is.EqualTo (6));
            Assert.That (simpleLogic.Arr, Is.Not.Empty);
            Assert.That (simpleLogic.Arr.Length, Is.EqualTo (6));
            Assert.That (simpleLogic.Rule, Is.Not.Empty);
            Assert.That (simpleLogic.Rule.Length, Is.EqualTo (8));
        }

        [Test]
        public void LineLifeLogicBasicCreation () {
            Assert.That (basicLogic.Size, Is.EqualTo (5));
            Assert.That (basicLogic.Arr, Is.Not.All.EqualTo (false));
            Assert.That (basicLogic.Rule, Is.All.EqualTo (false));
        }

        [Test]
        public void LineLifeLogicRandomLogic () {
            simpleLogic.SetRandom ();
            Assert.That (simpleLogic.Size, Is.EqualTo (6));
            Assert.That (simpleLogic.Arr, Is.Not.All.EqualTo (false));
        }

        [Test]
        public void LineLifeLogicMiddleOneLogic () {
            simpleLogic.SetMiddleOne ();
            Assert.That (simpleLogic.Arr, Has.Exactly (1).EqualTo (true));
            Assert.That (simpleLogic.Arr[simpleLogic.Size / 2], Is.EqualTo (true));
        }

        [Test]
        public void LineLifeLogicToString () {
            simpleLogic.SetMiddleOne ();
            Assert.That (simpleLogic.ToString (), Is.EqualTo ("...#.."));
            Assert.That (basicLogic.ToString (), Is.EqualTo ("#.##."));
        }
    }
}