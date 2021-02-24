using NSubstitute;
using System;
using Cake.ActiveDirectory.Tests.Fixture;
using Xunit;

namespace Cake.ActiveDirectory.Tests {
    public sealed class UserDeleteTests {
        [Fact]
        public void Should_Throw_If_UserPrincipalName_Is_Null() {
            // Given
            var adOperator = Substitute.For<IADOperator>();
            var fixture = new UserDeleteFixture(adOperator);
            fixture.UserPrincipalName = null;

            // When
            var result = Record.Exception(() => fixture.DeleteUser());

            // Then
            result.ShouldBeOfType<ArgumentNullException>().ParamName.ShouldBe("userPrincipalName");
        }
    }
}
