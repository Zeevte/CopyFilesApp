using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyFilesApp
{
    public class FilesUtilities
    {
       static public void CopyAllFiles(string sourcePath, string targetPath, Func<string, bool> showMessageBoxCallBack)
        {
            
            foreach (var filePath in Directory.GetFiles(sourcePath))
            {
                if (File.Exists(targetPath + @"\" + Path.GetFileName(filePath)))
                {
                    if (!showMessageBoxCallBack(targetPath + @"\" + Path.GetFileName(filePath)))
                    {
                        continue;
                    }
                }
                File.Copy(filePath, targetPath + @"\" + Path.GetFileName(filePath), true);
                
            } 
        }
        public bool ShowMessageBox(string filePath)
        {
            DialogResult result = MessageBox.Show("The file already exists, should we copy anyway and the existing file will be overwritten?", "File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }

    }
}
