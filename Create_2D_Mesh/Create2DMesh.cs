using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;

// In order to load the result of this wizard, you will also need to
// add the output bin/ folder of this project to the list of loaded
// folder in Grasshopper.
// You can use the _GrasshopperDeveloperSettings Rhino command for that.

namespace Create_2D_Mesh
{
    public class Create2DMesh : GH_Component
    {
        /// <summary>
        /// Each implementation of GH_Component must provide a public 
        /// constructor without any arguments.
        /// Category represents the Tab in which the component will appear, 
        /// Subcategory the panel. If you use non-existing tab or panel names, 
        /// new tabs/panels will automatically be created.
        /// </summary>
        public Create2DMesh()
          : base("Create_2D_Mesh", "MCreate",
              "Create Mesh from points",
              "Meshing", "Meshing")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddPointParameter("Input points", "ipts", "Provide Input Points", GH_ParamAccess.tree);
         
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddPointParameter("Output Mesh", "omesh", "Create Mesh from points", GH_ParamAccess.tree);
            pManager.AddPointParameter("Output node ID List", "olist", "Show node IDs", GH_ParamAccess.list);
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object can be used to retrieve data from input parameters and 
        /// to store data in output parameters.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            //Grasshopper.DataTree<Point3d> ipts = new Grasshopper.DataTree<Point3d>();
            Grasshopper.Kernel.Data.GH_Structure<Grasshopper.Kernel.Types.GH_Goo<Point3d>> ipts = new Grasshopper.Kernel.Data.GH_Structure<Grasshopper.Kernel.Types.GH_Goo<Point3d>>();
            
            List<Point3d> opts = new List<Point3d>();
            Mesh mesh1 = new Mesh();
            for(int i=0;i<ipts.Branches.Count;i++)
            {
                for(int j=0;j < ipts.Branches[i].Count;j++)
                {
                    opts.Add(ipts.Branches(i)[i]);

                }
            }
            DA.GetDataTree(0, out ipts);
            DA.SetDataList(1, opts);
        }

        /// <summary>
        /// Provides an Icon for every component that will be visible in the User Interface.
        /// Icons need to be 24x24 pixels.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                // You can add image files to your project resources and access them like this:
                //return Resources.IconForThisComponent;
                return null;
            }
        }

        /// <summary>
        /// Each component must have a unique Guid to identify it. 
        /// It is vital this Guid doesn't change otherwise old ghx files 
        /// that use the old ID will partially fail during loading.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("7d43003c-31fd-489f-89fe-f22d40f10b4d"); }
        }
    }
}
