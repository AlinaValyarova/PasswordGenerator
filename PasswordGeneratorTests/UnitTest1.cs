using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PasswordGenerator;

namespace PasswordGeneratorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGeneratePassWithoutSym1()
        {
            //Arrange
            Form1 f1 = new Form1();
            f1.numericUpDown1.Value = 6;
            int a = (int)f1.numericUpDown1.Value;
            int b = f1.GeneratePassWithoutSym(a).Length;

            //Assert and act
            Assert.AreEqual(a, b);

        }

        [TestMethod]
        public void TestGeneratePassWithSym1()
        {
            //Arrange
            Form1 f1 = new Form1();
            f1.numericUpDown1.Value = 6;
            int a = (int)f1.numericUpDown1.Value;
            int b = f1.GeneratePassWithSym(a).Length;

            //Assert and act
            Assert.AreEqual(a, b);

        }

        [TestMethod]
        public void TestEmptyLabel()
        {
            //Arrange
            Form1 f1 = new Form1();

            //Assert and act
            Assert.AreEqual("", f1.label1.Text);

        }

        [TestMethod]
        public void TestPassIsNotNull()
        {
            //Arrange
            Form1 f1 = new Form1();
            f1.label1.Text = "tco3";

            //Assert and act
            Assert.IsNotNull(f1.label1.Text);

        }

        [TestMethod]

        public void TestPassAreNotEqual()
        {
            //Arrange
            Form1 f1 = new Form1();
            string a = f1.GeneratePassWithoutSym(6);
            string b = f1.GeneratePassWithSym(6);

            //Assert and act
            Assert.AreNotEqual(a, b);

        }

        [TestMethod]

        public void TestSamePassAreNotEqual()
        {
            //Arrange
            Form1 f1 = new Form1();
            string a = f1.GeneratePassWithSym(6);
            string b = f1.GeneratePassWithSym(7);

            //Assert and act
            Assert.AreNotEqual(a, b);

        }

        [TestMethod]

        public void TestSamePassAreNotEqual2()
        {
            //Arrange
            Form1 f1 = new Form1();
            string a = f1.GeneratePassWithoutSym(6);
            string b = f1.GeneratePassWithoutSym(7);

            //Assert and act
            Assert.AreNotEqual(a, b);

        }

        [TestMethod]

        public void TestCheckBox2()
        {
            //Arrange
            Form1 f1 = new Form1();
            bool a = true;
            int b = 6;
            f1.CheckCheckBox2WithSym(a,b);

            //Assert and act
            Assert.AreEqual(f1.label1.Text.Length, b);

        }

        [TestMethod]

        public void TestCheckBox2Again()
        {
            //Arrange
            Form1 f1 = new Form1();
            bool a = false;
            int b = 8;
            f1.CheckCheckBox2WithSym(a,b);

            //Assert and act
            Assert.AreEqual(f1.label1.Text.Length, b);

        }

        [TestMethod]

        public void TestEception()
        {
            //Arrange
            Form1 f1 = new Form1();
            f1.textBox1.Text = "";

            //Assert and act
            Assert.ThrowsException<ArgumentException>(() => f1.Exception(f1.textBox1.Text));
        }

        [TestMethod]

        public void TestException()
        {
            //Arrange
            Form1 f1 = new Form1();
            f1.label1.Text = "";

            //Assert and act
            Assert.ThrowsException<ArgumentException>(() => f1.Exception(f1.label1.Text));
        }

        [TestMethod]

        public void TestLabelException()
        {
            //Arrange
            Form1 f1 = new Form1();
            f1.label1.Text = null;

            //Assert and act
            Assert.ThrowsException<ArgumentException>(() => f1.Exception(f1.label1.Text));
        }

        [TestMethod]
        public void TestTextBoxException()
        {
            //Arrange
            Form1 f1 = new Form1();
            f1.textBox1.Text = null;

            //Assert and act
            Assert.ThrowsException<ArgumentException>(() => f1.Exception(f1.textBox1.Text));
        }

        [TestMethod]

        public void CheckReplaceMiddle()
        {
            //Arrange
            Form1 f1 = new Form1();
            int i = 22;
            string[] badwords = {"Shit", "Crap","Fuck", "Damn", "Whore", "Slut", "Bitch", "Freak", "Douchebag", "Bastard", "Asshole", "Jerk", "Dick", "Cunt", "Loser", "Sucker",
                "Nerd", "Noob", "Fool", "Stupid", "Dumb", "Retard" };

            //Assert and act
            Assert.AreEqual(badwords.Length, i);
        }

        [TestMethod]

        public void TestCheckBoxWithoutSym()
        {
            //Arrange
            Form1 f1 = new Form1();
            bool a = true;
            int b = 6;
            f1.CheckCheckBox2WithoutSym(a, b);

            //Assert and act
            Assert.AreEqual(f1.label1.Text.Length, b);

        }

        [TestMethod]

        public void TestCheckBoxWithoutSym2()
        {
            //Arrange
            Form1 f1 = new Form1();
            bool a = false;
            int b = 8;
            f1.CheckCheckBox2WithoutSym(a, b);

            //Assert and act
            Assert.AreEqual(f1.label1.Text.Length, b);

        }






    }
}
