using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using UnmanageCodeLib;

namespace Lesson18.lesson2
{
    class SandboxingExample
    {
        public static void DoWork() {
            var domainSetup = new AppDomainSetup
            {
                ApplicationBase = Environment.CurrentDirectory
            };

            var permissionSet = new PermissionSet(PermissionState.None);//won't run a method from library
            //var permissionSet = new PermissionSet(PermissionState.Unrestricted);//will run a method from library
            permissionSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution));
            //permissionSet.AddPermission(new RegistryPermission(RegistryPermissionAccess.Read, Registry.CurrentConfig.Name));

            var domain = AppDomain.CreateDomain(
                "BADomain",
                null,
                domainSetup,
                permissionSet
                );

            var proxyPInvokeExample = (PInvokeExample)domain.CreateInstanceAndUnwrap(
                typeof(PInvokeExample).Assembly.FullName,
                typeof(PInvokeExample).FullName
                );

            proxyPInvokeExample.DoInvokeWork();

            AppDomain.Unload(domain);

        }
    }
}
