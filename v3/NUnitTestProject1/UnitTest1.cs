using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {   //  arrange
            string path= "C:\\Users\\Ent\\Desktop\\bum24-fullexport.csv";
            ClassLibrary1.Parse.razdel = ';';

            //  act
            ClassLibrary1.Transorm.TransormToTwoList(path);

            //  assert
            Assert.Pass();
        }
        [Test]
        public void Test2()
        {   //  arrange
            string path = "C:\\Users\\Ent\\Desktop\\bum24-fullexport Ч копи€.txt";
            ClassLibrary1.Parse.razdel = '/';

            //  act
            ClassLibrary1.Transorm.TransormToTwoList(path);

            //  assert
            Assert.Pass();
        }
        [Test]
        public void Test3()
        {   //  arrange
            string path = "C:\\Users\\Ent\\Desktop\\bum24-fullexport Ч копи€.txt";
            ClassLibrary1.Parse.razdel = '/';

            //  act
            List<List<object>> list = ClassLibrary1.Transorm.TransormToTwoList(true, path);

            //  assert
            Assert.AreEqual(Convert.ToInt32(list[0][0]) < Convert.ToInt32(list[1][0]), true);
        }
        [Test]
        public void Test4()
        {   //  arrange
            string path = "C:\\Users\\Ent\\Desktop\\bum24-fullexport Ч копи€.txt";
            ClassLibrary1.Parse.razdel = '/';

            //  act
            List<List<object>> list = ClassLibrary1.Transorm.TransormToTwoList(false, path);

            //  assert
            Assert.AreEqual(Convert.ToInt32(list[0][0])>Convert.ToInt32(list[1][0]),true);
        }
        [Test]
        public void Test5()
        {   //  arrange
            string line = "1;2;3;3;5;6;7;8";
            ClassLibrary1.Parse.razdel = ';';

            //  act
            List<object> list = new List<object>(line.Split(';'));

            //  assert
            Assert.AreEqual(list, ClassLibrary1.Parse.ParseString(line));
        }
        
    }
}