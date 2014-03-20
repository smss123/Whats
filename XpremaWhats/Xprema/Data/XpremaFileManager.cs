using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
 using System.IO;
namespace Xprema.Data
{
public     class XpremaFileManager  :IDisposable
    {


        private string Dir;
        private string DataFileName;
        private string FullPath;

        public Xdb  DB { get; set; }

        private bool WriteChanges()
        {
            try
            {
                  DB.GetChanges().WriteXml(FullPath);
            return true;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }
        private bool initlizationData(string Path)
        {
            try
            {
                DB.ReadXml(Path);
                Application.DoEvents();
                return true;
            }
            catch (Exception)
            {
                DB.WriteXmlSchema(Path);
                Application.DoEvents();
                DB.ReadXml(Path);
                return true;
            }
        }
        private bool ReadData(string path)
        {
            try
            {
                DB.ReadXml(path);
                Application.DoEvents();
                return true;
            }
            catch (Exception ex)
            {
                DB.WriteXmlSchema(FullPath);
                return true;
               // throw new Exception("Error in Reading Data File ");
            }
        }
        private bool WriteData(string Path)
        {
            try
            {
                DB.WriteXml(Path);
                Application.DoEvents();
                return true;
            }
            catch (Exception ex)
            {
                
                throw new Exception("Error in Write Data Please Review File");
            }
        }
        private   bool BackUpData(string from, string To)
        {
            try
            {
                if( ReadData(from)){
                   Application.DoEvents();
                 WriteData(To);
                 return true;
                }
                
                return false;
            }
            catch (Exception ex)
            {
                
                throw new Exception("Error in Back Up Data");
            }
        }
        private  bool RestoreData(string from,string To)
        {
            try
            {
               if( ReadData(from)) {
                Application.DoEvents();
                   WriteData(To);
                return true;

               } 


                return false;
                
            }
            catch (Exception ex)
            {
                
                throw new Exception("Error in Restoring Data");
            }
        }

        public void BackUp(string ToPath)
        {
            BackUpData(FullPath, ToPath);
        }
        public void Restore(string fromPath)
        {
            BackUpData(fromPath, FullPath);
        }
        public bool CommitData()
        {
            return WriteChanges();
        }

        public XpremaFileManager() {
     Dir = Application.StartupPath+"\\XpremaData";
      if (!Directory.Exists(Dir) )
	        {
            	Directory.CreateDirectory(Dir);	 
        	}
      DB = new Xdb();
      //------------------------- End Createing Directory
        DataFileName = "Data.Xprema";
        FullPath = Dir+"\\"+DataFileName;
        ReadData(FullPath);
        //--------------------- Read Data
    }


        ~XpremaFileManager() { }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
            
        }
    }
}
