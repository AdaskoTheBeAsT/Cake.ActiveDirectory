using Cake.ActiveDirectory.Tests.Fixture;
using NSubstitute;
using System;
using Xunit;

namespace Cake.ActiveDirectory.Tests {
    public sealed class UserDisableTests {
        [Fact]
        public void Should_Throw_If_AttributeName_Is_Null() {
            // Given
            var adOperator = Substitute.For<IADOperator>();
            var fixture = new UserDisableFixture(adOperator);
            fixture.PropertyName = null;

            // When
            var result = Record.Exception(() => fixture.DisableUser());

            // Then
            result.ShouldBeOfType<ArgumentNullException>().ParamName.ShouldBe("propertyName");
        }
        [Fact]
        public void Should_Throw_If_AttributeValue_Is_Null() {
            // Given
            var adOperator = Substitute.For<IADOperator>();
            var fixture = new UserDisableFixture(adOperator);
            fixture.PropertyValue = null;

            // When
            var result = Record.Exception(() => fixture.DisableUser());

            // Then
            result.ShouldBeOfType<ArgumentNullException>().ParamName.ShouldBe("propertyValue");
        }
    }
}
