using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using System;
using AreaDivider; // <--- این خط اضافه شده است

[assembly: CommandClass(typeof(AreaDivider.Commands))]

namespace AreaDivider
{
    public class Commands
    {
        [CommandMethod("ADIV")]
        public void DivideArea()
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Editor ed = doc.Editor;

            try
            {
                // Show the form to the user
                AreaDividerForm form = new AreaDividerForm();
                Application.ShowModalDialog(form);

                // ... rest of the logic (if any)
            }
            catch (Exception ex)
            {
                ed.WriteMessage("\nError: " + ex.Message);
            }
        }
    }
}
