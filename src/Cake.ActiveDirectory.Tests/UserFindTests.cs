﻿using NSubstitute;
using System;
using Cake.ActiveDirectory.Tests.Fixture;
using Landpy.ActiveDirectory.Core;
using Should;
using Should.Core.Assertions;

namespace Cake.ActiveDirectory.Tests {
    public sealed class UserFindTests {
        public sealed class FindUserPrincpalTests {
            public void Should_Throw_If_PropertyName_Is_Null() {
                // Given
                var adOperator = Substitute.For<IADOperator>();
                var fixture = new UserFindFixture(adOperator);
                fixture.PropertyName = null;

                // When
                var result = Record.Exception(() => fixture.FindUserPrincipalNameByProperty());

                // Then
                result.ShouldBeType<ArgumentNullException>().ParamName.ShouldEqual("propertyName");
            }

            public void Should_Throw_If_PropertyValue_Is_Null() {
                // Given
                var adOperator = Substitute.For<IADOperator>();
                var fixture = new UserFindFixture(adOperator);
                fixture.PropertyValue = null;

                // When
                var result = Record.Exception(() => fixture.FindUserPrincipalNameByProperty());

                // Then
                result.ShouldBeType<ArgumentNullException>().ParamName.ShouldEqual("propertyValue");
            }
        }

        public sealed class FindDistinguishedNameTests {
            public void Should_Throw_If_PropertyName_Is_Null() {
                // Given
                var adOperator = Substitute.For<IADOperator>();
                var fixture = new UserFindFixture(adOperator);
                fixture.PropertyName = null;

                // When
                var result = Record.Exception(() => fixture.FindDistinguishedNameByProperty());

                // Then
                result.ShouldBeType<ArgumentNullException>().ParamName.ShouldEqual("propertyName");
            }

            public void Should_Throw_If_PropertyValue_Is_Null() {
                // Given
                var adOperator = Substitute.For<IADOperator>();
                var fixture = new UserFindFixture(adOperator);
                fixture.PropertyValue = null;

                // When
                var result = Record.Exception(() => fixture.FindDistinguishedNameByProperty());

                // Then
                result.ShouldBeType<ArgumentNullException>().ParamName.ShouldEqual("propertyValue");
            }
        }

        public sealed class FindAttributeValueTests {
            public void Should_Throw_If_PropertyName_Is_Null() {
                // Given
                var adOperator = Substitute.For<IADOperator>();
                var fixture = new UserFindFixture(adOperator);
                fixture.PropertyName = null;

                // When
                var result = Record.Exception(() => fixture.FindAttributeValueByProperty());

                // Then
                result.ShouldBeType<ArgumentNullException>().ParamName.ShouldEqual("propertyName");
            }

            public void Should_Throw_If_PropertyValue_Is_Null() {
                // Given
                var adOperator = Substitute.For<IADOperator>();
                var fixture = new UserFindFixture(adOperator);
                fixture.PropertyValue = null;

                // When
                var result = Record.Exception(() => fixture.FindAttributeValueByProperty());

                // Then
                result.ShouldBeType<ArgumentNullException>().ParamName.ShouldEqual("propertyValue");
            }

            public void Should_Throw_If_AttributeName_Is_Null() {
                // Given
                var adOperator = Substitute.For<IADOperator>();
                var fixture = new UserFindFixture(adOperator);
                fixture.AttributeName = null;

                // When
                var result = Record.Exception(() => fixture.FindAttributeValueByProperty());

                // Then
                result.ShouldBeType<ArgumentNullException>().ParamName.ShouldEqual("attributeName");
            }
        }
    }
}
