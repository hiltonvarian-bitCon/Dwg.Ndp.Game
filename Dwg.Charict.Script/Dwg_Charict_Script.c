#include <Python.h>

/*
 * Implements an example function.
 */
PyDoc_STRVAR(Dwg_Charict_Script_example_doc, "example(obj, number)\
\
Example function");

PyObject *Dwg_Charict_Script_example(PyObject *self, PyObject *args, PyObject *kwargs) {
    /* Shared references that do not need Py_DECREF before returning. */
    PyObject *obj = NULL;
    int number = 0;

    /* Parse positional and keyword arguments */
    static char* keywords[] = { "obj", "number", NULL };
    if (!PyArg_ParseTupleAndKeywords(args, kwargs, "Oi", keywords, &obj, &number)) {
        return NULL;
    }

    /* Function implementation starts here */

    if (number < 0) {
        PyErr_SetObject(PyExc_ValueError, obj);
        return NULL;    /* return NULL indicates error */
    }

    Py_RETURN_NONE;
}

/*
 * List of functions to add to Dwg_Charict_Script in exec_Dwg_Charict_Script().
 */
static PyMethodDef Dwg_Charict_Script_functions[] = {
    { "example", (PyCFunction)Dwg_Charict_Script_example, METH_VARARGS | METH_KEYWORDS, Dwg_Charict_Script_example_doc },
    { NULL, NULL, 0, NULL } /* marks end of array */
};

/*
 * Initialize Dwg_Charict_Script. May be called multiple times, so avoid
 * using static state.
 */
int exec_Dwg_Charict_Script(PyObject *module) {
    PyModule_AddFunctions(module, Dwg_Charict_Script_functions);

    PyModule_AddStringConstant(module, "__author__", "Hilton Varian");
    PyModule_AddStringConstant(module, "__version__", "1.0.0");
    PyModule_AddIntConstant(module, "year", 2020);

    return 0; /* success */
}

/*
 * Documentation for Dwg_Charict_Script.
 */
PyDoc_STRVAR(Dwg_Charict_Script_doc, "The Dwg_Charict_Script module");


static PyModuleDef_Slot Dwg_Charict_Script_slots[] = {
    { Py_mod_exec, exec_Dwg_Charict_Script },
    { 0, NULL }
};

static PyModuleDef Dwg_Charict_Script_def = {
    PyModuleDef_HEAD_INIT,
    "Dwg_Charict_Script",
    Dwg_Charict_Script_doc,
    0,              /* m_size */
    NULL,           /* m_methods */
    Dwg_Charict_Script_slots,
    NULL,           /* m_traverse */
    NULL,           /* m_clear */
    NULL,           /* m_free */
};

PyMODINIT_FUNC PyInit_Dwg_Charict_Script() {
    return PyModuleDef_Init(&Dwg_Charict_Script_def);
}
