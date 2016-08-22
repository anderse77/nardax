using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nardax.UnitTests
{
    [TestClass]
    public class QueueExtensionsTests
    {
        Queue<string> _queue;

        public QueueExtensionsTests()
        {
            _queue = new Queue<string>();
            _queue.Enqueue("aa");
            _queue.Enqueue("bb");

            Assert.AreEqual("cc", _queue.Dequeue());
            Assert.AreEqual("dd", _queue.Dequeue());
            Assert.AreEqual("ee", _queue.Dequeue());
        }
    }
}
