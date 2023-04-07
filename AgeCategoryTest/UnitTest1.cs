using PersonAgeTesting;
namespace AgeCategoryTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]

        public void ToCheck_Person_As_Children()
        {
            int age = 13;
            CategoryOfPerson person = new CategoryOfPerson(age);
            string actual = person.Category();

            string expected = "Children";

            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void ToCheck_Person_As_Youth()
        {
            int age = 22;
            CategoryOfPerson person = new CategoryOfPerson(age);
            string actual1=person.Category();
            string expected1 = "Youth";
           
            Assert.AreEqual(actual1, expected1);

        }
        public void ToCheck_Person_As_Adult()
        {
            int age = 44;
            CategoryOfPerson person = new CategoryOfPerson(age);
            string actual2 = person.Category();

            string expected2 = "Adult";

            Assert.AreEqual(actual2, expected2);
        }
        public void ToCheck_Person_As_Senior()
        {
            int age = 70;
            CategoryOfPerson person = new CategoryOfPerson(age);
            string actual3 = person.Category();

            string expected3 = "Senior";

            Assert.AreEqual(actual3, expected3);
        }

    }
}