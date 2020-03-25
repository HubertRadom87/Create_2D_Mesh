using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace Create_2D_Mesh
{
    public class Create_2D_MeshInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "Create2DMesh";
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
                return new Guid("593e0a3d-7b5a-42a9-81e9-849866c31bd5");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return " ";
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
