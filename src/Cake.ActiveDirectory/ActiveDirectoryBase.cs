using Cake.ActiveDirectory.Users;
using System;
using Novell.Directory.Ldap;

namespace Cake.ActiveDirectory {
    /// <summary>
    /// The Active Directory command base class.
    /// </summary>
    public abstract class ActiveDirectoryBase<TSettings>
        where TSettings : ActiveDirectorySettings
    {

        internal readonly TSettings _settings;

        /// <summary>
        /// Intializes a new instance of the <see cref="ActiveDirectoryBase{TSettings}"/> class;
        /// </summary>
        /// <param name="settings">The Active Directory settings.</param>
        protected ActiveDirectoryBase(TSettings settings) {
            _settings = settings;
        }
        
        /// <summary>
        /// Adds user settings to the User Object.
        /// </summary>
        /// <param name="user">The user object to add settings.</param>
        /// <param name="settings">The settings.</param>
        /// <returns>User object with new settings.</returns>
        protected UserObject AddSettingsToUser(UserObject user, UserSettings settings) {
            if (!string.IsNullOrWhiteSpace(settings.FirstName)) {
                user.GivenName = settings.FirstName;
            }

            if (!string.IsNullOrWhiteSpace(settings.LastName)) {
                user.LastName = settings.LastName;
            }

            if (!string.IsNullOrWhiteSpace(settings.DisplayName)) {
                user.DisplayName = settings.DisplayName;
            }

            if (!string.IsNullOrWhiteSpace(settings.Title)) {
                user.JobTitle = settings.Title;
            }

            if (!string.IsNullOrWhiteSpace(settings.Manager)) {
                user.Manager = settings.Manager;
            }

            if (!string.IsNullOrWhiteSpace(settings.Department)) {
                user.Department = settings.Department;
            }

            if (!string.IsNullOrWhiteSpace(settings.PhoneNumber)) {
                user.Telephone = settings.PhoneNumber;
            }

            if (!string.IsNullOrWhiteSpace(settings.StreetAddress)) {
                user.StreetAddress = settings.StreetAddress;
            }

            if (!string.IsNullOrWhiteSpace(settings.Description)) {
                user.Description = settings.Description;
            }

            if (!string.IsNullOrWhiteSpace(settings.Email)) {
                user.Email = settings.Email;
            }
            user.SetAttributeIfNotNull("homeDirectory", settings.HomeDirectory);
            user.SetAttributeIfNotNull("homeDrive", settings.HomeDrive);
            user.IsMustChangePwdNextLogon = settings.MustChangePasswordNextLogon;
            return user;
        }

        internal UserObject FindUser(string propertyName, string propertyValue) {
            if (string.IsNullOrWhiteSpace(propertyName)) {
                throw new ArgumentNullException(nameof(propertyName));
            }
            if (string.IsNullOrWhiteSpace(propertyValue)) {
                throw new ArgumentNullException(nameof(propertyValue));
            }

            var ldapConn = new LdapConnection();
            ldapConn.Connect(_settings.LdapHost, _settings.LdapPort);
            ldapConn.Bind(_settings.LoginName, _settings.Password);


            return UserObject.FindAll(_adOperator, new Is(propertyName, propertyValue)).FirstOrDefault();
        }
    }
}
