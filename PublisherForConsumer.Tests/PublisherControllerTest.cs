using System;
using NUnit;
using NUnit.Framework;
using NSMPublisherForConsumer.Controllers;
using System.Web.Http;
using Moq;
using NSMPublisherForConsumer.Repository;
using NSMPublisherForConsumer.Models;
using NSMPublisherForConsumer.Logger;

namespace NSMPublisherForConsumer.Tests
{
    [TestFixture]
    public class PublisherControllerTest
    {
        private PublisherController _publish = null;
        private TestRepository _testRepo = null;
        Mock<IExternalLogService> _moqRepository = new Mock<IExternalLogService>();
        [SetUp]
        public void PublishControllerTest()
        {
            _testRepo = new TestRepository();
            _publish = new PublisherController(_testRepo);
        }
        [Test]
        public void When_Publish_Method_Is_Called_Return_Success()
        {
          string actualResult=_publish.Publish(100);
            Assert.AreEqual("success", actualResult);
        }
        [Test]
        public void When_Eternal_Log_File_Is_Called()
        {
            _moqRepository.Setup(x => x.LogError()).Returns(false);

            var moqobj = _moqRepository.Object;

            IExternalLogService products = moqobj;

            IRepository<Publisher> product = new Repository.Repository(moqobj);
            bool actualResult = products.LogError();

            Assert.AreEqual(false, actualResult);
        }
    }
}
