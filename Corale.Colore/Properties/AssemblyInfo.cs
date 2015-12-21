// ---------------------------------------------------------------------------------------
// <copyright file="AssemblyInfo.cs" company="Corale">
//     Copyright © 2015 by Adam Hellberg and Brandon Scott.
//
//     Permission is hereby granted, free of charge, to any person obtaining a copy of
//     this software and associated documentation files (the "Software"), to deal in
//     the Software without restriction, including without limitation the rights to
//     use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
//     of the Software, and to permit persons to whom the Software is furnished to do
//     so, subject to the following conditions:
//
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
//
//     THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//     IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//     AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
//     WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
//     CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
//     "Razer" is a trademark of Razer USA Ltd.
// </copyright>
// ---------------------------------------------------------------------------------------

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

/* General Information about an assembly is controlled through the following
 * set of attributes. Change these attribute values to modify the information
 * associated with an assembly.
 */

[assembly: AssemblyTitle("Colore")]
[assembly: AssemblyDescription("A C#/.NET library for interacting with Razer's Chroma SDK.")]
[assembly: AssemblyCompany("Corale")]
[assembly: AssemblyProduct("Colore")]
[assembly: AssemblyCopyright("Copyright © 2015 by Adam Hellberg and Brandon Scott.")]
[assembly: AssemblyTrademark("")]
[assembly: InternalsVisibleTo("Corale.Colore.Tests")]

#if DEBUG
#if WIN64

[assembly: AssemblyConfiguration("Debug (x64)")]

#elif WIN32

[assembly: AssemblyConfiguration("Debug (x86)")]

#else

[assembly: AssemblyConfiguration("Debug")]

#endif
#else
#if WIN64

[assembly: AssemblyConfiguration("Release (x64)")]

#elif WIN32

[assembly: AssemblyConfiguration("Release (x86)")]

#else

[assembly: AssemblyConfiguration("Release")]

#endif
#endif

[assembly: SecurityCritical]

/* Setting ComVisible to false makes the types in this assembly not visible
 * to COM components.  If you need to access a type in this assembly from
 * COM, set the ComVisible attribute to true on that type.
 */

[assembly: ComVisible(false)]

/* The following GUID is for the ID of the typelib if this project is exposed to COM */

[assembly: Guid("37548d1c-8a88-45bd-a732-a6d069799398")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyInformationalVersion("1.0.0")]
