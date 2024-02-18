using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactBookService.BusinessClasses.Common
{

    public class EInvoice_Node
    {
        public string Version { get; set; }
        public Trandtls TranDtls { get; set; }
        public Docdtls DocDtls { get; set; }
        public Sellerdtls SellerDtls { get; set; }
        public Buyerdtls BuyerDtls { get; set; }
        public Dispdtls DispDtls { get; set; }
        public Shipdtls ShipDtls { get; set; }
        public Itemlist[] ItemList { get; set; }
        public Valdtls ValDtls { get; set; }
        public Paydtls PayDtls { get; set; }
        public Refdtls RefDtls { get; set; }
        public Addldocdtl[] AddlDocDtls { get; set; }
        public Expdtls ExpDtls { get; set; }
    }

    public class Trandtls
    {
        public string TaxSch { get; set; }
        public string SupTyp { get; set; }
        public string RegRev { get; set; }
        public object EcmGstin { get; set; }
        public string IgstOnIntra { get; set; }
    }

    public class Docdtls
    {
        public string Typ { get; set; }
        public string No { get; set; }
        public string Dt { get; set; }
    }

    public class Sellerdtls
    {
        public string Gstin { get; set; }
        public string LglNm { get; set; }
        public string TrdNm { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string Loc { get; set; }
        public int Pin { get; set; }
        public string Stcd { get; set; }
        public string Ph { get; set; }
        public string Em { get; set; }
    }

    public class Buyerdtls
    {
        public string Gstin { get; set; }
        public string LglNm { get; set; }
        public string TrdNm { get; set; }
        public string Pos { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string Loc { get; set; }
        public int Pin { get; set; }
        public string Stcd { get; set; }
        public string Ph { get; set; }
        public string Em { get; set; }
    }

    public class Dispdtls
    {
        public string Nm { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string Loc { get; set; }
        public int Pin { get; set; }
        public string Stcd { get; set; }
    }

    public class Shipdtls
    {
        public string Gstin { get; set; }
        public string LglNm { get; set; }
        public string TrdNm { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string Loc { get; set; }
        public int Pin { get; set; }
        public string Stcd { get; set; }
    }

    public class Valdtls
    {
        public float AssVal { get; set; }
        public float CgstVal { get; set; }
        public float SgstVal { get; set; }
        public float IgstVal { get; set; }
        public float CesVal { get; set; }
        public float StCesVal { get; set; }
        public float Discount { get; set; }
        public float OthChrg { get; set; }
        public float RndOffAmt { get; set; }
        public float TotInvVal { get; set; }
        public float TotInvValFc { get; set; }
    }

    public class Paydtls
    {
        public string Nm { get; set; }
        public string Accdet { get; set; }
        public string Mode { get; set; }
        public string Fininsbr { get; set; }
        public string Payterm { get; set; }
        public string Payinstr { get; set; }
        public string Crtrn { get; set; }
        public string Dirdr { get; set; }
        public int Crday { get; set; }
        public float Paidamt { get; set; }
        public float Paymtdue { get; set; }
    }

    public class Refdtls
    {
        public string InvRm { get; set; }
        public Docperddtls DocPerdDtls { get; set; }
        public Precdocdtl[] PrecDocDtls { get; set; }
        public Contrdtl[] ContrDtls { get; set; }
    }

    public class Docperddtls
    {
        public string InvStDt { get; set; }
        public string InvEndDt { get; set; }
    }

    public class Precdocdtl
    {
        public string InvNo { get; set; }
        public string InvDt { get; set; }
        public string OthRefNo { get; set; }
    }

    public class Contrdtl
    {
        public string RecAdvRefr { get; set; }
        public string RecAdvDt { get; set; }
        public string Tendrefr { get; set; }
        public string Contrrefr { get; set; }
        public string Extrefr { get; set; }
        public string Projrefr { get; set; }
        public string Porefr { get; set; }
        public string PoRefDt { get; set; }
    }

    public class Expdtls
    {
        public string ShipBNo { get; set; }
        public string ShipBDt { get; set; }
        public string Port { get; set; }
        public string RefClm { get; set; }
        public string ForCur { get; set; }
        public string CntCode { get; set; }
        public object ExpDuty { get; set; }
    }

    public class Itemlist
    {
        public string SlNo { get; set; }
        public string PrdDesc { get; set; }
        public string IsServc { get; set; }
        public string HsnCd { get; set; }
        public string Barcde { get; set; }
        public float Qty { get; set; }
        public int FreeQty { get; set; }
        public string Unit { get; set; }
        public float UnitPrice { get; set; }
        public float TotAmt { get; set; }
        public float Discount { get; set; }
        public float PreTaxVal { get; set; }
        public float AssAmt { get; set; }
        public float GstRt { get; set; }
        public float IgstAmt { get; set; }
        public float CgstAmt { get; set; }
        public float SgstAmt { get; set; }
        public float CesRt { get; set; }
        public float CesAmt { get; set; }
        public int CesNonAdvlAmt { get; set; }
        public int StateCesRt { get; set; }
        public float StateCesAmt { get; set; }
        public int StateCesNonAdvlAmt { get; set; }
        public int OthChrg { get; set; }
        public float TotItemVal { get; set; }
        public string OrdLineRef { get; set; }
        public string OrgCntry { get; set; }
        public string PrdSlNo { get; set; }
        public Bchdtls BchDtls { get; set; }
        public Attribdtl[] AttribDtls { get; set; }
    }

    public class Bchdtls
    {
        public string Nm { get; set; }
        public string Expdt { get; set; }
        public string wrDt { get; set; }
    }

    public class Attribdtl
    {
        public string Nm { get; set; }
        public string Val { get; set; }
    }

    public class Addldocdtl
    {
        public string Url { get; set; }
        public string Docs { get; set; }
        public string Info { get; set; }
    }

}