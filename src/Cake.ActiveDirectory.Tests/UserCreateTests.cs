﻿using System;
using Cake.ActiveDirectory.Tests.Fixture;
using NSubstitute;
using Shouldly;
using Xunit;

namespace Cake.ActiveDirectory.Tests {
    public sealed class UserCreateTests {
        [Fact]
        public void Should_Throw_If_Settings_Are_Null() {
            // Given
            var adOperator = Substitute.For<IADOperator>();
            var fixture = new UserCreateFixture(adOperator);
            fixture.Settings = null;

            // When
            var result = Record.Exception(() => fixture.CreateUser());

            // Then
            result.ShouldBeOfType<ArgumentNullException>().ParamName.ShouldBe("settings");
        }
        [Fact]
        public void Should_Throw_If_SAMAccountName_Is_Null() {
            // Given
            var adOperator = Substitute.For<IADOperator>();
            var fixture = new UserCreateFixture(adOperator);
            fixture.SamAccountName = null;

            // When
            var result = Record.Exception(() => fixture.CreateUser());

            // Then
            result.ShouldBeOfType<ArgumentNullException>().ParamName.ShouldBe("samAccountName");
        }
        [Fact]
        public void Should_Throw_If_OUDistinguishedName_Is_Null() {
            // Given
            var adOperator = Substitute.For<IADOperator>();
            var fixture = new UserCreateFixture(adOperator);
            fixture.OuDistinguishedName = null;

            // When
            var result = Record.Exception(() => fixture.CreateUser());

            // Then
            result.ShouldBeOfType<ArgumentNullException>().ParamName.ShouldBe("ouDistinguishedName");
        }

        //public void Should_Create_User() {
        //    //Given
        //    var adOperator = Substitute.For<IADOperator>();
        //    adOperator.GetOperatorInfo()
        //        .Returns(new ADOperatorInfo {UserLoginName = "admin", Password = "admin", OperateDomainName = "test"});
        //    var fixture = new UserCreateFixture(adOperator);

        //    // When
        //    fixture.CreateUser();

        //    // Then
        //    adOperator.ReceivedCalls().Count().ShouldBeGreaterThan(0);
        //}
    }
}
