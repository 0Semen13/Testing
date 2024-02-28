namespace TestingLab2.Tests
{
    [TestClass]
    public class TestingClassTests
    {
        [TestMethod]
        public void Decision_0987_13796669returned() { //1
            float x = 0.987f;
            float expected = 1.3796669f;

            TestingClass t = new TestingClass();
            float actual = t.Decision(x);

            Assert.AreEqual(expected, actual, "Test Decision_0987_13796669returned is not correct");
        }

        [TestMethod]
        public void Decision_0654_07557298returned() { //2
            float x = 0.654f;
            float expected = 0.7557298f;

            TestingClass t = new TestingClass();
            float actual = t.Decision(x);

            Assert.AreEqual(expected, actual, "Test Decision_0654_07557298returned is not correct");
        }

        [TestMethod]
        public void Decision_0321_0332256returned() { //3
            float x = 0.321f;
            float expected = 0.332256f;

            TestingClass t = new TestingClass();
            float actual = t.Decision(x);

            Assert.AreEqual(expected, actual, "Test Decision_0321_0332256returned is not correct");
        }

        [TestMethod]
        public void Decision_0999_14082773returned() { //4
            float x = 0.999f;
            float expected = 1.4082773f;

            TestingClass t = new TestingClass();
            float actual = t.Decision(x);

            Assert.AreEqual(expected, actual, "Test Decision_0999_14082773returned is not correct");
        }

        [TestMethod]
        public void Decision_0010_0010000333returned() { //5
            float x = 0.010f;
            float expected = 0.010000333f;

            TestingClass t = new TestingClass();
            float actual = t.Decision(x);

            Assert.AreEqual(expected, actual, "Test Decision_0010_0010000333returned is not correct");
        }

        [TestMethod]
        public void Decision_1001_min100returned() { //6
            float x = 1.001f;
            float expected = -100.0f;

            TestingClass t = new TestingClass();
            float actual = t.Decision(x);

            Assert.AreEqual(expected, actual, "Test Decision_1001_min100returned is not correct");
        }

        [TestMethod]
        public void Decision_min0987_min13796669returned() { //7
            float x = -0.987f;
            float expected = -1.3796669f;

            TestingClass t = new TestingClass();
            float actual = t.Decision(x);

            Assert.AreEqual(expected, actual, "Test Decision_min0987_min13796669returned is not correct");
        }

        [TestMethod]
        public void Decision_min0654_min07557298returned() { //8
            float x = -0.654f;
            float expected = -0.7557298f;

            TestingClass t = new TestingClass();
            float actual = t.Decision(x);

            Assert.AreEqual(expected, actual, "Test Decision_min0654_min07557298returned is not correct");
        }

        [TestMethod]
        public void Decision_00_00returned() { //9
            float x = 0.0f;
            float expected = 0.0f;

            TestingClass t = new TestingClass();
            float actual = t.Decision(x);

            Assert.AreEqual(expected, actual, "Test Decision_00_00returned is not correct");
        }

        [TestMethod]
        public void Decision_10_min100returned() { //10
            float x = 1.0f;
            float expected = -100.0f;

            TestingClass t = new TestingClass();
            float actual = t.Decision(x);

            Assert.AreEqual(expected, actual, "Test Decision_10_min100returned is not correct");
        }
    }
}