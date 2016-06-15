using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCodeUnitTest
{
    using SimpleCode;

    [TestClass]
    public class SimpleCodeUnitTest
    {
        [TestMethod]
        public void GivenSimpleCode_WhenMainInstanceValueNull_AndParameterValueNull_ThenValueNull()
        {
            // Arrange
            var mainInstance = new SimpleCode() {Value= null};
            var simpleCodeParameter = new SimpleCode() { Value = null };

            // Act
            var result = mainInstance.Merge(simpleCodeParameter);

            // Assert
            Assert.IsNull(result.Value);
        }

        [TestMethod]
        public void GivenSimpleCode_WhenMainInstanceValueNotNull_AndParameterValueNull_ThenMainInstanceValue()
        {
            // Arrange
            const string VALUE = "Test";
            var mainInstance = new SimpleCode() { Value = VALUE };
            var simpleCodeParameter = new SimpleCode() { Value = null };

            // Act
            var result = mainInstance.Merge(simpleCodeParameter);

            // Assert
            Assert.AreEqual(VALUE, result.Value);
        }
    
        [TestMethod]
        public void GivenSimpleCode_WhenMainInstanceValueNull_AndParameterValueNotNull_ThenParameterValue()
        {
            // Arrange
            const string VALUE = "Test";
            var mainInstance = new SimpleCode() { Value = null };
            var simpleCodeParameter = new SimpleCode() { Value = VALUE };

            // Act
            var result = mainInstance.Merge(simpleCodeParameter);

            // Assert
            Assert.AreEqual(VALUE, result.Value);
        }

        [TestMethod]
        public void GivenSimpleCode_WhenMainInstanceValueNotNull_AndParameterValueNotNull_ThenValueParameterValue()
        {
            // Arrange
            const string VALUE1 = "Test1";
            const string VALUE2 = "Test2";
            var mainInstance = new SimpleCode() { Value = VALUE1 };
            var simpleCodeParameter = new SimpleCode() { Value = VALUE2 };

            // Act
            var result = mainInstance.Merge(simpleCodeParameter);

            // Assert
            Assert.AreEqual(VALUE2, result.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void GivenSimpleCode_WhenParameterNull_ThenException()
        {
            // Arrange
            var mainInstance = new SimpleCode();
            SimpleCode simpleCodeParameter = null;

            // Act & Assert
            mainInstance.Merge(simpleCodeParameter);
        }


        [TestMethod]
        public void GivenSimpleCode_DefaultValue_ValueNull()
        {
            // Arrange & Act
            var mainInstance = new SimpleCode();

            // Assert
            Assert.IsNull(mainInstance.Value);
        }
    }
}
