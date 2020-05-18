using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using VBoxVdiManager.Model;

namespace VBoxVdiManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TypeDescriptor.AddAttributes(typeof(IList), new TypeConverterAttribute(typeof(ExpandableCollectionConverter)));
            TypeDescriptor.AddAttributes(typeof(StorageController), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(MediaRegistry), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(AttachedDevice), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            Application.Run(new Form1());
        }
    }
}
