using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Assignment_4
{
    internal class PermissionsEnum
    {
        //  4- Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
        // Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable

        public void RunExample4()
        {

            Permissions userPermissions = Permissions.Read | Permissions.Write; // Initial permissions
            userPermissions = userPermissions | Permissions.Delete; // Add Delete permission
            userPermissions = userPermissions & ~Permissions.Write; // Remove Write permission

            if (userPermissions.HasFlag(Permissions.Execute))
            {
                Console.WriteLine("User has Execute permission.");
            }
            else
            {
                Console.WriteLine("User does not have Execute permission.");

            }

        }
    }
}

[Flags]
 public enum Permissions
{
    None = 0,
    Read = 1,
    Write= 2,
    Delete = 4,
    Execute = 8
    
}   
