using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntityFrameworkProject;

    namespace TestEducationProject {
    [TestClass]
    public class UnitTest1 {

        //AppDbContext context = null;

        [TestInitialize]
        public void TestInit() {
            //context = new AppDbContext();
        }
        [TestMethod]
        public void TestStudentGetByLastName() {
            var student = Program.GetStudentByLastname("Smith");
            Assert.IsNotNull(student);
            Assert.AreEqual("Smith", student.Lastname);
            student = Program.GetStudentByLastname("Doe");
            Assert.IsNull(student);
            Assert.AreEqual("Doe", student.Lastname);
        }

        [TestMethod]
        public void TestStudentGetByPk() {
            // var janedoe = context.Students.Find(1);
            var janedoe = Program.GetStudentById(1);
            Assert.IsNotNull(janedoe);
            Assert.AreEqual("Doe", janedoe.Lastname);
            var nobody = Program.GetStudentById(999);
            Assert.IsNull(nobody);
        }
    }
}
