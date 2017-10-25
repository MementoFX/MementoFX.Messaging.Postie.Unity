using Microsoft.Practices.Unity;
using Moq;
using NUnit.Framework;
using SharpTestsEx;
using System;

namespace MementoFX.Messaging.Postie.Unity.Tests
{
    [TestFixture]
    public class UnityTypeResolverFixture
    {
        [Test]
        public void Ctor_should_throw_ArgumentNullException_on_null_container_parameter()
        {
            Executing.This(() => new UnityTypeResolver(null))
                .Should()
                .Throw<ArgumentNullException>()
                .And
                .ValueOf
                .ParamName
                .Should()
                .Be
                .EqualTo("container");
        }

        [Test]
        public void Ctor_should_set_Container_property()
        {
            var containerMock = new Mock<IUnityContainer>().Object;
            var sut = new UnityTypeResolver(containerMock);
            Assert.AreSame(containerMock, sut.Container);
        }

        [Test]
        public void Resolve__should_throw_ArgumentNullException_on_null_t_parameter()
        {
            var containerMock = new Mock<IUnityContainer>().Object;
            var sut = new UnityTypeResolver(containerMock);
            Executing.This(() => sut.Resolve(null))
                .Should()
                .Throw<ArgumentNullException>()
                .And
                .ValueOf
                .ParamName
                .Should()
                .Be
                .EqualTo("t");
        }
    }
}
