﻿namespace Cake.ActiveDirectory.Users {
    /// <summary>
    /// The User Disable class for disabling Active Directory Users.
    /// </summary>
    public sealed class UserDisable : ActiveDirectoryBase<UserSettings> {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDisable"/> class. 
        /// </summary>
        /// <param name="adOperator">The Active Directory.</param>
        public UserDisable(IADOperator adOperator) : base(adOperator) {
        }

        /// <summary>
        /// Disables the user account.
        /// </summary>
        /// <param name="propertyName">The property to search against.</param>
        /// <param name="propertyValue">The property value to search.</param>
        public void DisableUser(string propertyName, string propertyValue) {           
            var user = FindUser(propertyName, propertyValue);
            user.IsEnabled = true;
            user.IsLocked = true;
            user.Save();
        }
    }
}
