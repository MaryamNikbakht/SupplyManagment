using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1.DataAccess;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FinalProject1.Business
{
    [Serializable]
  //  public enum SpecialityTypeSoftware { SQLServer,Oracle, Eclips, Office,VisualStudio, VMware, PHP }
    public class Software:Product
    {
        private string softwareType;

        public string SoftwareType
        {
            get { return softwareType; }
            set { softwareType = value;}
        }

        public Software():base()
        {

        }

        public Software(double amountInStock, string softwareID, string productName, double unitPrice, string software,string p):
            base(amountInStock, softwareID,  productName, unitPrice,p)
        {
            this.softwareType = software;
        }

        public static void saveRecord_text(Software soft)
        {
            InventoryIO.saveRecord(soft);
        }

        public static List<Software> ListSoftware()
        {
            return InventoryIO.ListSoftware();
        }

        public static List<Software> Search_soft(string name)
        {
            return InventoryIO.SearchRecord_soft(name);
        }

        public static void delet_software(string del)
        {
            InventoryIO.deletLine_software(del);
        }

        public static void Delete_lastLineSoft()
        {
            InventoryIO.Delete_lastLine_soft();
        }

        public static bool ID_Uniq_soft(string id)
        {
            return InventoryIO.ID_Validation_Uniq_soft(id);
        }
    }

   
}
