Windows-API-Code-Pack-1.1
=========================

README
======

This is a fork of the Microsoft © Windows API Code Pack, based on a repository created by [Aybe](https://github.com/aybe/Windows-API-Code-Pack-1.1). Due to the lack of updates to the original package, this fork was created to include all open pull requests on the original repository.

NuGet packages (recommended)
----------------------------

https://www.nuget.org/packages/Microsoft-WindowsAPICodePack-Core/
https://www.nuget.org/packages/Microsoft-WindowsAPICodePack-Shell/
https://www.nuget.org/packages/Microsoft-WindowsAPICodePack-ShellExtensions/
https://www.nuget.org/packages/Microsoft-WindowsAPICodePack-ExtendedLinguisticServices/
https://www.nuget.org/packages/Microsoft-WindowsAPICodePack-Sensors/

Licence
-------

See [LICENSE](LICENSE) for the original licence (retrieved from [WebArchive](http://web.archive.org/web/20130717101016/http://archive.msdn.microsoft.com/WindowsAPICodePack/Project/License.aspx)). The library is not developed anymore by Microsoft and seems to have been left as 'free to use'. A clarification or update about the licence terms from Microsoft is welcome, however.
 
Release notes
-------------

See [CHANGELOG](CHANGELOG) for latest changes.

Bugs
----

When you submit a bug:

 - provide a short example code showing the bug
 - describe the expected behavior/result

Usage notes
-----------

**DirectX**

The DirectX package will work under x86 and x64 configuration platforms but not for AnyCPU platform (because there is no such platform for C++/CLI projects). Consequently, the package will purposefully fail the build and tell you why it did.

Note: package is here for historical reasons, it is highly recommended to use [SharpDX](http://sharpdx.org/) instead.