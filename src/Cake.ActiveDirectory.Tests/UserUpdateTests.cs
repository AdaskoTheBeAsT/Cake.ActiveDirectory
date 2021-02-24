﻿using System;
using Cake.ActiveDirectory.Tests.Fixture;
using NSubstitute;
using Shouldly;
using Xunit;

namespace Cake.ActiveDirectory.Tests {
    public sealed class UserUpdateTests {
        public sealed class UpdateUserTests {
            [Fact]
            public void Should_Throw_If_Settings_Are_Null() {
                // Given
                var adOperator = Substitute.For<IADOperator>();
                var fixture = new UserUpdateFixture(adOperator);
                fixture.Settings = null;

                // When
                var result = Record.Exception(() => fixture.UpdateUser());

                // Then
                result.ShouldBeOfType<ArgumentNullException>().ParamName.ShouldBe("settings");
            }
            [Fact]
            public void Should_Throw_If_AttributeName_Is_Null() {
                // Given
                var adOperator = Substitute.For<IADOperator>();
                var fixture = new UserUpdateFixture(adOperator);
                fixture.AttributeName = null;

                // When
                var result = Record.Exception(() => fixture.UpdateUser());

                // Then
                result.ShouldBeOfType<ArgumentNullException>().ParamName.ShouldBe("attributeName");
            }
            [Fact]
            public void Should_Throw_If_AttributeValue_Is_Null() {
                // Given
                var adOperator = Substitute.For<IADOperator>();
                var fixture = new UserUpdateFixture(adOperator);
                fixture.AttributeValue = null;

                // When
                var result = Record.Exception(() => fixture.UpdateUser());

                // Then
                result.ShouldBeOfType<ArgumentNullException>().ParamName.ShouldBe("attributeValue");
            }
        }

        public sealed class UpdateOrganizationUnitTests {
            [Fact]
            public void Should_Throw_If_PropertyName_Is_Null() {
                // Given
                var adOperator = Substitute.For<IADOperator>();
                var fixture = new UserUpdateFixture(adOperator);
                fixture.AttributeName = null;

                // When
                var result = Record.Exception(() => fixture.UpdateOrganizationUnit());

                // Then
                result.ShouldBeOfType<ArgumentNullException>().ParamName.ShouldBe("propertyName");
            }
            [Fact]
            public void Should_Throw_If_PropertyValue_Is_Null() {
                // Given
                var adOperator = Substitute.For<IADOperator>();
                var fixture = new UserUpdateFixture(adOperator);
                fixture.AttributeValue = null;

                // When
                var result = Record.Exception(() => fixture.UpdateOrganizationUnit());

                // Then
                result.ShouldBeOfType<ArgumentNullException>().ParamName.ShouldBe("propertyValue");
            }

            [Fact]
            public void Should_Throw_If_OrganizationUnit_Is_Null() {
                // Given
                var adOperator = Substitute.For<IADOperator>();
                var fixture = new UserUpdateFixture(adOperator);
                fixture.OrganizationalUnit = null;

                // When
                var result = Record.Exception(() => fixture.UpdateOrganizationUnit());

                // Then
                result.ShouldBeOfType<ArgumentNullException>().ParamName.ShouldBe("organizationalUnit");
            }
        }
    }
}
