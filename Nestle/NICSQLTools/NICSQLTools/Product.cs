using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools
{
    public static class Product
    {
        public static string DefaultMaterialName
        {
            get { return "Auto Generate Material"; }
        }
        public static int UnknownProductBaseId
        {
            get { return 99999999; }
        }
        public static short UnknownMaterialTypeId
        {
            get { return 9999; }
        }
        public static short UnknownPriceChangesId
        {
            get { return 9999; }
        }
        public static short UnknownPricePointRangId
        {
            get { return 9999; }
        }
        public static short UnknownFlavorId
        {
            get { return 9999; }
        }
        public static short UnknownNPDSId
        {
            get { return 9999; }
        }
        public static short UnknownBrandId
        {
            get { return 9999; }
        }

        public static void CreateDefaultProduct(ref Data.dsData._0_4__Product_DetailsRow row)
        {
            row.Material_Name = DefaultMaterialName;
            row.Quin = 1;
            row.New_Qu = 1;
            row.Volum_Pice = 1;
            row.Vol = 1;
            row.Volum = 1;
        }
        public static Data.dsData._0_4__Product_DetailsRow GetProductRow(double MaterialNumber, Data.dsData._0_4__Product_DetailsDataTable tbl)
        {
            for (int i = 0; i < tbl.Count; i++)
            {
                if (tbl[i].Material_Number == MaterialNumber)
                    return tbl[i];
            }
            Data.dsData._0_4__Product_DetailsRow row = tbl.New_0_4__Product_DetailsRow();
            Product.CreateDefaultProduct(ref row);
            return row;
        }

        public static void RepairActiveCase()
        {
            throw new NotImplementedException("i should add here a sql statment to give every base product an active case product");
        }

    }
}
