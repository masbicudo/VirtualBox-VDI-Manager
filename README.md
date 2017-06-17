# VirtualBox VDI Manager

This is a helper application that I use to rebuild VBox internal references to VDI files when moving VMs from one place to the other.

Moving VMs is a problem because VirtualBox behaves strangely when using relative paths inside `*.VBox` files. The solution is to use absolute paths, and change these paths when moving VM files.

Disclaimer
----------

Note that this is not production ready and should be used with caution. It creates a backup files automatically for any changed VBox files, and never changes VDI images, but I recomend you run it only on copies of files, not the original ones.

Licence
-------

Apache 2.0

This is a very permissive licence that only requires you to keep authoral references.