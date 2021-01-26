using GraphQL.Types;
using System.Collections.Generic;
using System.Linq;

namespace ProShop.Web.GraphQL
{
    public static class GraphQLAuthExtensions
    {
        private static readonly string PermissionsKey = "permission";

        public static void RequiresPermission(
            this IProvideMetadata type,
            string claim)
        {
            var permissions = type.GetPermissions();
            permissions.Add(claim);

            type.Metadata[PermissionsKey] = permissions;
        }

        public static bool ContainsMatchingClaims(
            this IProvideMetadata type,
            IEnumerable<string> claims)
        {
            var permissions = type.GetPermissions();
            return permissions.Any(p => claims.Contains(p));
        }

        public static bool ContainsAnyClaims(
            this IProvideMetadata type)
        {
            var permissions = type.GetPermissions(new List<string> { });
            return permissions.Any();
        }

        private static List<string> GetPermissions(
            this IProvideMetadata type,
            List<string> defaultValue = null)
        {
            return type.GetMetadata(PermissionsKey, defaultValue)
                ?? new List<string>();
        }
    }
}
