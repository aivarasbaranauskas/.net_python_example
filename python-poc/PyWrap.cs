using System;
using System.Collections.Generic;
using Python.Runtime;

namespace python_poc
{
    public class PyWrap : IPyWrap
    {
        dynamic scr, np;

        public PyWrap()
        {
            PythonEngine.Initialize();
            PythonEngine.BeginAllowThreads();

            using (Py.GIL())
            {
                scr = Py.Import("script");
                np = Py.Import("numpy");
            }
        }

        ~PyWrap()
        {
            PythonEngine.Shutdown();
        }

        public string multiply(List<float> a, List<float> b)
        {
            using (Py.GIL())
            {
                return scr.multiply(np.array(a), np.array(b)).ToString();
            }
        }
    }
}
