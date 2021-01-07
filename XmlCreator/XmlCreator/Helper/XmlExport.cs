using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XmlCreator
{
    public static class XmlExport
    {
        public static void ExportPreEndOfDay(string filepath,string key, string tenantid, string terminal, string transitid,string connectionString)
        {
            var services = new SalesServices();
            var item = services.GetPreEOD(transitid, connectionString);

            var name = "sales_preeod_" + tenantid + "_" + terminal + "_" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".xml";
            var filename = Path.Combine(filepath, name);
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");
            settings.CloseOutput = true;
            settings.OmitXmlDeclaration = true;
            settings.Encoding = Encoding.UTF8;
            using(XmlWriter xml = XmlWriter.Create(filename, settings))
            {
                xml.WriteStartElement("root");
                #region ID
                xml.WriteStartElement("id");
                xml.WriteElementString("tenantid", tenantid);
                xml.WriteElementString("key", key);
                xml.WriteElementString("tmid", terminal);
                xml.WriteElementString("doc", "SALES_PREEOD");
                xml.WriteFullEndElement(); 
                #endregion
                xml.WriteStartElement("sales");
                xml.WriteElementString("date", item.Date.ToString("yyyyMMdd"));

                xml.WriteStartElement("trx");
                xml.WriteElementString("receiptno", item.ORNumber);
                xml.WriteElementString("void", item.Void);
                xml.WriteElementString("cash",item.Cash);
                xml.WriteElementString("credit", item.Credit);
                xml.WriteElementString("charge", item.Charge);
                xml.WriteElementString("giftcheck", item.GiftCheck);
                xml.WriteElementString("othertender", item.OtherTender);
                xml.WriteElementString("linedisc", item.LineDiscount);
                xml.WriteElementString("linesenior", item.LineSenior);
                xml.WriteElementString("evat", item.Evat);
                xml.WriteElementString("linepwd", item.LinePWD);
                xml.WriteElementString("linediplomat", item.LineDiplomat);
                xml.WriteElementString("subtotal", item.Subtotal);
                xml.WriteElementString("disc", item.Discount);
                xml.WriteElementString("senior", item.Senior);
                xml.WriteElementString("pwd", item.PWD);
                xml.WriteElementString("diplomat", item.Diplomat);
                xml.WriteElementString("vat", item.Vat);
                xml.WriteElementString("exvat", item.ExVat);
                xml.WriteElementString("incvat", item.IncVat);
                xml.WriteElementString("localtax", item.LocalTax);
                xml.WriteElementString("amusement", item.Amusement);
                xml.WriteElementString("service", item.Service);
                xml.WriteElementString("taxsale", item.TaxSale);
                xml.WriteElementString("notaxsale", item.NoTaxSales);
                xml.WriteElementString("taxexsale", item.TaxExSales);
                xml.WriteElementString("taxincsale", item.TaxIncSale);
                xml.WriteElementString("zerosale", item.ZeroSale);
                xml.WriteElementString("vatexempt", item.VatExempt);
                xml.WriteElementString("customercount", item.CustomerCount);
                xml.WriteElementString("gross", item.Gross);
                xml.WriteElementString("refund", item.Refund);
                xml.WriteElementString("taxrate", item.TaxRate);
                xml.WriteElementString("posted", item.Posted.ToString("yyyyMMddhhmmss"));
                xml.WriteElementString("memo", " ");
                xml.WriteStartElement("line");
                xml.WriteElementString("sku", "0");
                xml.WriteElementString("qty", "0");
                xml.WriteElementString("unitprice", "0");
                xml.WriteElementString("disc", "0");
                xml.WriteElementString("senior", "0");
                xml.WriteElementString("pwd", "0");
                xml.WriteElementString("diplomat", "0");
                xml.WriteElementString("taxtype", "0");
                xml.WriteElementString("tax", "0");
                xml.WriteElementString("memo", " ");
                xml.WriteElementString("total", "0");
                xml.WriteFullEndElement();
                xml.WriteFullEndElement();
                xml.WriteFullEndElement();
                xml.WriteStartElement("master");
                xml.WriteStartElement("product");
                xml.WriteElementString("sku", "0");
                xml.WriteElementString("name", "0");
                xml.WriteElementString("inventory", "0");
                xml.WriteElementString("price", "0");
                xml.WriteElementString("category", "0");
                xml.WriteFullEndElement();
                xml.WriteFullEndElement();
                xml.WriteFullEndElement();
                xml.Flush();
            }
        }
        public static void ExportEndOfDay(string filepath,string key, string tenantid, string terminal,string zreadingid, string connectionString, string gateid)
        {
            SalesServices services = new SalesServices();
            var dt = new DataTable();
            var name = "sales_" + tenantid + "_" + terminal + "_" + services.GetZCounter(gateid,connectionString) + ".xml";
            var filename = Path.Combine(filepath, name);
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");
            settings.CloseOutput = true;
            settings.OmitXmlDeclaration = true;

            var items = services.GetEndOfDays(gateid, zreadingid, connectionString);
            var header = items.FirstOrDefault();

            using(XmlWriter xml = XmlWriter.Create(filename, settings))
            {
                xml.WriteStartElement("root"); //root
                #region ID
                xml.WriteStartElement("id"); //root
                xml.WriteElementString("tenantid", tenantid);
                xml.WriteElementString("key", key);
                xml.WriteElementString("tmid", terminal);
                xml.WriteElementString("doc", "SALES_EOD");
                xml.WriteFullEndElement(); //id 
                #endregion
                #region Sales

                xml.WriteStartElement("sales"); //root
                xml.WriteElementString("date", header.Date.ToString("yyyyMMdd"));
                xml.WriteElementString("zcounter", header.Count);
                xml.WriteElementString("previousnrgt", header.PreviousNRGT);
                xml.WriteElementString("nrgt", header.NRGT);
                xml.WriteElementString("previoustax", header.PreviousTax);
                xml.WriteElementString("newtax", header.NewTax);
                xml.WriteElementString("previoustaxsale", header.PreviousTaxSale);
                xml.WriteElementString("newtaxsale", header.NewTaxSale);
                xml.WriteElementString("previousnotaxsale", header.PreviousNoTaxSale);
                xml.WriteElementString("newnotaxsale", header.NewNoTaxSale);
                xml.WriteElementString("opentime", header.OpenTime.ToString("yyyyMMddhhmmss"));
                xml.WriteElementString("closetime", header.CloseTime.ToString("yyyyMMddhhmmss"));
                xml.WriteElementString("gross", header.Gross);
                xml.WriteElementString("vat", header.Vat);
                xml.WriteElementString("localtax", header.LocalTax);
                xml.WriteElementString("amusement", header.Amusement);
                xml.WriteElementString("ewt", header.Ewt);
                xml.WriteElementString("taxsale", header.Gross);
                xml.WriteElementString("notaxsale", header.NoTaxSale);
                xml.WriteElementString("zerosale", header.ZeroSale);
                xml.WriteElementString("vatexempt", header.VatExempt);
                xml.WriteElementString("void", header.Void);
                xml.WriteElementString("voidcnt", header.VoidCount);
                xml.WriteElementString("disc", header.Discount);
                xml.WriteElementString("disccnt", header.DiscountCount);
                xml.WriteElementString("refund", header.Refund);
                xml.WriteElementString("refundcnt", header.RefundCount);
                xml.WriteElementString("senior", header.Senior);
                xml.WriteElementString("seniorcnt", header.SeniorCount);
                xml.WriteElementString("pwd", header.Pwd);
                xml.WriteElementString("pwdcnt", header.PwdCount);
                xml.WriteElementString("diplomat", header.Diplomat);
                xml.WriteElementString("diplomatcnt", header.DiplomatCount);
                xml.WriteElementString("service", header.Service);
                xml.WriteElementString("servicecnt", header.ServiceCount);
                xml.WriteElementString("receiptstart", header.ReceiptStart);
                xml.WriteElementString("receiptend", header.ReceiptEnd);
                xml.WriteElementString("trxcnt", header.TransactionCount);
                xml.WriteElementString("cash", header.Cash);
                xml.WriteElementString("cashcnt", header.CashCount);
                xml.WriteElementString("credit", header.CreditCount);
                xml.WriteElementString("creditcnt", header.CreditCount);
                xml.WriteElementString("charge", header.Charge);
                xml.WriteElementString("chargecnt", header.ChargeCount);
                xml.WriteElementString("giftcheck", header.GiftCheck);
                xml.WriteElementString("giftcheckcnt", header.GiftCheckCount);
                xml.WriteElementString("othertender", header.OtherTender);
                xml.WriteElementString("othertendercnt", header.OtherTenderCount);
                #region TRX
                foreach (var item in items)
                {
                    xml.WriteStartElement("trx"); //transactions
                    xml.WriteElementString("receiptno", item.trxReceiptNo);
                    xml.WriteElementString("void", item.trxVoid);
                    xml.WriteElementString("cash", item.trxCash);
                    xml.WriteElementString("credit", item.trxCredit);
                    xml.WriteElementString("charge", item.trxCharge);
                    xml.WriteElementString("giftcheck", item.trxGiftCheck);
                    xml.WriteElementString("othertender", item.trxOtherTender);
                    xml.WriteElementString("linedisc", item.trxLineDiscount);
                    xml.WriteElementString("linesenior", item.trxLineSenior);
                    xml.WriteElementString("evat", item.trxEVat);
                    xml.WriteElementString("linepwd", item.trxLinePwd);
                    xml.WriteElementString("linediplomat", item.trxLineDiplomat);
                    xml.WriteElementString("subtotal", item.trxSubtotal);
                    xml.WriteElementString("disc", item.trxDiscount);
                    xml.WriteElementString("senior", item.trxSenior);
                    xml.WriteElementString("pwd", item.trxPwd);
                    xml.WriteElementString("diplomat", item.trxDiplomat);
                    xml.WriteElementString("vat", item.trxVat);
                    xml.WriteElementString("exvat", item.trxExVat);
                    xml.WriteElementString("incvat", item.trxIncVat);
                    xml.WriteElementString("localtax", item.trxLocalTax);
                    xml.WriteElementString("amusement", item.trxAmusement);
                    xml.WriteElementString("ewt", item.trxEwt);
                    xml.WriteElementString("service", item.trxService);
                    xml.WriteElementString("taxsale", item.trxGross);
                    xml.WriteElementString("notaxsale", item.trxNoTaxSale);
                    xml.WriteElementString("taxexsale", item.trxTaxExSale);
                    xml.WriteElementString("taxincsale", item.trxTaxIncSale);
                    xml.WriteElementString("zerosale", item.trxZeroSale);
                    xml.WriteElementString("vatexempt", item.trxVatExempt);
                    xml.WriteElementString("customercount", item.trxCustomerCount);
                    xml.WriteElementString("gross", item.trxGross);
                    xml.WriteElementString("refund", item.trxRefund);
                    xml.WriteElementString("taxrate", item.trxTaxRate);
                    xml.WriteElementString("posted", item.trxPosted.ToString("yyyyMMddhhmmss"));
                    xml.WriteElementString("qty", item.trxQuantity);
                    xml.WriteElementString("created", item.trxCreated);
                    xml.WriteElementString("memo", " ");

                    #region Line
                    xml.WriteStartElement("line"); //line
                    xml.WriteElementString("sku", item.lSKU);
                    xml.WriteElementString("qty", item.lQuantity);
                    xml.WriteElementString("unitprice", item.lUnitPrice);
                    xml.WriteElementString("disc", item.lDiscount);
                    xml.WriteElementString("senior", item.lSenior);
                    xml.WriteElementString("pwd", item.lPwd);
                    xml.WriteElementString("diplomat", item.lDiplomat);
                    xml.WriteElementString("taxtype", item.lTaxType);
                    xml.WriteElementString("tax", item.lTax);
                    xml.WriteElementString("memo", " ");
                    xml.WriteElementString("total", item.lTotal);
                    xml.WriteElementString("choicetype", " ");
                    xml.WriteFullEndElement(); //line
                    #endregion

                    xml.WriteFullEndElement(); //transactions
                }
                #endregion
                xml.WriteFullEndElement();
                #endregion
                #region Master
                xml.WriteStartElement("master");
                #region Product
                xml.WriteStartElement("product");
                xml.WriteElementString("sku", header.ProductSKU);
                xml.WriteElementString("name", header.ProductName);
                xml.WriteElementString("inventory", header.ProductInventory);
                xml.WriteElementString("price", header.ProductPrice);
                xml.WriteElementString("category", header.ProductCategory);
                xml.WriteFullEndElement();
                #endregion
                xml.WriteFullEndElement();
                #endregion
                xml.WriteFullEndElement(); //root
                xml.Flush();
            }
        }
    }
}
