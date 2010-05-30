using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

using SysGen.RBuild.Framework;

namespace TriStateTreeViewDemo
{
    public class RCWriter
    {
        RBuildModule m_Module = null;
        
        /// <summary>
        /// Creates a new instance of the <see cref="ResourceWriter"/> class.
        /// </summary>
        /// <param name="module"></param>
        public RCWriter(RBuildModule module)
        {
            //Set the module
            m_Module = module;
        }

        public RBuildModule Module
        {
            get { return m_Module; }
        }

        public void Generate()
        {
            //using (FileStream fs = new FileStream(Module.ResourceFile, FileMode.Append))
            //{
            //    using (StreamWriter objWriter = new StreamWriter(fs))
            //    {
            //        objWriter.WriteLine("; Autogenerated");
            //        objWriter.WriteLine("#include <windows.h>");
            //        objWriter.WriteLine();
            //        objWriter.WriteLine("LANGUAGE LANG_NEUTRAL, SUBLANG_NEUTRAL");
            //        objWriter.WriteLine();
            //        objWriter.WriteLine("#define REACTOS_STR_FILE_DESCRIPTION    \"{0}\0\"", Module.Description);
            //        objWriter.WriteLine("#define REACTOS_STR_INTERNAL_NAME       \"{0}\0\"", Module.Name);
            //        objWriter.WriteLine("#define REACTOS_STR_ORIGINAL_FILENAME   \"{0}\0\"", Module.CompiledFilename);
            //        objWriter.WriteLine();
            //        objWriter.WriteLine("LANGUAGE LANG_NEUTRAL, SUBLANG_NEUTRAL");
            //    }
            //}
        }
    }
}
