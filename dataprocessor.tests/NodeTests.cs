
using System;
using System.Linq;
using NUnit.Framework;
using dataprocessor;

namespace dataprocessor.tests
{
    public class NodeTests
    {
        [Test]
        public void GetTypeFor_Throws()
        {
            Assert.Throws<ArgumentNullException>(() => Node.GetTypeFor(null));
            Assert.Throws<ArgumentNullException>(() => Node.GetActionTypeFor(null));
            Assert.Throws<ArgumentNullException>(() => Node.GetNodeFor(null));

            Assert.Throws<ArgumentException>(() => Node.GetTypeFor(new Type[0]));
            Assert.Throws<ArgumentException>(() => Node.GetActionTypeFor(new Type[0]));
            Assert.Throws<ArgumentException>(() => Node.GetNodeFor(new Type[0]));

            Assert.Throws<ArgumentException>(() => Node.GetTypeFor(new[] { typeof(int) }));
            Assert.Throws<ArgumentException>(() => Node.GetActionTypeFor(new[] { typeof(int) }));
            Assert.Throws<ArgumentException>(() => Node.GetNodeFor(new[] { typeof(int) }));

            Assert.Throws<ArgumentException>(() => Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.Throws<ArgumentException>(() => Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.Throws<ArgumentException>(() => Node.GetNodeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void GetTypeFor2()
        {
            Assert.AreEqual(
                typeof(Node<int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows2()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int>(null));
            var n = new Node<int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues2()
        {
            var result = 0;
            Node<int, int>.Action action = (p1, p2) => result = p1 + p2;

            var n = new Node<int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);

            Assert.AreEqual(3, result);

            n.Set1(100);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void SetValues_Reversed2()
        {
            var result = 0;
            Node<int, int>.Action action = (p1, p2) => result = p1 + p2;

            var n = new Node<int, int>(action);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(3, result);

            n.Set2(100);
            Assert.AreEqual(3, result);
        }


        [Test]
        public void GetTypeFor3()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows3()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int>(null));
            var n = new Node<int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues3()
        {
            var result = 0;
            Node<int, int, int>.Action action = (p1, p2, p3) => result = p1 + p2 + p3;

            var n = new Node<int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);

            Assert.AreEqual(6, result);

            n.Set1(100);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void SetValues_Reversed3()
        {
            var result = 0;
            Node<int, int, int>.Action action = (p1, p2, p3) => result = p1 + p2 + p3;

            var n = new Node<int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(6, result);

            n.Set3(100);
            Assert.AreEqual(6, result);
        }


        [Test]
        public void GetTypeFor4()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows4()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int>(null));
            var n = new Node<int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues4()
        {
            var result = 0;
            Node<int, int, int, int>.Action action = (p1, p2, p3, p4) => result = p1 + p2 + p3 + p4;

            var n = new Node<int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);

            Assert.AreEqual(10, result);

            n.Set1(100);
            Assert.AreEqual(10, result);
        }

        [Test]
        public void SetValues_Reversed4()
        {
            var result = 0;
            Node<int, int, int, int>.Action action = (p1, p2, p3, p4) => result = p1 + p2 + p3 + p4;

            var n = new Node<int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(10, result);

            n.Set4(100);
            Assert.AreEqual(10, result);
        }


        [Test]
        public void GetTypeFor5()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows5()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues5()
        {
            var result = 0;
            Node<int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5) => result = p1 + p2 + p3 + p4 + p5;

            var n = new Node<int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);

            Assert.AreEqual(15, result);

            n.Set1(100);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void SetValues_Reversed5()
        {
            var result = 0;
            Node<int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5) => result = p1 + p2 + p3 + p4 + p5;

            var n = new Node<int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(15, result);

            n.Set5(100);
            Assert.AreEqual(15, result);
        }


        [Test]
        public void GetTypeFor6()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows6()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues6()
        {
            var result = 0;
            Node<int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6) => result = p1 + p2 + p3 + p4 + p5 + p6;

            var n = new Node<int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);

            Assert.AreEqual(21, result);

            n.Set1(100);
            Assert.AreEqual(21, result);
        }

        [Test]
        public void SetValues_Reversed6()
        {
            var result = 0;
            Node<int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6) => result = p1 + p2 + p3 + p4 + p5 + p6;

            var n = new Node<int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(21, result);

            n.Set6(100);
            Assert.AreEqual(21, result);
        }


        [Test]
        public void GetTypeFor7()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows7()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues7()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7;

            var n = new Node<int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);

            Assert.AreEqual(28, result);

            n.Set1(100);
            Assert.AreEqual(28, result);
        }

        [Test]
        public void SetValues_Reversed7()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7;

            var n = new Node<int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(28, result);

            n.Set7(100);
            Assert.AreEqual(28, result);
        }


        [Test]
        public void GetTypeFor8()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows8()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues8()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8;

            var n = new Node<int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);

            Assert.AreEqual(36, result);

            n.Set1(100);
            Assert.AreEqual(36, result);
        }

        [Test]
        public void SetValues_Reversed8()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8;

            var n = new Node<int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(36, result);

            n.Set8(100);
            Assert.AreEqual(36, result);
        }


        [Test]
        public void GetTypeFor9()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows9()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues9()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9;

            var n = new Node<int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);

            Assert.AreEqual(45, result);

            n.Set1(100);
            Assert.AreEqual(45, result);
        }

        [Test]
        public void SetValues_Reversed9()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9;

            var n = new Node<int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(45, result);

            n.Set9(100);
            Assert.AreEqual(45, result);
        }


        [Test]
        public void GetTypeFor10()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows10()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues10()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10;

            var n = new Node<int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);

            Assert.AreEqual(55, result);

            n.Set1(100);
            Assert.AreEqual(55, result);
        }

        [Test]
        public void SetValues_Reversed10()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10;

            var n = new Node<int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(55, result);

            n.Set10(100);
            Assert.AreEqual(55, result);
        }


        [Test]
        public void GetTypeFor11()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows11()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues11()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);

            Assert.AreEqual(66, result);

            n.Set1(100);
            Assert.AreEqual(66, result);
        }

        [Test]
        public void SetValues_Reversed11()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(66, result);

            n.Set11(100);
            Assert.AreEqual(66, result);
        }


        [Test]
        public void GetTypeFor12()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows12()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues12()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);

            Assert.AreEqual(78, result);

            n.Set1(100);
            Assert.AreEqual(78, result);
        }

        [Test]
        public void SetValues_Reversed12()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(78, result);

            n.Set12(100);
            Assert.AreEqual(78, result);
        }


        [Test]
        public void GetTypeFor13()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows13()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues13()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);

            Assert.AreEqual(91, result);

            n.Set1(100);
            Assert.AreEqual(91, result);
        }

        [Test]
        public void SetValues_Reversed13()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(91, result);

            n.Set13(100);
            Assert.AreEqual(91, result);
        }


        [Test]
        public void GetTypeFor14()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows14()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues14()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);

            Assert.AreEqual(105, result);

            n.Set1(100);
            Assert.AreEqual(105, result);
        }

        [Test]
        public void SetValues_Reversed14()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(105, result);

            n.Set14(100);
            Assert.AreEqual(105, result);
        }


        [Test]
        public void GetTypeFor15()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows15()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues15()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);

            Assert.AreEqual(120, result);

            n.Set1(100);
            Assert.AreEqual(120, result);
        }

        [Test]
        public void SetValues_Reversed15()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(120, result);

            n.Set15(100);
            Assert.AreEqual(120, result);
        }


        [Test]
        public void GetTypeFor16()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows16()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues16()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);

            Assert.AreEqual(136, result);

            n.Set1(100);
            Assert.AreEqual(136, result);
        }

        [Test]
        public void SetValues_Reversed16()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(136, result);

            n.Set16(100);
            Assert.AreEqual(136, result);
        }


        [Test]
        public void GetTypeFor17()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows17()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues17()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);

            Assert.AreEqual(153, result);

            n.Set1(100);
            Assert.AreEqual(153, result);
        }

        [Test]
        public void SetValues_Reversed17()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(153, result);

            n.Set17(100);
            Assert.AreEqual(153, result);
        }


        [Test]
        public void GetTypeFor18()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows18()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues18()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);

            Assert.AreEqual(171, result);

            n.Set1(100);
            Assert.AreEqual(171, result);
        }

        [Test]
        public void SetValues_Reversed18()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(171, result);

            n.Set18(100);
            Assert.AreEqual(171, result);
        }


        [Test]
        public void GetTypeFor19()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows19()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues19()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);

            Assert.AreEqual(190, result);

            n.Set1(100);
            Assert.AreEqual(190, result);
        }

        [Test]
        public void SetValues_Reversed19()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(190, result);

            n.Set19(100);
            Assert.AreEqual(190, result);
        }


        [Test]
        public void GetTypeFor20()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows20()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues20()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);

            Assert.AreEqual(210, result);

            n.Set1(100);
            Assert.AreEqual(210, result);
        }

        [Test]
        public void SetValues_Reversed20()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(210, result);

            n.Set20(100);
            Assert.AreEqual(210, result);
        }


        [Test]
        public void GetTypeFor21()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows21()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues21()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);

            Assert.AreEqual(231, result);

            n.Set1(100);
            Assert.AreEqual(231, result);
        }

        [Test]
        public void SetValues_Reversed21()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(231, result);

            n.Set21(100);
            Assert.AreEqual(231, result);
        }


        [Test]
        public void GetTypeFor22()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows22()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues22()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);

            Assert.AreEqual(253, result);

            n.Set1(100);
            Assert.AreEqual(253, result);
        }

        [Test]
        public void SetValues_Reversed22()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(253, result);

            n.Set22(100);
            Assert.AreEqual(253, result);
        }


        [Test]
        public void GetTypeFor23()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows23()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues23()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);

            Assert.AreEqual(276, result);

            n.Set1(100);
            Assert.AreEqual(276, result);
        }

        [Test]
        public void SetValues_Reversed23()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(276, result);

            n.Set23(100);
            Assert.AreEqual(276, result);
        }


        [Test]
        public void GetTypeFor24()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows24()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues24()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);

            Assert.AreEqual(300, result);

            n.Set1(100);
            Assert.AreEqual(300, result);
        }

        [Test]
        public void SetValues_Reversed24()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(300, result);

            n.Set24(100);
            Assert.AreEqual(300, result);
        }


        [Test]
        public void GetTypeFor25()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows25()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues25()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);

            Assert.AreEqual(325, result);

            n.Set1(100);
            Assert.AreEqual(325, result);
        }

        [Test]
        public void SetValues_Reversed25()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(325, result);

            n.Set25(100);
            Assert.AreEqual(325, result);
        }


        [Test]
        public void GetTypeFor26()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows26()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues26()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);

            Assert.AreEqual(351, result);

            n.Set1(100);
            Assert.AreEqual(351, result);
        }

        [Test]
        public void SetValues_Reversed26()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(351, result);

            n.Set26(100);
            Assert.AreEqual(351, result);
        }


        [Test]
        public void GetTypeFor27()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows27()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues27()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);

            Assert.AreEqual(378, result);

            n.Set1(100);
            Assert.AreEqual(378, result);
        }

        [Test]
        public void SetValues_Reversed27()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(378, result);

            n.Set27(100);
            Assert.AreEqual(378, result);
        }


        [Test]
        public void GetTypeFor28()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows28()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues28()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);

            Assert.AreEqual(406, result);

            n.Set1(100);
            Assert.AreEqual(406, result);
        }

        [Test]
        public void SetValues_Reversed28()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(406, result);

            n.Set28(100);
            Assert.AreEqual(406, result);
        }


        [Test]
        public void GetTypeFor29()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows29()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues29()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);

            Assert.AreEqual(435, result);

            n.Set1(100);
            Assert.AreEqual(435, result);
        }

        [Test]
        public void SetValues_Reversed29()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(435, result);

            n.Set29(100);
            Assert.AreEqual(435, result);
        }


        [Test]
        public void GetTypeFor30()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows30()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues30()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);

            Assert.AreEqual(465, result);

            n.Set1(100);
            Assert.AreEqual(465, result);
        }

        [Test]
        public void SetValues_Reversed30()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(465, result);

            n.Set30(100);
            Assert.AreEqual(465, result);
        }


        [Test]
        public void GetTypeFor31()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows31()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues31()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);

            Assert.AreEqual(496, result);

            n.Set1(100);
            Assert.AreEqual(496, result);
        }

        [Test]
        public void SetValues_Reversed31()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(496, result);

            n.Set31(100);
            Assert.AreEqual(496, result);
        }


        [Test]
        public void GetTypeFor32()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows32()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues32()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);

            Assert.AreEqual(528, result);

            n.Set1(100);
            Assert.AreEqual(528, result);
        }

        [Test]
        public void SetValues_Reversed32()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(528, result);

            n.Set32(100);
            Assert.AreEqual(528, result);
        }


        [Test]
        public void GetTypeFor33()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows33()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues33()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);

            Assert.AreEqual(561, result);

            n.Set1(100);
            Assert.AreEqual(561, result);
        }

        [Test]
        public void SetValues_Reversed33()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(561, result);

            n.Set33(100);
            Assert.AreEqual(561, result);
        }


        [Test]
        public void GetTypeFor34()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows34()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues34()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);

            Assert.AreEqual(595, result);

            n.Set1(100);
            Assert.AreEqual(595, result);
        }

        [Test]
        public void SetValues_Reversed34()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(595, result);

            n.Set34(100);
            Assert.AreEqual(595, result);
        }


        [Test]
        public void GetTypeFor35()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows35()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues35()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);

            Assert.AreEqual(630, result);

            n.Set1(100);
            Assert.AreEqual(630, result);
        }

        [Test]
        public void SetValues_Reversed35()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(630, result);

            n.Set35(100);
            Assert.AreEqual(630, result);
        }


        [Test]
        public void GetTypeFor36()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows36()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues36()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);

            Assert.AreEqual(666, result);

            n.Set1(100);
            Assert.AreEqual(666, result);
        }

        [Test]
        public void SetValues_Reversed36()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(666, result);

            n.Set36(100);
            Assert.AreEqual(666, result);
        }


        [Test]
        public void GetTypeFor37()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows37()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues37()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);

            Assert.AreEqual(703, result);

            n.Set1(100);
            Assert.AreEqual(703, result);
        }

        [Test]
        public void SetValues_Reversed37()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(703, result);

            n.Set37(100);
            Assert.AreEqual(703, result);
        }


        [Test]
        public void GetTypeFor38()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows38()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues38()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set38(38);

            Assert.AreEqual(741, result);

            n.Set1(100);
            Assert.AreEqual(741, result);
        }

        [Test]
        public void SetValues_Reversed38()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(741, result);

            n.Set38(100);
            Assert.AreEqual(741, result);
        }


        [Test]
        public void GetTypeFor39()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows39()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues39()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set39(39);

            Assert.AreEqual(780, result);

            n.Set1(100);
            Assert.AreEqual(780, result);
        }

        [Test]
        public void SetValues_Reversed39()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(780, result);

            n.Set39(100);
            Assert.AreEqual(780, result);
        }


        [Test]
        public void GetTypeFor40()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows40()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues40()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set40(40);

            Assert.AreEqual(820, result);

            n.Set1(100);
            Assert.AreEqual(820, result);
        }

        [Test]
        public void SetValues_Reversed40()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(820, result);

            n.Set40(100);
            Assert.AreEqual(820, result);
        }


        [Test]
        public void GetTypeFor41()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows41()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues41()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set41(41);

            Assert.AreEqual(861, result);

            n.Set1(100);
            Assert.AreEqual(861, result);
        }

        [Test]
        public void SetValues_Reversed41()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(861, result);

            n.Set41(100);
            Assert.AreEqual(861, result);
        }


        [Test]
        public void GetTypeFor42()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows42()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues42()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set42(42);

            Assert.AreEqual(903, result);

            n.Set1(100);
            Assert.AreEqual(903, result);
        }

        [Test]
        public void SetValues_Reversed42()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(903, result);

            n.Set42(100);
            Assert.AreEqual(903, result);
        }


        [Test]
        public void GetTypeFor43()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows43()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues43()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set43(43);

            Assert.AreEqual(946, result);

            n.Set1(100);
            Assert.AreEqual(946, result);
        }

        [Test]
        public void SetValues_Reversed43()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(946, result);

            n.Set43(100);
            Assert.AreEqual(946, result);
        }


        [Test]
        public void GetTypeFor44()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows44()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues44()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set44(44);

            Assert.AreEqual(990, result);

            n.Set1(100);
            Assert.AreEqual(990, result);
        }

        [Test]
        public void SetValues_Reversed44()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(990, result);

            n.Set44(100);
            Assert.AreEqual(990, result);
        }


        [Test]
        public void GetTypeFor45()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows45()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues45()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set45(45);

            Assert.AreEqual(1035, result);

            n.Set1(100);
            Assert.AreEqual(1035, result);
        }

        [Test]
        public void SetValues_Reversed45()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(1035, result);

            n.Set45(100);
            Assert.AreEqual(1035, result);
        }


        [Test]
        public void GetTypeFor46()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows46()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues46()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set46(46);

            Assert.AreEqual(1081, result);

            n.Set1(100);
            Assert.AreEqual(1081, result);
        }

        [Test]
        public void SetValues_Reversed46()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(1081, result);

            n.Set46(100);
            Assert.AreEqual(1081, result);
        }


        [Test]
        public void GetTypeFor47()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows47()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues47()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set47(47);

            Assert.AreEqual(1128, result);

            n.Set1(100);
            Assert.AreEqual(1128, result);
        }

        [Test]
        public void SetValues_Reversed47()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(1128, result);

            n.Set47(100);
            Assert.AreEqual(1128, result);
        }


        [Test]
        public void GetTypeFor48()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows48()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues48()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set48(48);

            Assert.AreEqual(1176, result);

            n.Set1(100);
            Assert.AreEqual(1176, result);
        }

        [Test]
        public void SetValues_Reversed48()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(1176, result);

            n.Set48(100);
            Assert.AreEqual(1176, result);
        }


        [Test]
        public void GetTypeFor49()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows49()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues49()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set49(49);

            Assert.AreEqual(1225, result);

            n.Set1(100);
            Assert.AreEqual(1225, result);
        }

        [Test]
        public void SetValues_Reversed49()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(1225, result);

            n.Set49(100);
            Assert.AreEqual(1225, result);
        }


        [Test]
        public void GetTypeFor50()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows50()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues50()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set50(50);

            Assert.AreEqual(1275, result);

            n.Set1(100);
            Assert.AreEqual(1275, result);
        }

        [Test]
        public void SetValues_Reversed50()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(1275, result);

            n.Set50(100);
            Assert.AreEqual(1275, result);
        }


        [Test]
        public void GetTypeFor51()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows51()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues51()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set51(51);

            Assert.AreEqual(1326, result);

            n.Set1(100);
            Assert.AreEqual(1326, result);
        }

        [Test]
        public void SetValues_Reversed51()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set51(51);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(1326, result);

            n.Set51(100);
            Assert.AreEqual(1326, result);
        }


        [Test]
        public void GetTypeFor52()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows52()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues52()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51, p52) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51 + p52;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set51(51);
            Assert.AreEqual(0, result);
            n.Set52(52);

            Assert.AreEqual(1378, result);

            n.Set1(100);
            Assert.AreEqual(1378, result);
        }

        [Test]
        public void SetValues_Reversed52()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51, p52) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51 + p52;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set52(52);
            Assert.AreEqual(0, result);
            n.Set51(51);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(1378, result);

            n.Set52(100);
            Assert.AreEqual(1378, result);
        }


        [Test]
        public void GetTypeFor53()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows53()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues53()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51, p52, p53) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51 + p52 + p53;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set51(51);
            Assert.AreEqual(0, result);
            n.Set52(52);
            Assert.AreEqual(0, result);
            n.Set53(53);

            Assert.AreEqual(1431, result);

            n.Set1(100);
            Assert.AreEqual(1431, result);
        }

        [Test]
        public void SetValues_Reversed53()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51, p52, p53) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51 + p52 + p53;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set53(53);
            Assert.AreEqual(0, result);
            n.Set52(52);
            Assert.AreEqual(0, result);
            n.Set51(51);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(1431, result);

            n.Set53(100);
            Assert.AreEqual(1431, result);
        }


        [Test]
        public void GetTypeFor54()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows54()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues54()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51, p52, p53, p54) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51 + p52 + p53 + p54;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set51(51);
            Assert.AreEqual(0, result);
            n.Set52(52);
            Assert.AreEqual(0, result);
            n.Set53(53);
            Assert.AreEqual(0, result);
            n.Set54(54);

            Assert.AreEqual(1485, result);

            n.Set1(100);
            Assert.AreEqual(1485, result);
        }

        [Test]
        public void SetValues_Reversed54()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51, p52, p53, p54) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51 + p52 + p53 + p54;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set54(54);
            Assert.AreEqual(0, result);
            n.Set53(53);
            Assert.AreEqual(0, result);
            n.Set52(52);
            Assert.AreEqual(0, result);
            n.Set51(51);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(1485, result);

            n.Set54(100);
            Assert.AreEqual(1485, result);
        }


        [Test]
        public void GetTypeFor55()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows55()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues55()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51, p52, p53, p54, p55) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51 + p52 + p53 + p54 + p55;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set51(51);
            Assert.AreEqual(0, result);
            n.Set52(52);
            Assert.AreEqual(0, result);
            n.Set53(53);
            Assert.AreEqual(0, result);
            n.Set54(54);
            Assert.AreEqual(0, result);
            n.Set55(55);

            Assert.AreEqual(1540, result);

            n.Set1(100);
            Assert.AreEqual(1540, result);
        }

        [Test]
        public void SetValues_Reversed55()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51, p52, p53, p54, p55) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51 + p52 + p53 + p54 + p55;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set55(55);
            Assert.AreEqual(0, result);
            n.Set54(54);
            Assert.AreEqual(0, result);
            n.Set53(53);
            Assert.AreEqual(0, result);
            n.Set52(52);
            Assert.AreEqual(0, result);
            n.Set51(51);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(1540, result);

            n.Set55(100);
            Assert.AreEqual(1540, result);
        }


        [Test]
        public void GetTypeFor56()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows56()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues56()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51, p52, p53, p54, p55, p56) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51 + p52 + p53 + p54 + p55 + p56;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set51(51);
            Assert.AreEqual(0, result);
            n.Set52(52);
            Assert.AreEqual(0, result);
            n.Set53(53);
            Assert.AreEqual(0, result);
            n.Set54(54);
            Assert.AreEqual(0, result);
            n.Set55(55);
            Assert.AreEqual(0, result);
            n.Set56(56);

            Assert.AreEqual(1596, result);

            n.Set1(100);
            Assert.AreEqual(1596, result);
        }

        [Test]
        public void SetValues_Reversed56()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51, p52, p53, p54, p55, p56) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51 + p52 + p53 + p54 + p55 + p56;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set56(56);
            Assert.AreEqual(0, result);
            n.Set55(55);
            Assert.AreEqual(0, result);
            n.Set54(54);
            Assert.AreEqual(0, result);
            n.Set53(53);
            Assert.AreEqual(0, result);
            n.Set52(52);
            Assert.AreEqual(0, result);
            n.Set51(51);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(1596, result);

            n.Set56(100);
            Assert.AreEqual(1596, result);
        }


        [Test]
        public void GetTypeFor57()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows57()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues57()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51, p52, p53, p54, p55, p56, p57) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51 + p52 + p53 + p54 + p55 + p56 + p57;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set51(51);
            Assert.AreEqual(0, result);
            n.Set52(52);
            Assert.AreEqual(0, result);
            n.Set53(53);
            Assert.AreEqual(0, result);
            n.Set54(54);
            Assert.AreEqual(0, result);
            n.Set55(55);
            Assert.AreEqual(0, result);
            n.Set56(56);
            Assert.AreEqual(0, result);
            n.Set57(57);

            Assert.AreEqual(1653, result);

            n.Set1(100);
            Assert.AreEqual(1653, result);
        }

        [Test]
        public void SetValues_Reversed57()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51, p52, p53, p54, p55, p56, p57) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51 + p52 + p53 + p54 + p55 + p56 + p57;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set57(57);
            Assert.AreEqual(0, result);
            n.Set56(56);
            Assert.AreEqual(0, result);
            n.Set55(55);
            Assert.AreEqual(0, result);
            n.Set54(54);
            Assert.AreEqual(0, result);
            n.Set53(53);
            Assert.AreEqual(0, result);
            n.Set52(52);
            Assert.AreEqual(0, result);
            n.Set51(51);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(1653, result);

            n.Set57(100);
            Assert.AreEqual(1653, result);
        }


        [Test]
        public void GetTypeFor58()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows58()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues58()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51, p52, p53, p54, p55, p56, p57, p58) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51 + p52 + p53 + p54 + p55 + p56 + p57 + p58;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set51(51);
            Assert.AreEqual(0, result);
            n.Set52(52);
            Assert.AreEqual(0, result);
            n.Set53(53);
            Assert.AreEqual(0, result);
            n.Set54(54);
            Assert.AreEqual(0, result);
            n.Set55(55);
            Assert.AreEqual(0, result);
            n.Set56(56);
            Assert.AreEqual(0, result);
            n.Set57(57);
            Assert.AreEqual(0, result);
            n.Set58(58);

            Assert.AreEqual(1711, result);

            n.Set1(100);
            Assert.AreEqual(1711, result);
        }

        [Test]
        public void SetValues_Reversed58()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51, p52, p53, p54, p55, p56, p57, p58) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51 + p52 + p53 + p54 + p55 + p56 + p57 + p58;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set58(58);
            Assert.AreEqual(0, result);
            n.Set57(57);
            Assert.AreEqual(0, result);
            n.Set56(56);
            Assert.AreEqual(0, result);
            n.Set55(55);
            Assert.AreEqual(0, result);
            n.Set54(54);
            Assert.AreEqual(0, result);
            n.Set53(53);
            Assert.AreEqual(0, result);
            n.Set52(52);
            Assert.AreEqual(0, result);
            n.Set51(51);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(1711, result);

            n.Set58(100);
            Assert.AreEqual(1711, result);
        }


        [Test]
        public void GetTypeFor59()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows59()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues59()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51, p52, p53, p54, p55, p56, p57, p58, p59) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51 + p52 + p53 + p54 + p55 + p56 + p57 + p58 + p59;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set51(51);
            Assert.AreEqual(0, result);
            n.Set52(52);
            Assert.AreEqual(0, result);
            n.Set53(53);
            Assert.AreEqual(0, result);
            n.Set54(54);
            Assert.AreEqual(0, result);
            n.Set55(55);
            Assert.AreEqual(0, result);
            n.Set56(56);
            Assert.AreEqual(0, result);
            n.Set57(57);
            Assert.AreEqual(0, result);
            n.Set58(58);
            Assert.AreEqual(0, result);
            n.Set59(59);

            Assert.AreEqual(1770, result);

            n.Set1(100);
            Assert.AreEqual(1770, result);
        }

        [Test]
        public void SetValues_Reversed59()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51, p52, p53, p54, p55, p56, p57, p58, p59) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51 + p52 + p53 + p54 + p55 + p56 + p57 + p58 + p59;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set59(59);
            Assert.AreEqual(0, result);
            n.Set58(58);
            Assert.AreEqual(0, result);
            n.Set57(57);
            Assert.AreEqual(0, result);
            n.Set56(56);
            Assert.AreEqual(0, result);
            n.Set55(55);
            Assert.AreEqual(0, result);
            n.Set54(54);
            Assert.AreEqual(0, result);
            n.Set53(53);
            Assert.AreEqual(0, result);
            n.Set52(52);
            Assert.AreEqual(0, result);
            n.Set51(51);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(1770, result);

            n.Set59(100);
            Assert.AreEqual(1770, result);
        }


        [Test]
        public void GetTypeFor60()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows60()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues60()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51, p52, p53, p54, p55, p56, p57, p58, p59, p60) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51 + p52 + p53 + p54 + p55 + p56 + p57 + p58 + p59 + p60;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set51(51);
            Assert.AreEqual(0, result);
            n.Set52(52);
            Assert.AreEqual(0, result);
            n.Set53(53);
            Assert.AreEqual(0, result);
            n.Set54(54);
            Assert.AreEqual(0, result);
            n.Set55(55);
            Assert.AreEqual(0, result);
            n.Set56(56);
            Assert.AreEqual(0, result);
            n.Set57(57);
            Assert.AreEqual(0, result);
            n.Set58(58);
            Assert.AreEqual(0, result);
            n.Set59(59);
            Assert.AreEqual(0, result);
            n.Set60(60);

            Assert.AreEqual(1830, result);

            n.Set1(100);
            Assert.AreEqual(1830, result);
        }

        [Test]
        public void SetValues_Reversed60()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51, p52, p53, p54, p55, p56, p57, p58, p59, p60) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51 + p52 + p53 + p54 + p55 + p56 + p57 + p58 + p59 + p60;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set60(60);
            Assert.AreEqual(0, result);
            n.Set59(59);
            Assert.AreEqual(0, result);
            n.Set58(58);
            Assert.AreEqual(0, result);
            n.Set57(57);
            Assert.AreEqual(0, result);
            n.Set56(56);
            Assert.AreEqual(0, result);
            n.Set55(55);
            Assert.AreEqual(0, result);
            n.Set54(54);
            Assert.AreEqual(0, result);
            n.Set53(53);
            Assert.AreEqual(0, result);
            n.Set52(52);
            Assert.AreEqual(0, result);
            n.Set51(51);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(1830, result);

            n.Set60(100);
            Assert.AreEqual(1830, result);
        }


        [Test]
        public void GetTypeFor61()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows61()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues61()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51, p52, p53, p54, p55, p56, p57, p58, p59, p60, p61) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51 + p52 + p53 + p54 + p55 + p56 + p57 + p58 + p59 + p60 + p61;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set51(51);
            Assert.AreEqual(0, result);
            n.Set52(52);
            Assert.AreEqual(0, result);
            n.Set53(53);
            Assert.AreEqual(0, result);
            n.Set54(54);
            Assert.AreEqual(0, result);
            n.Set55(55);
            Assert.AreEqual(0, result);
            n.Set56(56);
            Assert.AreEqual(0, result);
            n.Set57(57);
            Assert.AreEqual(0, result);
            n.Set58(58);
            Assert.AreEqual(0, result);
            n.Set59(59);
            Assert.AreEqual(0, result);
            n.Set60(60);
            Assert.AreEqual(0, result);
            n.Set61(61);

            Assert.AreEqual(1891, result);

            n.Set1(100);
            Assert.AreEqual(1891, result);
        }

        [Test]
        public void SetValues_Reversed61()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51, p52, p53, p54, p55, p56, p57, p58, p59, p60, p61) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51 + p52 + p53 + p54 + p55 + p56 + p57 + p58 + p59 + p60 + p61;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set61(61);
            Assert.AreEqual(0, result);
            n.Set60(60);
            Assert.AreEqual(0, result);
            n.Set59(59);
            Assert.AreEqual(0, result);
            n.Set58(58);
            Assert.AreEqual(0, result);
            n.Set57(57);
            Assert.AreEqual(0, result);
            n.Set56(56);
            Assert.AreEqual(0, result);
            n.Set55(55);
            Assert.AreEqual(0, result);
            n.Set54(54);
            Assert.AreEqual(0, result);
            n.Set53(53);
            Assert.AreEqual(0, result);
            n.Set52(52);
            Assert.AreEqual(0, result);
            n.Set51(51);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(1891, result);

            n.Set61(100);
            Assert.AreEqual(1891, result);
        }


        [Test]
        public void GetTypeFor62()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows62()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues62()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51, p52, p53, p54, p55, p56, p57, p58, p59, p60, p61, p62) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51 + p52 + p53 + p54 + p55 + p56 + p57 + p58 + p59 + p60 + p61 + p62;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set51(51);
            Assert.AreEqual(0, result);
            n.Set52(52);
            Assert.AreEqual(0, result);
            n.Set53(53);
            Assert.AreEqual(0, result);
            n.Set54(54);
            Assert.AreEqual(0, result);
            n.Set55(55);
            Assert.AreEqual(0, result);
            n.Set56(56);
            Assert.AreEqual(0, result);
            n.Set57(57);
            Assert.AreEqual(0, result);
            n.Set58(58);
            Assert.AreEqual(0, result);
            n.Set59(59);
            Assert.AreEqual(0, result);
            n.Set60(60);
            Assert.AreEqual(0, result);
            n.Set61(61);
            Assert.AreEqual(0, result);
            n.Set62(62);

            Assert.AreEqual(1953, result);

            n.Set1(100);
            Assert.AreEqual(1953, result);
        }

        [Test]
        public void SetValues_Reversed62()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51, p52, p53, p54, p55, p56, p57, p58, p59, p60, p61, p62) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51 + p52 + p53 + p54 + p55 + p56 + p57 + p58 + p59 + p60 + p61 + p62;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set62(62);
            Assert.AreEqual(0, result);
            n.Set61(61);
            Assert.AreEqual(0, result);
            n.Set60(60);
            Assert.AreEqual(0, result);
            n.Set59(59);
            Assert.AreEqual(0, result);
            n.Set58(58);
            Assert.AreEqual(0, result);
            n.Set57(57);
            Assert.AreEqual(0, result);
            n.Set56(56);
            Assert.AreEqual(0, result);
            n.Set55(55);
            Assert.AreEqual(0, result);
            n.Set54(54);
            Assert.AreEqual(0, result);
            n.Set53(53);
            Assert.AreEqual(0, result);
            n.Set52(52);
            Assert.AreEqual(0, result);
            n.Set51(51);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(1953, result);

            n.Set62(100);
            Assert.AreEqual(1953, result);
        }


        [Test]
        public void GetTypeFor63()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows63()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues63()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51, p52, p53, p54, p55, p56, p57, p58, p59, p60, p61, p62, p63) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51 + p52 + p53 + p54 + p55 + p56 + p57 + p58 + p59 + p60 + p61 + p62 + p63;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set51(51);
            Assert.AreEqual(0, result);
            n.Set52(52);
            Assert.AreEqual(0, result);
            n.Set53(53);
            Assert.AreEqual(0, result);
            n.Set54(54);
            Assert.AreEqual(0, result);
            n.Set55(55);
            Assert.AreEqual(0, result);
            n.Set56(56);
            Assert.AreEqual(0, result);
            n.Set57(57);
            Assert.AreEqual(0, result);
            n.Set58(58);
            Assert.AreEqual(0, result);
            n.Set59(59);
            Assert.AreEqual(0, result);
            n.Set60(60);
            Assert.AreEqual(0, result);
            n.Set61(61);
            Assert.AreEqual(0, result);
            n.Set62(62);
            Assert.AreEqual(0, result);
            n.Set63(63);

            Assert.AreEqual(2016, result);

            n.Set1(100);
            Assert.AreEqual(2016, result);
        }

        [Test]
        public void SetValues_Reversed63()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51, p52, p53, p54, p55, p56, p57, p58, p59, p60, p61, p62, p63) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51 + p52 + p53 + p54 + p55 + p56 + p57 + p58 + p59 + p60 + p61 + p62 + p63;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set63(63);
            Assert.AreEqual(0, result);
            n.Set62(62);
            Assert.AreEqual(0, result);
            n.Set61(61);
            Assert.AreEqual(0, result);
            n.Set60(60);
            Assert.AreEqual(0, result);
            n.Set59(59);
            Assert.AreEqual(0, result);
            n.Set58(58);
            Assert.AreEqual(0, result);
            n.Set57(57);
            Assert.AreEqual(0, result);
            n.Set56(56);
            Assert.AreEqual(0, result);
            n.Set55(55);
            Assert.AreEqual(0, result);
            n.Set54(54);
            Assert.AreEqual(0, result);
            n.Set53(53);
            Assert.AreEqual(0, result);
            n.Set52(52);
            Assert.AreEqual(0, result);
            n.Set51(51);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(2016, result);

            n.Set63(100);
            Assert.AreEqual(2016, result);
        }


        [Test]
        public void GetTypeFor64()
        {
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>),
                Node.GetTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
            Assert.AreEqual(
                typeof(Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action),
                Node.GetActionTypeFor(new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int) }));
        }

        [Test]
        public void SetActionThrows64()
        {
            Assert.Throws<ArgumentNullException>(() => new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null));
            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            Assert.Throws<ArgumentNullException>(() => n.SetAction(null));
            Assert.Throws<InvalidOperationException>(() => n.Set1(0));
        }

        [Test]
        public void SetValues64()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51, p52, p53, p54, p55, p56, p57, p58, p59, p60, p61, p62, p63, p64) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51 + p52 + p53 + p54 + p55 + p56 + p57 + p58 + p59 + p60 + p61 + p62 + p63 + p64;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>();
            n.SetAction(action);
            Assert.AreEqual(0, result);
            n.Set1(1);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set51(51);
            Assert.AreEqual(0, result);
            n.Set52(52);
            Assert.AreEqual(0, result);
            n.Set53(53);
            Assert.AreEqual(0, result);
            n.Set54(54);
            Assert.AreEqual(0, result);
            n.Set55(55);
            Assert.AreEqual(0, result);
            n.Set56(56);
            Assert.AreEqual(0, result);
            n.Set57(57);
            Assert.AreEqual(0, result);
            n.Set58(58);
            Assert.AreEqual(0, result);
            n.Set59(59);
            Assert.AreEqual(0, result);
            n.Set60(60);
            Assert.AreEqual(0, result);
            n.Set61(61);
            Assert.AreEqual(0, result);
            n.Set62(62);
            Assert.AreEqual(0, result);
            n.Set63(63);
            Assert.AreEqual(0, result);
            n.Set64(64);

            Assert.AreEqual(2080, result);

            n.Set1(100);
            Assert.AreEqual(2080, result);
        }

        [Test]
        public void SetValues_Reversed64()
        {
            var result = 0;
            Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>.Action action = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51, p52, p53, p54, p55, p56, p57, p58, p59, p60, p61, p62, p63, p64) => result = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24 + p25 + p26 + p27 + p28 + p29 + p30 + p31 + p32 + p33 + p34 + p35 + p36 + p37 + p38 + p39 + p40 + p41 + p42 + p43 + p44 + p45 + p46 + p47 + p48 + p49 + p50 + p51 + p52 + p53 + p54 + p55 + p56 + p57 + p58 + p59 + p60 + p61 + p62 + p63 + p64;

            var n = new Node<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(action);
            Assert.AreEqual(0, result);
            n.Set64(64);
            Assert.AreEqual(0, result);
            n.Set63(63);
            Assert.AreEqual(0, result);
            n.Set62(62);
            Assert.AreEqual(0, result);
            n.Set61(61);
            Assert.AreEqual(0, result);
            n.Set60(60);
            Assert.AreEqual(0, result);
            n.Set59(59);
            Assert.AreEqual(0, result);
            n.Set58(58);
            Assert.AreEqual(0, result);
            n.Set57(57);
            Assert.AreEqual(0, result);
            n.Set56(56);
            Assert.AreEqual(0, result);
            n.Set55(55);
            Assert.AreEqual(0, result);
            n.Set54(54);
            Assert.AreEqual(0, result);
            n.Set53(53);
            Assert.AreEqual(0, result);
            n.Set52(52);
            Assert.AreEqual(0, result);
            n.Set51(51);
            Assert.AreEqual(0, result);
            n.Set50(50);
            Assert.AreEqual(0, result);
            n.Set49(49);
            Assert.AreEqual(0, result);
            n.Set48(48);
            Assert.AreEqual(0, result);
            n.Set47(47);
            Assert.AreEqual(0, result);
            n.Set46(46);
            Assert.AreEqual(0, result);
            n.Set45(45);
            Assert.AreEqual(0, result);
            n.Set44(44);
            Assert.AreEqual(0, result);
            n.Set43(43);
            Assert.AreEqual(0, result);
            n.Set42(42);
            Assert.AreEqual(0, result);
            n.Set41(41);
            Assert.AreEqual(0, result);
            n.Set40(40);
            Assert.AreEqual(0, result);
            n.Set39(39);
            Assert.AreEqual(0, result);
            n.Set38(38);
            Assert.AreEqual(0, result);
            n.Set37(37);
            Assert.AreEqual(0, result);
            n.Set36(36);
            Assert.AreEqual(0, result);
            n.Set35(35);
            Assert.AreEqual(0, result);
            n.Set34(34);
            Assert.AreEqual(0, result);
            n.Set33(33);
            Assert.AreEqual(0, result);
            n.Set32(32);
            Assert.AreEqual(0, result);
            n.Set31(31);
            Assert.AreEqual(0, result);
            n.Set30(30);
            Assert.AreEqual(0, result);
            n.Set29(29);
            Assert.AreEqual(0, result);
            n.Set28(28);
            Assert.AreEqual(0, result);
            n.Set27(27);
            Assert.AreEqual(0, result);
            n.Set26(26);
            Assert.AreEqual(0, result);
            n.Set25(25);
            Assert.AreEqual(0, result);
            n.Set24(24);
            Assert.AreEqual(0, result);
            n.Set23(23);
            Assert.AreEqual(0, result);
            n.Set22(22);
            Assert.AreEqual(0, result);
            n.Set21(21);
            Assert.AreEqual(0, result);
            n.Set20(20);
            Assert.AreEqual(0, result);
            n.Set19(19);
            Assert.AreEqual(0, result);
            n.Set18(18);
            Assert.AreEqual(0, result);
            n.Set17(17);
            Assert.AreEqual(0, result);
            n.Set16(16);
            Assert.AreEqual(0, result);
            n.Set15(15);
            Assert.AreEqual(0, result);
            n.Set14(14);
            Assert.AreEqual(0, result);
            n.Set13(13);
            Assert.AreEqual(0, result);
            n.Set12(12);
            Assert.AreEqual(0, result);
            n.Set11(11);
            Assert.AreEqual(0, result);
            n.Set10(10);
            Assert.AreEqual(0, result);
            n.Set9(9);
            Assert.AreEqual(0, result);
            n.Set8(8);
            Assert.AreEqual(0, result);
            n.Set7(7);
            Assert.AreEqual(0, result);
            n.Set6(6);
            Assert.AreEqual(0, result);
            n.Set5(5);
            Assert.AreEqual(0, result);
            n.Set4(4);
            Assert.AreEqual(0, result);
            n.Set3(3);
            Assert.AreEqual(0, result);
            n.Set2(2);
            Assert.AreEqual(0, result);
            n.Set1(1);

            Assert.AreEqual(2080, result);

            n.Set64(100);
            Assert.AreEqual(2080, result);
        }

    }
}