# How to run

## Prerequisities

1. .NET 5 installed
2. Python 3.x installed (tested with 3.9)

## Setup

1. Install pythonnet `pip install pythonnet` (use `pip3` if your deault pip links to python 2.x). If it fails, run `export PKG_CONFIG_PATH=/Library/Frameworks/Mono.framework/Versions/Current/lib/pkgconfig` and try again.
2. Follow first 3 steps of [these instructions](https://github.com/pythonnet/pythonnet/wiki/Troubleshooting-on-Windows,-Linux,-and-OSX#installation-instructions-for-calling-python-from-net)
3. Add reference to `Python.Runtime.dll` via `Project` -> `Add Reference...` -> `.NET Assembly` tab -> `Browse...` and selecting Python.Runtime.dll that was just created.
It can be found in `pythonnet/src/runtime/obj/ReleaseMonoPY3/Python.Runtime.dll`
4. Update `PYTHONNET_PYDLL` in `Properties/launchSettings.json` to match your python installation if needed.

## Build and run using Visual Studio

# Running custom libs

Path to custom python librarries must be provided via `PYTHONPATH` evironment variable (see `Properties/launchSettings.json` for example).