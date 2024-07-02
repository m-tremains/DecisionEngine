using BookKeeping.Services.Enums;
using BookKeeping.Services.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookKeeping.Services.Tests
{
    [TestClass]
    public class ComponentModelTests
    {
        private ComponentModel _creditComponent => new ComponentModel(ComponentTypeEnum.Credit);
        private ComponentModel _debitComponent => new ComponentModel(ComponentTypeEnum.Debit);
        private ComponentModel _compositeComponent => new ComponentModel(ComponentTypeEnum.Composite);

        [TestInitialize]
        public void Setup()
        {
        }

        [TestMethod]
        public void GetComponentType_SubComponents_null()
        {
            const ComponentTypeEnum expectedComponentType = ComponentTypeEnum.Credit;

            var component = new ComponentModel(expectedComponentType);
            var actualComponentType = component.ComponentType;

            Assert.AreEqual(expectedComponentType, actualComponentType);
        }

        [TestMethod]
        public void GetComponentType_SubComponents_empty()
        {
            const ComponentTypeEnum expectedComponentType = ComponentTypeEnum.Credit;

            var component = new ComponentModel(expectedComponentType)
            {
                SubComponents = new ComponentModel[0]
            };
            var actualComponentType = component.ComponentType;

            Assert.AreEqual(expectedComponentType, actualComponentType);
        }

        [TestMethod]
        public void GetComponentType_SubComponents_isComposite_hasComposite()
        {
            const ComponentTypeEnum expectedComponentType = ComponentTypeEnum.Composite;

            var component = new ComponentModel()
            {
                SubComponents = new[] { _compositeComponent }
            };
            var actualComponentType = component.ComponentType;

            Assert.AreEqual(expectedComponentType, actualComponentType);
        }

        [TestMethod]
        public void GetComponentType_SubComponents_isComposite_multipleComponentType()
        {
            const ComponentTypeEnum expectedComponentType = ComponentTypeEnum.Composite;

            var component = new ComponentModel()
            {
                SubComponents = new[] { _creditComponent, _debitComponent }
            };
            var actualComponentType = component.ComponentType;

            Assert.AreEqual(expectedComponentType, actualComponentType);
        }

        [TestMethod]
        public void GetComponentType_SubComponents_singleComponentType()
        {
            const ComponentTypeEnum expectedComponentType = ComponentTypeEnum.Credit;

            var component = new ComponentModel()
            {
                SubComponents = new[] { _creditComponent, _creditComponent }
            };
            var actualComponentType = component.ComponentType;

            Assert.AreEqual(expectedComponentType, actualComponentType);
        }
    }
}
