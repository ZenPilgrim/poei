using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace FirstAspNet.Configurations
{
    public class CustomRoleProvider : RoleProvider
    {
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            using (var db = new Model1())
            {
                return db.Roles.Select(r => r.Title).ToArray();
            }
        }


        public override string[] GetRolesForUser(string nom)
        {
            using (var db = new Model1())
            {
                var personne = db.Personnes.SingleOrDefault(u
                => u.Nom == nom);
                if (personne == null)
                    return new string[] { };
                return personne.Roles == null ? new string[] { } : personne.Roles.Select(u => u.Title).
                ToArray();
            }
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string nom, string title)
        {
            using (var db = new Model1())
            {
                var personne = db.Personnes.SingleOrDefault(u =>
                u.Nom == nom);
                if (personne == null)
                    return false;
                var role = (from r in db.Roles
                            where r.Title.Equals(title) && r.
                            Personnes.Any(u => u.Nom == nom)
                            select r).First();
                return role != null;
            }
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }

}