using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlCreator
{
    public class EndOfDayModel
    {
        public DateTime Date { get; set; }
        public string Count { get; set; }
        public string PreviousNRGT { get; set; }
        public string NRGT { get; set; }
        public string PreviousTax { get; set; }
        public string NewTax { get; set; }
        public string PreviousTaxSale { get; set; }
        public string NewTaxSale { get; set; }
        public string PreviousNoTaxSale { get; set; }
        public string NewNoTaxSale { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public string Gross { get; set; }
        public string Vat { get; set; }
        public string LocalTax { get; set; }
        public string Amusement { get; set; }
        public string Ewt { get; set; }
        public string TaxSale { get; set; }
        public string NoTaxSale { get; set; }
        public string ZeroSale { get; set; }
        public string VatExempt { get; set; }
        public string Void { get; set; }
        public string VoidCount { get; set; }
        public string Discount { get; set; }
        public string DiscountCount { get; set; }
        public string Refund { get; set; }
        public string RefundCount { get; set; }
        public string Senior { get; set; }
        public string SeniorCount { get; set; }
        public string Pwd { get; set; }
        public string PwdCount { get; set; }
        public string Diplomat { get; set; }
        public string DiplomatCount { get; set; }
        public string Service { get; set; }
        public string ServiceCount { get; set; }
        public string ReceiptStart { get; set; }
        public string ReceiptEnd { get; set; }
        public string TransactionCount { get; set; }
        public string Cash { get; set; }
        public string CashCount { get; set; }
        public string Credit { get; set; }
        public string CreditCount { get; set; }
        public string Charge { get; set; }
        public string ChargeCount { get; set; }
        public string GiftCheck { get; set; }
        public string GiftCheckCount { get; set; }
        public string OtherTender { get; set; }
        public string OtherTenderCount { get; set; }
        public string trxReceiptNo { get; set; }
        public string trxVoid { get; set; }
        public string trxCash { get; set; }
        public string trxCredit { get; set; }
        public string trxCharge { get; set; }
        public string trxGiftCheck { get; set; }
        public string trxOtherTender { get; set; }
        public string trxLineDiscount { get; set; }
        public string trxLineSenior { get; set; }
        public string trxEVat { get; set; }
        public string trxLinePwd { get; set; }
        public string trxLineDiplomat { get; set; }
        public string trxSubtotal { get; set; }
        public string trxDiscount { get; set; }
        public string trxSenior { get; set; }
        public string trxPwd { get; set; }
        public string trxDiplomat { get; set; }
        public string trxVat { get; set; }
        public string trxExVat { get; set; }
        public string trxIncVat { get; set; }
        public string trxLocalTax { get; set; }
        public string trxAmusement { get; set; }
        public string trxEwt { get; set; }
        public string trxService { get; set; }
        public string trxTaxSale { get; set; }
        public string trxNoTaxSale { get; set; }
        public string trxTaxExSale { get; set; }
        public string trxTaxIncSale { get; set; }
        public string trxZeroSale { get; set; }
        public string trxVatExempt { get; set; }
        public string trxCustomerCount { get; set; }
        public string trxGross { get; set; }
        public string trxRefund { get; set; }
        public string trxTaxRate { get; set; }
        public DateTime trxPosted { get; set; }
        public string trxQuantity { get; set; }
        public string trxCreated { get; set; }
        public string trxMemo { get; set; }
        public string lSKU { get; set; }
        public string lQuantity { get; set; }
        public string lUnitPrice { get; set; }
        public string lDiscount { get; set; }
        public string lSenior { get; set; }
        public string lPwd { get; set; }
        public string lDiplomat { get; set; }
        public string lTaxType { get; set; }
        public string lTax { get; set; }
        public string lMemo { get; set; }
        public string lTotal { get; set; }
        public string lChoiceType { get; set; }
        public string ProductSKU { get; set; }
        public string ProductName { get; set; }
        public string ProductInventory { get; set; }
        public string ProductPrice { get; set; }
        public string ProductCategory { get; set; }
    }
}
