using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestleICSales.Managers
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

        public static void CreateDefaultProduct(ref DataSources.dsData.ProductRow row)
        {
            DateTime now = DataManager.defaultInstance.GetServerDatetime;

            row.MaterialName = DefaultMaterialName;
            row.ProductBaseId = UnknownProductBaseId;
            row.Quantity = 1;
            row.ActiveQuantity = 1;
            row.VolumPiece = 1;
            row.VolumCarton = 1;
            row.PriceChangesId = UnknownPriceChangesId;
            row.PricePointRangId = UnknownPricePointRangId;
            row.TradePriceCarton = 1;
            row.TradePricePiece = 1;
            row.ConsumerPriceCarton = 1;
            row.ConsumerPricePiece = 1;
            row.Pallet = 1;
            row.Split = 1;
            row.MaterialTypeId = UnknownMaterialTypeId;
            row.FlavorId = UnknownFlavorId;
            row.NPDSId = UnknownNPDSId;
            row.ValidDateStart = now;
            row.ValidDateEnd = new DateTime(9999, 12, 31);
            row.PricePoint = 1;
            row.PricePointLastYear = 1;
            row.PricePointOldYear = 1;
            row.datein = now;
            row.userin = UserManager.defaultInstance.UserInfo.UserID;
        }
        public static DataSources.dsData.ProductRow GetProductRow(int MaterialNumber, DataSources.dsData.ProductDataTable tbl)
        {
            DataSources.dsData.ProductRow row = tbl.FindByMaterialNumber(MaterialNumber);
            if (row == null)
            {
                DataSources.dsData.ProductRow ProRow = tbl.NewProductRow();
                Product.CreateDefaultProduct(ref ProRow);
                return ProRow;
            }
            else
                return row;
        }
        public static void RepairActiveCase()
        {
            throw new NotImplementedException("i should add here a sql statment to give every base product an active case product");
        }

    }
}
