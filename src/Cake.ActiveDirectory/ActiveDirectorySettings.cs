namespace Cake.ActiveDirectory {
    /// <summary>
    /// The base class for all ActiveDirectory settings.
    /// </summary>
    public class ActiveDirectorySettings {
        /// <summary>
        /// LoginName for Active Directory Login
        /// </summary>
        public string LoginName { get; set; }

        /// <summary>
        /// Password for Active Directory Login.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Ldap host.
        /// </summary>
        public string LdapHost { get; set; }

        /// <summary>
        /// Ldap port.
        /// </summary>
        public int LdapPort { get; set; }
    }
}
