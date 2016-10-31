using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace HF_CanvasTools
{
    public class HF_CanvasToolsInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "HFCanvasTools";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("5eb79082-b005-4639-b5a9-6d54311a1e3e");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "";
            }
        }
    }
}
