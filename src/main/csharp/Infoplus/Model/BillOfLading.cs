using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Infoplus.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class BillOfLading :  IEquatable<BillOfLading>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BillOfLading" /> class.
        /// Initializes a new instance of the <see cref="BillOfLading" />class.
        /// </summary>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="BolNo">BolNo (required).</param>
        /// <param name="BolDate">BolDate.</param>
        /// <param name="ShipFromName">ShipFromName.</param>
        /// <param name="ShipFromAddress">ShipFromAddress.</param>
        /// <param name="ShipFromCity">ShipFromCity.</param>
        /// <param name="ShipFromState">ShipFromState.</param>
        /// <param name="ShipFromZip">ShipFromZip.</param>
        /// <param name="Sid">Sid.</param>
        /// <param name="IsShipFromFOB">IsShipFromFOB (default to false).</param>
        /// <param name="ShipToName">ShipToName.</param>
        /// <param name="ShipToAddress">ShipToAddress.</param>
        /// <param name="ShipToCity">ShipToCity.</param>
        /// <param name="ShipToState">ShipToState.</param>
        /// <param name="ShipToZip">ShipToZip.</param>
        /// <param name="ShipToLocationNo">ShipToLocationNo.</param>
        /// <param name="Cid">Cid.</param>
        /// <param name="IsShipToFOB">IsShipToFOB (default to false).</param>
        /// <param name="BillToName">BillToName.</param>
        /// <param name="BillToAddress">BillToAddress.</param>
        /// <param name="BillToCity">BillToCity.</param>
        /// <param name="BillToState">BillToState.</param>
        /// <param name="BillToZip">BillToZip.</param>
        /// <param name="IsTrailerLoadedByShipper">IsTrailerLoadedByShipper (default to false).</param>
        /// <param name="ByDriver">ByDriver (default to false).</param>
        /// <param name="CodAmount">CodAmount.</param>
        /// <param name="FeeTermsCollect">FeeTermsCollect (default to false).</param>
        /// <param name="FeeTermsPrepaid">FeeTermsPrepaid (default to false).</param>
        /// <param name="CustomerCheckAcceptable">CustomerCheckAcceptable (default to false).</param>
        /// <param name="CarrierName">CarrierName.</param>
        /// <param name="TrailerNo">TrailerNo.</param>
        /// <param name="SealNo">SealNo.</param>
        /// <param name="Scac">Scac.</param>
        /// <param name="ProNo">ProNo.</param>
        /// <param name="Prepaid">Prepaid (default to false).</param>
        /// <param name="Collect">Collect (default to false).</param>
        /// <param name="ThirdParty">ThirdParty (default to false).</param>
        /// <param name="IsThisAMasterBOL">IsThisAMasterBOL (default to false).</param>
        /// <param name="MasterBOLId">MasterBOLId.</param>
        /// <param name="IsFreightCountedByShipper">IsFreightCountedByShipper (default to false).</param>
        /// <param name="ByDriverPallets">ByDriverPallets (default to false).</param>
        /// <param name="ByDriverPieces">ByDriverPieces (default to false).</param>
        /// <param name="SpecialInstructions">SpecialInstructions.</param>
        /// <param name="OrderInfoLines">OrderInfoLines.</param>
        /// <param name="CarrierInfoLines">CarrierInfoLines.</param>

        public BillOfLading(int? LobId = null, string BolNo = null, DateTime? BolDate = null, string ShipFromName = null, string ShipFromAddress = null, string ShipFromCity = null, string ShipFromState = null, string ShipFromZip = null, string Sid = null, bool? IsShipFromFOB = null, string ShipToName = null, string ShipToAddress = null, string ShipToCity = null, string ShipToState = null, string ShipToZip = null, string ShipToLocationNo = null, string Cid = null, bool? IsShipToFOB = null, string BillToName = null, string BillToAddress = null, string BillToCity = null, string BillToState = null, string BillToZip = null, bool? IsTrailerLoadedByShipper = null, bool? ByDriver = null, double? CodAmount = null, bool? FeeTermsCollect = null, bool? FeeTermsPrepaid = null, bool? CustomerCheckAcceptable = null, string CarrierName = null, string TrailerNo = null, string SealNo = null, string Scac = null, string ProNo = null, bool? Prepaid = null, bool? Collect = null, bool? ThirdParty = null, bool? IsThisAMasterBOL = null, int? MasterBOLId = null, bool? IsFreightCountedByShipper = null, bool? ByDriverPallets = null, bool? ByDriverPieces = null, string SpecialInstructions = null, List<BillOfLadingOrderInfoLine> OrderInfoLines = null, List<BillOfLadingCarrierInfoLine> CarrierInfoLines = null)
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for BillOfLading and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "BolNo" is required (not null)
            if (BolNo == null)
            {
                throw new InvalidDataException("BolNo is a required property for BillOfLading and cannot be null");
            }
            else
            {
                this.BolNo = BolNo;
            }
            this.BolDate = BolDate;
            this.ShipFromName = ShipFromName;
            this.ShipFromAddress = ShipFromAddress;
            this.ShipFromCity = ShipFromCity;
            this.ShipFromState = ShipFromState;
            this.ShipFromZip = ShipFromZip;
            this.Sid = Sid;
            // use default value if no "IsShipFromFOB" provided
            if (IsShipFromFOB == null)
            {
                this.IsShipFromFOB = false;
            }
            else
            {
                this.IsShipFromFOB = IsShipFromFOB;
            }
            this.ShipToName = ShipToName;
            this.ShipToAddress = ShipToAddress;
            this.ShipToCity = ShipToCity;
            this.ShipToState = ShipToState;
            this.ShipToZip = ShipToZip;
            this.ShipToLocationNo = ShipToLocationNo;
            this.Cid = Cid;
            // use default value if no "IsShipToFOB" provided
            if (IsShipToFOB == null)
            {
                this.IsShipToFOB = false;
            }
            else
            {
                this.IsShipToFOB = IsShipToFOB;
            }
            this.BillToName = BillToName;
            this.BillToAddress = BillToAddress;
            this.BillToCity = BillToCity;
            this.BillToState = BillToState;
            this.BillToZip = BillToZip;
            // use default value if no "IsTrailerLoadedByShipper" provided
            if (IsTrailerLoadedByShipper == null)
            {
                this.IsTrailerLoadedByShipper = false;
            }
            else
            {
                this.IsTrailerLoadedByShipper = IsTrailerLoadedByShipper;
            }
            // use default value if no "ByDriver" provided
            if (ByDriver == null)
            {
                this.ByDriver = false;
            }
            else
            {
                this.ByDriver = ByDriver;
            }
            this.CodAmount = CodAmount;
            // use default value if no "FeeTermsCollect" provided
            if (FeeTermsCollect == null)
            {
                this.FeeTermsCollect = false;
            }
            else
            {
                this.FeeTermsCollect = FeeTermsCollect;
            }
            // use default value if no "FeeTermsPrepaid" provided
            if (FeeTermsPrepaid == null)
            {
                this.FeeTermsPrepaid = false;
            }
            else
            {
                this.FeeTermsPrepaid = FeeTermsPrepaid;
            }
            // use default value if no "CustomerCheckAcceptable" provided
            if (CustomerCheckAcceptable == null)
            {
                this.CustomerCheckAcceptable = false;
            }
            else
            {
                this.CustomerCheckAcceptable = CustomerCheckAcceptable;
            }
            this.CarrierName = CarrierName;
            this.TrailerNo = TrailerNo;
            this.SealNo = SealNo;
            this.Scac = Scac;
            this.ProNo = ProNo;
            // use default value if no "Prepaid" provided
            if (Prepaid == null)
            {
                this.Prepaid = false;
            }
            else
            {
                this.Prepaid = Prepaid;
            }
            // use default value if no "Collect" provided
            if (Collect == null)
            {
                this.Collect = false;
            }
            else
            {
                this.Collect = Collect;
            }
            // use default value if no "ThirdParty" provided
            if (ThirdParty == null)
            {
                this.ThirdParty = false;
            }
            else
            {
                this.ThirdParty = ThirdParty;
            }
            // use default value if no "IsThisAMasterBOL" provided
            if (IsThisAMasterBOL == null)
            {
                this.IsThisAMasterBOL = false;
            }
            else
            {
                this.IsThisAMasterBOL = IsThisAMasterBOL;
            }
            this.MasterBOLId = MasterBOLId;
            // use default value if no "IsFreightCountedByShipper" provided
            if (IsFreightCountedByShipper == null)
            {
                this.IsFreightCountedByShipper = false;
            }
            else
            {
                this.IsFreightCountedByShipper = IsFreightCountedByShipper;
            }
            // use default value if no "ByDriverPallets" provided
            if (ByDriverPallets == null)
            {
                this.ByDriverPallets = false;
            }
            else
            {
                this.ByDriverPallets = ByDriverPallets;
            }
            // use default value if no "ByDriverPieces" provided
            if (ByDriverPieces == null)
            {
                this.ByDriverPieces = false;
            }
            else
            {
                this.ByDriverPieces = ByDriverPieces;
            }
            this.SpecialInstructions = SpecialInstructions;
            this.OrderInfoLines = OrderInfoLines;
            this.CarrierInfoLines = CarrierInfoLines;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets ModifyDate
        /// </summary>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }
    
        /// <summary>
        /// Gets or Sets BolNo
        /// </summary>
        [DataMember(Name="bolNo", EmitDefaultValue=false)]
        public string BolNo { get; set; }
    
        /// <summary>
        /// Gets or Sets BolDate
        /// </summary>
        [DataMember(Name="bolDate", EmitDefaultValue=false)]
        public DateTime? BolDate { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipFromName
        /// </summary>
        [DataMember(Name="shipFromName", EmitDefaultValue=false)]
        public string ShipFromName { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipFromAddress
        /// </summary>
        [DataMember(Name="shipFromAddress", EmitDefaultValue=false)]
        public string ShipFromAddress { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipFromCity
        /// </summary>
        [DataMember(Name="shipFromCity", EmitDefaultValue=false)]
        public string ShipFromCity { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipFromState
        /// </summary>
        [DataMember(Name="shipFromState", EmitDefaultValue=false)]
        public string ShipFromState { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipFromZip
        /// </summary>
        [DataMember(Name="shipFromZip", EmitDefaultValue=false)]
        public string ShipFromZip { get; set; }
    
        /// <summary>
        /// Gets or Sets Sid
        /// </summary>
        [DataMember(Name="sid", EmitDefaultValue=false)]
        public string Sid { get; set; }
    
        /// <summary>
        /// Gets or Sets IsShipFromFOB
        /// </summary>
        [DataMember(Name="isShipFromFOB", EmitDefaultValue=false)]
        public bool? IsShipFromFOB { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipToName
        /// </summary>
        [DataMember(Name="shipToName", EmitDefaultValue=false)]
        public string ShipToName { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipToAddress
        /// </summary>
        [DataMember(Name="shipToAddress", EmitDefaultValue=false)]
        public string ShipToAddress { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipToCity
        /// </summary>
        [DataMember(Name="shipToCity", EmitDefaultValue=false)]
        public string ShipToCity { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipToState
        /// </summary>
        [DataMember(Name="shipToState", EmitDefaultValue=false)]
        public string ShipToState { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipToZip
        /// </summary>
        [DataMember(Name="shipToZip", EmitDefaultValue=false)]
        public string ShipToZip { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipToLocationNo
        /// </summary>
        [DataMember(Name="shipToLocationNo", EmitDefaultValue=false)]
        public string ShipToLocationNo { get; set; }
    
        /// <summary>
        /// Gets or Sets Cid
        /// </summary>
        [DataMember(Name="cid", EmitDefaultValue=false)]
        public string Cid { get; set; }
    
        /// <summary>
        /// Gets or Sets IsShipToFOB
        /// </summary>
        [DataMember(Name="isShipToFOB", EmitDefaultValue=false)]
        public bool? IsShipToFOB { get; set; }
    
        /// <summary>
        /// Gets or Sets BillToName
        /// </summary>
        [DataMember(Name="billToName", EmitDefaultValue=false)]
        public string BillToName { get; set; }
    
        /// <summary>
        /// Gets or Sets BillToAddress
        /// </summary>
        [DataMember(Name="billToAddress", EmitDefaultValue=false)]
        public string BillToAddress { get; set; }
    
        /// <summary>
        /// Gets or Sets BillToCity
        /// </summary>
        [DataMember(Name="billToCity", EmitDefaultValue=false)]
        public string BillToCity { get; set; }
    
        /// <summary>
        /// Gets or Sets BillToState
        /// </summary>
        [DataMember(Name="billToState", EmitDefaultValue=false)]
        public string BillToState { get; set; }
    
        /// <summary>
        /// Gets or Sets BillToZip
        /// </summary>
        [DataMember(Name="billToZip", EmitDefaultValue=false)]
        public string BillToZip { get; set; }
    
        /// <summary>
        /// Gets or Sets IsTrailerLoadedByShipper
        /// </summary>
        [DataMember(Name="isTrailerLoadedByShipper", EmitDefaultValue=false)]
        public bool? IsTrailerLoadedByShipper { get; set; }
    
        /// <summary>
        /// Gets or Sets ByDriver
        /// </summary>
        [DataMember(Name="byDriver", EmitDefaultValue=false)]
        public bool? ByDriver { get; set; }
    
        /// <summary>
        /// Gets or Sets CodAmount
        /// </summary>
        [DataMember(Name="codAmount", EmitDefaultValue=false)]
        public double? CodAmount { get; set; }
    
        /// <summary>
        /// Gets or Sets FeeTermsCollect
        /// </summary>
        [DataMember(Name="feeTermsCollect", EmitDefaultValue=false)]
        public bool? FeeTermsCollect { get; set; }
    
        /// <summary>
        /// Gets or Sets FeeTermsPrepaid
        /// </summary>
        [DataMember(Name="feeTermsPrepaid", EmitDefaultValue=false)]
        public bool? FeeTermsPrepaid { get; set; }
    
        /// <summary>
        /// Gets or Sets CustomerCheckAcceptable
        /// </summary>
        [DataMember(Name="customerCheckAcceptable", EmitDefaultValue=false)]
        public bool? CustomerCheckAcceptable { get; set; }
    
        /// <summary>
        /// Gets or Sets CarrierName
        /// </summary>
        [DataMember(Name="carrierName", EmitDefaultValue=false)]
        public string CarrierName { get; set; }
    
        /// <summary>
        /// Gets or Sets TrailerNo
        /// </summary>
        [DataMember(Name="trailerNo", EmitDefaultValue=false)]
        public string TrailerNo { get; set; }
    
        /// <summary>
        /// Gets or Sets SealNo
        /// </summary>
        [DataMember(Name="sealNo", EmitDefaultValue=false)]
        public string SealNo { get; set; }
    
        /// <summary>
        /// Gets or Sets Scac
        /// </summary>
        [DataMember(Name="scac", EmitDefaultValue=false)]
        public string Scac { get; set; }
    
        /// <summary>
        /// Gets or Sets ProNo
        /// </summary>
        [DataMember(Name="proNo", EmitDefaultValue=false)]
        public string ProNo { get; set; }
    
        /// <summary>
        /// Gets or Sets Prepaid
        /// </summary>
        [DataMember(Name="prepaid", EmitDefaultValue=false)]
        public bool? Prepaid { get; set; }
    
        /// <summary>
        /// Gets or Sets Collect
        /// </summary>
        [DataMember(Name="collect", EmitDefaultValue=false)]
        public bool? Collect { get; set; }
    
        /// <summary>
        /// Gets or Sets ThirdParty
        /// </summary>
        [DataMember(Name="thirdParty", EmitDefaultValue=false)]
        public bool? ThirdParty { get; set; }
    
        /// <summary>
        /// Gets or Sets IsThisAMasterBOL
        /// </summary>
        [DataMember(Name="isThisAMasterBOL", EmitDefaultValue=false)]
        public bool? IsThisAMasterBOL { get; set; }
    
        /// <summary>
        /// Gets or Sets MasterBOLId
        /// </summary>
        [DataMember(Name="masterBOLId", EmitDefaultValue=false)]
        public int? MasterBOLId { get; set; }
    
        /// <summary>
        /// Gets or Sets IsFreightCountedByShipper
        /// </summary>
        [DataMember(Name="isFreightCountedByShipper", EmitDefaultValue=false)]
        public bool? IsFreightCountedByShipper { get; set; }
    
        /// <summary>
        /// Gets or Sets ByDriverPallets
        /// </summary>
        [DataMember(Name="byDriverPallets", EmitDefaultValue=false)]
        public bool? ByDriverPallets { get; set; }
    
        /// <summary>
        /// Gets or Sets ByDriverPieces
        /// </summary>
        [DataMember(Name="byDriverPieces", EmitDefaultValue=false)]
        public bool? ByDriverPieces { get; set; }
    
        /// <summary>
        /// Gets or Sets SpecialInstructions
        /// </summary>
        [DataMember(Name="specialInstructions", EmitDefaultValue=false)]
        public string SpecialInstructions { get; set; }
    
        /// <summary>
        /// Gets or Sets OrderInfoLines
        /// </summary>
        [DataMember(Name="orderInfoLines", EmitDefaultValue=false)]
        public List<BillOfLadingOrderInfoLine> OrderInfoLines { get; set; }
    
        /// <summary>
        /// Gets or Sets CarrierInfoLines
        /// </summary>
        [DataMember(Name="carrierInfoLines", EmitDefaultValue=false)]
        public List<BillOfLadingCarrierInfoLine> CarrierInfoLines { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillOfLading {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  BolNo: ").Append(BolNo).Append("\n");
            sb.Append("  BolDate: ").Append(BolDate).Append("\n");
            sb.Append("  ShipFromName: ").Append(ShipFromName).Append("\n");
            sb.Append("  ShipFromAddress: ").Append(ShipFromAddress).Append("\n");
            sb.Append("  ShipFromCity: ").Append(ShipFromCity).Append("\n");
            sb.Append("  ShipFromState: ").Append(ShipFromState).Append("\n");
            sb.Append("  ShipFromZip: ").Append(ShipFromZip).Append("\n");
            sb.Append("  Sid: ").Append(Sid).Append("\n");
            sb.Append("  IsShipFromFOB: ").Append(IsShipFromFOB).Append("\n");
            sb.Append("  ShipToName: ").Append(ShipToName).Append("\n");
            sb.Append("  ShipToAddress: ").Append(ShipToAddress).Append("\n");
            sb.Append("  ShipToCity: ").Append(ShipToCity).Append("\n");
            sb.Append("  ShipToState: ").Append(ShipToState).Append("\n");
            sb.Append("  ShipToZip: ").Append(ShipToZip).Append("\n");
            sb.Append("  ShipToLocationNo: ").Append(ShipToLocationNo).Append("\n");
            sb.Append("  Cid: ").Append(Cid).Append("\n");
            sb.Append("  IsShipToFOB: ").Append(IsShipToFOB).Append("\n");
            sb.Append("  BillToName: ").Append(BillToName).Append("\n");
            sb.Append("  BillToAddress: ").Append(BillToAddress).Append("\n");
            sb.Append("  BillToCity: ").Append(BillToCity).Append("\n");
            sb.Append("  BillToState: ").Append(BillToState).Append("\n");
            sb.Append("  BillToZip: ").Append(BillToZip).Append("\n");
            sb.Append("  IsTrailerLoadedByShipper: ").Append(IsTrailerLoadedByShipper).Append("\n");
            sb.Append("  ByDriver: ").Append(ByDriver).Append("\n");
            sb.Append("  CodAmount: ").Append(CodAmount).Append("\n");
            sb.Append("  FeeTermsCollect: ").Append(FeeTermsCollect).Append("\n");
            sb.Append("  FeeTermsPrepaid: ").Append(FeeTermsPrepaid).Append("\n");
            sb.Append("  CustomerCheckAcceptable: ").Append(CustomerCheckAcceptable).Append("\n");
            sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
            sb.Append("  TrailerNo: ").Append(TrailerNo).Append("\n");
            sb.Append("  SealNo: ").Append(SealNo).Append("\n");
            sb.Append("  Scac: ").Append(Scac).Append("\n");
            sb.Append("  ProNo: ").Append(ProNo).Append("\n");
            sb.Append("  Prepaid: ").Append(Prepaid).Append("\n");
            sb.Append("  Collect: ").Append(Collect).Append("\n");
            sb.Append("  ThirdParty: ").Append(ThirdParty).Append("\n");
            sb.Append("  IsThisAMasterBOL: ").Append(IsThisAMasterBOL).Append("\n");
            sb.Append("  MasterBOLId: ").Append(MasterBOLId).Append("\n");
            sb.Append("  IsFreightCountedByShipper: ").Append(IsFreightCountedByShipper).Append("\n");
            sb.Append("  ByDriverPallets: ").Append(ByDriverPallets).Append("\n");
            sb.Append("  ByDriverPieces: ").Append(ByDriverPieces).Append("\n");
            sb.Append("  SpecialInstructions: ").Append(SpecialInstructions).Append("\n");
            sb.Append("  OrderInfoLines: ").Append(OrderInfoLines).Append("\n");
            sb.Append("  CarrierInfoLines: ").Append(CarrierInfoLines).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as BillOfLading);
        }

        /// <summary>
        /// Returns true if BillOfLading instances are equal
        /// </summary>
        /// <param name="other">Instance of BillOfLading to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillOfLading other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.CreateDate == other.CreateDate ||
                    this.CreateDate != null &&
                    this.CreateDate.Equals(other.CreateDate)
                ) && 
                (
                    this.ModifyDate == other.ModifyDate ||
                    this.ModifyDate != null &&
                    this.ModifyDate.Equals(other.ModifyDate)
                ) && 
                (
                    this.LobId == other.LobId ||
                    this.LobId != null &&
                    this.LobId.Equals(other.LobId)
                ) && 
                (
                    this.BolNo == other.BolNo ||
                    this.BolNo != null &&
                    this.BolNo.Equals(other.BolNo)
                ) && 
                (
                    this.BolDate == other.BolDate ||
                    this.BolDate != null &&
                    this.BolDate.Equals(other.BolDate)
                ) && 
                (
                    this.ShipFromName == other.ShipFromName ||
                    this.ShipFromName != null &&
                    this.ShipFromName.Equals(other.ShipFromName)
                ) && 
                (
                    this.ShipFromAddress == other.ShipFromAddress ||
                    this.ShipFromAddress != null &&
                    this.ShipFromAddress.Equals(other.ShipFromAddress)
                ) && 
                (
                    this.ShipFromCity == other.ShipFromCity ||
                    this.ShipFromCity != null &&
                    this.ShipFromCity.Equals(other.ShipFromCity)
                ) && 
                (
                    this.ShipFromState == other.ShipFromState ||
                    this.ShipFromState != null &&
                    this.ShipFromState.Equals(other.ShipFromState)
                ) && 
                (
                    this.ShipFromZip == other.ShipFromZip ||
                    this.ShipFromZip != null &&
                    this.ShipFromZip.Equals(other.ShipFromZip)
                ) && 
                (
                    this.Sid == other.Sid ||
                    this.Sid != null &&
                    this.Sid.Equals(other.Sid)
                ) && 
                (
                    this.IsShipFromFOB == other.IsShipFromFOB ||
                    this.IsShipFromFOB != null &&
                    this.IsShipFromFOB.Equals(other.IsShipFromFOB)
                ) && 
                (
                    this.ShipToName == other.ShipToName ||
                    this.ShipToName != null &&
                    this.ShipToName.Equals(other.ShipToName)
                ) && 
                (
                    this.ShipToAddress == other.ShipToAddress ||
                    this.ShipToAddress != null &&
                    this.ShipToAddress.Equals(other.ShipToAddress)
                ) && 
                (
                    this.ShipToCity == other.ShipToCity ||
                    this.ShipToCity != null &&
                    this.ShipToCity.Equals(other.ShipToCity)
                ) && 
                (
                    this.ShipToState == other.ShipToState ||
                    this.ShipToState != null &&
                    this.ShipToState.Equals(other.ShipToState)
                ) && 
                (
                    this.ShipToZip == other.ShipToZip ||
                    this.ShipToZip != null &&
                    this.ShipToZip.Equals(other.ShipToZip)
                ) && 
                (
                    this.ShipToLocationNo == other.ShipToLocationNo ||
                    this.ShipToLocationNo != null &&
                    this.ShipToLocationNo.Equals(other.ShipToLocationNo)
                ) && 
                (
                    this.Cid == other.Cid ||
                    this.Cid != null &&
                    this.Cid.Equals(other.Cid)
                ) && 
                (
                    this.IsShipToFOB == other.IsShipToFOB ||
                    this.IsShipToFOB != null &&
                    this.IsShipToFOB.Equals(other.IsShipToFOB)
                ) && 
                (
                    this.BillToName == other.BillToName ||
                    this.BillToName != null &&
                    this.BillToName.Equals(other.BillToName)
                ) && 
                (
                    this.BillToAddress == other.BillToAddress ||
                    this.BillToAddress != null &&
                    this.BillToAddress.Equals(other.BillToAddress)
                ) && 
                (
                    this.BillToCity == other.BillToCity ||
                    this.BillToCity != null &&
                    this.BillToCity.Equals(other.BillToCity)
                ) && 
                (
                    this.BillToState == other.BillToState ||
                    this.BillToState != null &&
                    this.BillToState.Equals(other.BillToState)
                ) && 
                (
                    this.BillToZip == other.BillToZip ||
                    this.BillToZip != null &&
                    this.BillToZip.Equals(other.BillToZip)
                ) && 
                (
                    this.IsTrailerLoadedByShipper == other.IsTrailerLoadedByShipper ||
                    this.IsTrailerLoadedByShipper != null &&
                    this.IsTrailerLoadedByShipper.Equals(other.IsTrailerLoadedByShipper)
                ) && 
                (
                    this.ByDriver == other.ByDriver ||
                    this.ByDriver != null &&
                    this.ByDriver.Equals(other.ByDriver)
                ) && 
                (
                    this.CodAmount == other.CodAmount ||
                    this.CodAmount != null &&
                    this.CodAmount.Equals(other.CodAmount)
                ) && 
                (
                    this.FeeTermsCollect == other.FeeTermsCollect ||
                    this.FeeTermsCollect != null &&
                    this.FeeTermsCollect.Equals(other.FeeTermsCollect)
                ) && 
                (
                    this.FeeTermsPrepaid == other.FeeTermsPrepaid ||
                    this.FeeTermsPrepaid != null &&
                    this.FeeTermsPrepaid.Equals(other.FeeTermsPrepaid)
                ) && 
                (
                    this.CustomerCheckAcceptable == other.CustomerCheckAcceptable ||
                    this.CustomerCheckAcceptable != null &&
                    this.CustomerCheckAcceptable.Equals(other.CustomerCheckAcceptable)
                ) && 
                (
                    this.CarrierName == other.CarrierName ||
                    this.CarrierName != null &&
                    this.CarrierName.Equals(other.CarrierName)
                ) && 
                (
                    this.TrailerNo == other.TrailerNo ||
                    this.TrailerNo != null &&
                    this.TrailerNo.Equals(other.TrailerNo)
                ) && 
                (
                    this.SealNo == other.SealNo ||
                    this.SealNo != null &&
                    this.SealNo.Equals(other.SealNo)
                ) && 
                (
                    this.Scac == other.Scac ||
                    this.Scac != null &&
                    this.Scac.Equals(other.Scac)
                ) && 
                (
                    this.ProNo == other.ProNo ||
                    this.ProNo != null &&
                    this.ProNo.Equals(other.ProNo)
                ) && 
                (
                    this.Prepaid == other.Prepaid ||
                    this.Prepaid != null &&
                    this.Prepaid.Equals(other.Prepaid)
                ) && 
                (
                    this.Collect == other.Collect ||
                    this.Collect != null &&
                    this.Collect.Equals(other.Collect)
                ) && 
                (
                    this.ThirdParty == other.ThirdParty ||
                    this.ThirdParty != null &&
                    this.ThirdParty.Equals(other.ThirdParty)
                ) && 
                (
                    this.IsThisAMasterBOL == other.IsThisAMasterBOL ||
                    this.IsThisAMasterBOL != null &&
                    this.IsThisAMasterBOL.Equals(other.IsThisAMasterBOL)
                ) && 
                (
                    this.MasterBOLId == other.MasterBOLId ||
                    this.MasterBOLId != null &&
                    this.MasterBOLId.Equals(other.MasterBOLId)
                ) && 
                (
                    this.IsFreightCountedByShipper == other.IsFreightCountedByShipper ||
                    this.IsFreightCountedByShipper != null &&
                    this.IsFreightCountedByShipper.Equals(other.IsFreightCountedByShipper)
                ) && 
                (
                    this.ByDriverPallets == other.ByDriverPallets ||
                    this.ByDriverPallets != null &&
                    this.ByDriverPallets.Equals(other.ByDriverPallets)
                ) && 
                (
                    this.ByDriverPieces == other.ByDriverPieces ||
                    this.ByDriverPieces != null &&
                    this.ByDriverPieces.Equals(other.ByDriverPieces)
                ) && 
                (
                    this.SpecialInstructions == other.SpecialInstructions ||
                    this.SpecialInstructions != null &&
                    this.SpecialInstructions.Equals(other.SpecialInstructions)
                ) && 
                (
                    this.OrderInfoLines == other.OrderInfoLines ||
                    this.OrderInfoLines != null &&
                    this.OrderInfoLines.SequenceEqual(other.OrderInfoLines)
                ) && 
                (
                    this.CarrierInfoLines == other.CarrierInfoLines ||
                    this.CarrierInfoLines != null &&
                    this.CarrierInfoLines.SequenceEqual(other.CarrierInfoLines)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.BolNo != null)
                    hash = hash * 59 + this.BolNo.GetHashCode();
                
                if (this.BolDate != null)
                    hash = hash * 59 + this.BolDate.GetHashCode();
                
                if (this.ShipFromName != null)
                    hash = hash * 59 + this.ShipFromName.GetHashCode();
                
                if (this.ShipFromAddress != null)
                    hash = hash * 59 + this.ShipFromAddress.GetHashCode();
                
                if (this.ShipFromCity != null)
                    hash = hash * 59 + this.ShipFromCity.GetHashCode();
                
                if (this.ShipFromState != null)
                    hash = hash * 59 + this.ShipFromState.GetHashCode();
                
                if (this.ShipFromZip != null)
                    hash = hash * 59 + this.ShipFromZip.GetHashCode();
                
                if (this.Sid != null)
                    hash = hash * 59 + this.Sid.GetHashCode();
                
                if (this.IsShipFromFOB != null)
                    hash = hash * 59 + this.IsShipFromFOB.GetHashCode();
                
                if (this.ShipToName != null)
                    hash = hash * 59 + this.ShipToName.GetHashCode();
                
                if (this.ShipToAddress != null)
                    hash = hash * 59 + this.ShipToAddress.GetHashCode();
                
                if (this.ShipToCity != null)
                    hash = hash * 59 + this.ShipToCity.GetHashCode();
                
                if (this.ShipToState != null)
                    hash = hash * 59 + this.ShipToState.GetHashCode();
                
                if (this.ShipToZip != null)
                    hash = hash * 59 + this.ShipToZip.GetHashCode();
                
                if (this.ShipToLocationNo != null)
                    hash = hash * 59 + this.ShipToLocationNo.GetHashCode();
                
                if (this.Cid != null)
                    hash = hash * 59 + this.Cid.GetHashCode();
                
                if (this.IsShipToFOB != null)
                    hash = hash * 59 + this.IsShipToFOB.GetHashCode();
                
                if (this.BillToName != null)
                    hash = hash * 59 + this.BillToName.GetHashCode();
                
                if (this.BillToAddress != null)
                    hash = hash * 59 + this.BillToAddress.GetHashCode();
                
                if (this.BillToCity != null)
                    hash = hash * 59 + this.BillToCity.GetHashCode();
                
                if (this.BillToState != null)
                    hash = hash * 59 + this.BillToState.GetHashCode();
                
                if (this.BillToZip != null)
                    hash = hash * 59 + this.BillToZip.GetHashCode();
                
                if (this.IsTrailerLoadedByShipper != null)
                    hash = hash * 59 + this.IsTrailerLoadedByShipper.GetHashCode();
                
                if (this.ByDriver != null)
                    hash = hash * 59 + this.ByDriver.GetHashCode();
                
                if (this.CodAmount != null)
                    hash = hash * 59 + this.CodAmount.GetHashCode();
                
                if (this.FeeTermsCollect != null)
                    hash = hash * 59 + this.FeeTermsCollect.GetHashCode();
                
                if (this.FeeTermsPrepaid != null)
                    hash = hash * 59 + this.FeeTermsPrepaid.GetHashCode();
                
                if (this.CustomerCheckAcceptable != null)
                    hash = hash * 59 + this.CustomerCheckAcceptable.GetHashCode();
                
                if (this.CarrierName != null)
                    hash = hash * 59 + this.CarrierName.GetHashCode();
                
                if (this.TrailerNo != null)
                    hash = hash * 59 + this.TrailerNo.GetHashCode();
                
                if (this.SealNo != null)
                    hash = hash * 59 + this.SealNo.GetHashCode();
                
                if (this.Scac != null)
                    hash = hash * 59 + this.Scac.GetHashCode();
                
                if (this.ProNo != null)
                    hash = hash * 59 + this.ProNo.GetHashCode();
                
                if (this.Prepaid != null)
                    hash = hash * 59 + this.Prepaid.GetHashCode();
                
                if (this.Collect != null)
                    hash = hash * 59 + this.Collect.GetHashCode();
                
                if (this.ThirdParty != null)
                    hash = hash * 59 + this.ThirdParty.GetHashCode();
                
                if (this.IsThisAMasterBOL != null)
                    hash = hash * 59 + this.IsThisAMasterBOL.GetHashCode();
                
                if (this.MasterBOLId != null)
                    hash = hash * 59 + this.MasterBOLId.GetHashCode();
                
                if (this.IsFreightCountedByShipper != null)
                    hash = hash * 59 + this.IsFreightCountedByShipper.GetHashCode();
                
                if (this.ByDriverPallets != null)
                    hash = hash * 59 + this.ByDriverPallets.GetHashCode();
                
                if (this.ByDriverPieces != null)
                    hash = hash * 59 + this.ByDriverPieces.GetHashCode();
                
                if (this.SpecialInstructions != null)
                    hash = hash * 59 + this.SpecialInstructions.GetHashCode();
                
                if (this.OrderInfoLines != null)
                    hash = hash * 59 + this.OrderInfoLines.GetHashCode();
                
                if (this.CarrierInfoLines != null)
                    hash = hash * 59 + this.CarrierInfoLines.GetHashCode();
                
                return hash;
            }
        }

    }
}
