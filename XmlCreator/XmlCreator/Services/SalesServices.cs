using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlCreator
{
    public class SalesServices
    {
        public string GetZCounter(string terminal,string connectionString)
        {
            var sql = $"SELECT [dbo].[fnGetZCountPerTerminal]('{terminal}')";
            var result = SCObjects.ReturnText(sql, connectionString);
            return result;
        }
        public PreEODModel GetPreEOD(string transitid, string connectionString)
        {
            var item = new PreEODModel();
            var cmd = new SqlCommand();
            cmd.CommandText = "[dbo].[spSalesPreEndOfDay]";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Id", transitid);
            var result = SCObjects.ExecGetData(cmd, connectionString);
            if (result != null)
            {
                if (result.Rows.Count > 0)
                {
                    item = new PreEODModel
                    {
                        Date = DateTime.Parse(result.Rows[0]["Date"].ToString()),
                        ORNumber = result.Rows[0]["ORNumber"].ToString(),
                        Void = result.Rows[0]["Void"].ToString(),
                        Cash = result.Rows[0]["Cash"].ToString(),
                        Credit = result.Rows[0]["Credit"].ToString(),
                        Charge = result.Rows[0]["Charge"].ToString(),
                        GiftCheck = result.Rows[0]["GiftCheck"].ToString(),
                        OtherTender = result.Rows[0]["OtherTender"].ToString(),
                        LineDiscount = result.Rows[0]["LineDiscount"].ToString(),
                        LineSenior = result.Rows[0]["LineSenior"].ToString(),
                        Evat = result.Rows[0]["Evat"].ToString(),
                        LinePWD = result.Rows[0]["LinePWD"].ToString(),
                        LineDiplomat = result.Rows[0]["LineDiplomat"].ToString(),
                        Subtotal = result.Rows[0]["Subtotal"].ToString(),
                        Discount = result.Rows[0]["Discount"].ToString(),
                        Senior = result.Rows[0]["Senior"].ToString(),
                        PWD = result.Rows[0]["PWD"].ToString(),
                        Diplomat = result.Rows[0]["Diplomat"].ToString(),
                        Vat = result.Rows[0]["Vat"].ToString(),
                        ExVat = result.Rows[0]["ExVat"].ToString(),
                        IncVat = result.Rows[0]["IncVat"].ToString(),
                        LocalTax = result.Rows[0]["LocalTax"].ToString(),
                        Amusement = result.Rows[0]["Amusement"].ToString(),
                        Service = result.Rows[0]["Service"].ToString(),
                        TaxSale = result.Rows[0]["TaxSale"].ToString(),
                        NoTaxSales = result.Rows[0]["NoTaxSales"].ToString(),
                        TaxExSales = result.Rows[0]["TaxExSales"].ToString(),
                        TaxIncSale = result.Rows[0]["TaxIncSale"].ToString(),
                        ZeroSale = result.Rows[0]["ZeroSale"].ToString(),
                        VatExempt = result.Rows[0]["VatExempt"].ToString(),
                        CustomerCount = result.Rows[0]["CustomerCount"].ToString(),
                        Gross = result.Rows[0]["Gross"].ToString(),
                        Refund = result.Rows[0]["Refund"].ToString(),
                        TaxRate = result.Rows[0]["TaxRate"].ToString(),
                        Posted = DateTime.Parse(result.Rows[0]["Posted"].ToString()),
                        Memo = result.Rows[0]["Memo"].ToString(),
                        LineSKU = result.Rows[0]["LineSKU"].ToString(),
                        LineQTY = result.Rows[0]["LineQTY"].ToString(),
                        LineUnitPrice = result.Rows[0]["LineUnitPrice"].ToString(),
                        LineDisc = result.Rows[0]["LineDisc"].ToString(),
                        LineSen = result.Rows[0]["LineSen"].ToString(),
                        LineP = result.Rows[0]["LineP"].ToString(),
                        LineDip = result.Rows[0]["LineDip"].ToString(),
                        LineTaxT = result.Rows[0]["LineTaxT"].ToString(),
                        LineT = result.Rows[0]["LineT"].ToString(),
                        LineMem = result.Rows[0]["LineMem"].ToString(),
                        ProdSKU = result.Rows[0]["ProdSKU"].ToString(),
                        ProdName = result.Rows[0]["ProdName"].ToString(),
                        ProdInventory = result.Rows[0]["ProdInventory"].ToString(),
                        ProdPrice = result.Rows[0]["ProdPrice"].ToString(),
                        ProdCategory = result.Rows[0]["ProdCategory"].ToString(),
                    };
                }
            }
            return item;
        }

        public IEnumerable<EndOfDayModel> GetEndOfDays(string terminal, string zreadingid, string connectionString)
        {
            var items = new List<EndOfDayModel>();
            var cmd = new SqlCommand();
            cmd.CommandText = "[dbo].[spEndOfDay]";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Terminal", terminal);
            cmd.Parameters.AddWithValue("ZReadingId", zreadingid);
            var result = SCObjects.ExecGetData(cmd, connectionString);

            if (result != null)
            {
                foreach (DataRow dr in result.Rows)
                {
                    var item = new EndOfDayModel
                    {
                        Date = DateTime.Parse(dr["Date"].ToString()),
                        Count = dr["Count"].ToString(),
                        PreviousNRGT = dr["PreviousNRGT"].ToString(),
                        NRGT = dr["NRGT"].ToString(),
                        PreviousTax = dr["PreviousTax"].ToString(),
                        NewTax = dr["NewTax"].ToString(),
                        PreviousTaxSale = dr["PreviousTaxSale"].ToString(),
                        NewTaxSale = dr["NewTaxSale"].ToString(),
                        PreviousNoTaxSale = dr["PreviousNoTaxSale"].ToString(),
                        NewNoTaxSale = dr["NewNoTaxSale"].ToString(),
                        OpenTime = DateTime.Parse(dr["OpenTime"].ToString()),
                        CloseTime = DateTime.Parse(dr["CloseTime"].ToString()),
                        Gross = dr["Gross"].ToString(),
                        Vat = dr["Vat"].ToString(),
                        LocalTax = dr["LocalTax"].ToString(),
                        Amusement = dr["Amusement"].ToString(),
                        Ewt = dr["Ewt"].ToString(),
                        TaxSale = dr["TaxSale"].ToString(),
                        NoTaxSale = dr["NoTaxSale"].ToString(),
                        ZeroSale = dr["ZeroSale"].ToString(),
                        VatExempt = dr["VatExempt"].ToString(),
                        Void = dr["Void"].ToString(),
                        VoidCount = dr["VoidCount"].ToString(),
                        Discount = dr["Discount"].ToString(),
                        DiscountCount = dr["DiscountCount"].ToString(),
                        Refund = dr["Refund"].ToString(),
                        RefundCount = dr["RefundCount"].ToString(),
                        Senior = dr["Senior"].ToString(),
                        SeniorCount = dr["SeniorCount"].ToString(),
                        Pwd = dr["Pwd"].ToString(),
                        PwdCount = dr["PwdCount"].ToString(),
                        Diplomat = dr["Diplomat"].ToString(),
                        DiplomatCount = dr["DiplomatCount"].ToString(),
                        Service = dr["Service"].ToString(),
                        ServiceCount = dr["ServiceCount"].ToString(),
                        ReceiptStart = dr["ReceiptStart"].ToString(),
                        ReceiptEnd = dr["ReceiptEnd"].ToString(),
                        TransactionCount = dr["TransactionCount"].ToString(),
                        Cash = dr["Cash"].ToString(),
                        CashCount = dr["CashCount"].ToString(),
                        Credit = dr["Credit"].ToString(),
                        CreditCount = dr["CreditCount"].ToString(),
                        Charge = dr["Charge"].ToString(),
                        ChargeCount = dr["ChargeCount"].ToString(),
                        GiftCheck = dr["GiftCheck"].ToString(),
                        GiftCheckCount = dr["GiftCheckCount"].ToString(),
                        OtherTender = dr["OtherTender"].ToString(),
                        OtherTenderCount = dr["OtherTenderCount"].ToString(),
                        trxReceiptNo = dr["trxReceiptNo"].ToString(),
                        trxVoid = dr["trxVoid"].ToString(),
                        trxCash = dr["trxCash"].ToString(),
                        trxCredit = dr["trxCredit"].ToString(),
                        trxCharge = dr["trxCharge"].ToString(),
                        trxGiftCheck = dr["trxGiftCheck"].ToString(),
                        trxOtherTender = dr["trxOtherTender"].ToString(),
                        trxLineDiscount = dr["trxLineDiscount"].ToString(),
                        trxLineSenior = dr["trxLineSenior"].ToString(),
                        trxEVat = dr["trxEVat"].ToString(),
                        trxLinePwd = dr["trxLinePwd"].ToString(),
                        trxLineDiplomat = dr["trxLineDiplomat"].ToString(),
                        trxSubtotal = dr["trxSubtotal"].ToString(),
                        trxDiscount = dr["trxDiscount"].ToString(),
                        trxSenior = dr["trxSenior"].ToString(),
                        trxPwd = dr["trxPwd"].ToString(),
                        trxDiplomat = dr["trxDiplomat"].ToString(),
                        trxVat = dr["trxVat"].ToString(),
                        trxExVat = dr["trxExVat"].ToString(),
                        trxIncVat = dr["trxIncVat"].ToString(),
                        trxLocalTax = dr["trxLocalTax"].ToString(),
                        trxAmusement = dr["trxAmusement"].ToString(),
                        trxEwt = dr["trxEwt"].ToString(),
                        trxService = dr["trxService"].ToString(),
                        trxTaxSale = dr["trxTaxSale"].ToString(),
                        trxNoTaxSale = dr["trxNoTaxSale"].ToString(),
                        trxTaxExSale = dr["trxTaxExSale"].ToString(),
                        trxTaxIncSale = dr["trxTaxIncSale"].ToString(),
                        trxZeroSale = dr["trxZeroSale"].ToString(),
                        trxVatExempt = dr["trxVatExempt"].ToString(),
                        trxCustomerCount = dr["trxCustomerCount"].ToString(),
                        trxGross = dr["trxGross"].ToString(),
                        trxRefund = dr["trxRefund"].ToString(),
                        trxTaxRate = dr["trxTaxRate"].ToString(),
                        trxPosted = DateTime.Parse(dr["trxPosted"].ToString()),
                        trxQuantity = dr["trxQuantity"].ToString(),
                        trxCreated = dr["trxCreated"].ToString(),
                        trxMemo = dr["trxMemo"].ToString(),
                        lSKU = dr["lSKU"].ToString(),
                        lQuantity = dr["lQuantity"].ToString(),
                        lUnitPrice = dr["lUnitPrice"].ToString(),
                        lDiscount = dr["lDiscount"].ToString(),
                        lSenior = dr["lSenior"].ToString(),
                        lPwd = dr["lPwd"].ToString(),
                        lDiplomat = dr["lDiplomat"].ToString(),
                        lTaxType = dr["lTaxType"].ToString(),
                        lTax = dr["lTax"].ToString(),
                        lMemo = dr["lMemo"].ToString(),
                        lTotal = dr["lTotal"].ToString(),
                        lChoiceType = dr["lChoiceType"].ToString(),
                        ProductSKU = dr["ProductSKU"].ToString(),
                        ProductName = dr["ProductName"].ToString(),
                        ProductInventory = dr["ProductInventory"].ToString(),
                        ProductPrice = dr["ProductPrice"].ToString(),
                        ProductCategory = dr["ProductCategory"].ToString(),
                    };
                    items.Add(item);
                }
            }

            return items;
        }
    }
}
