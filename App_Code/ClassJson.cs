using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;
using System.Runtime.Serialization;

/// <summary>
/// Summary description for ClassJson
/// </summary>
public class ClassJson
{
    public ClassJson()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static string JsonSerializer<T>(T t)
    {
        DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
        MemoryStream ms = new MemoryStream();
        ser.WriteObject(ms, t);
        string jsonString = Encoding.UTF8.GetString(ms.ToArray());
        ms.Close();
        return jsonString;
    }
    /// <summary>
    /// JSON Deserialization
    /// </summary>
    public static T JsonDeserialize<T>(string jsonString)
    {
        DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
        MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
        T obj = (T)ser.ReadObject(ms);
        return obj;
    }

    //[DataContract]
    //public class SIGNUP
    //{
    //    [DataMember(EmitDefaultValue = false)]
    //    public string OPCODE { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string MOBILE { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string RESPONSECODE { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string ATTEMPTCOUNT { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string PASSWORD { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string RESPONSEDESC { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string REGISTRATION_REQUIRED { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string ESTABLISHMENT_NAME { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string NAME { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string ADDRESS { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string VIRTUALACCNO { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string MERCHANTID { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string EMAIL { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string ACCOUNTNUMBER { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string WALLETID { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string USERALIAS { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string USERTYPE { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string ENABLEDFLAG { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string FIRSTTIMELOGINFLAG { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string DELFLAG { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string CITY { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string STATE { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string PIN { get; set; }

    //}

    [DataContract]
    public class ENROLL
    {
        [DataMember(EmitDefaultValue = false)]
        public string WALLETID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string OPCODE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string MOBILE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ATTEMPTCOUNT { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string PASSWORD { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string REGISTRATION_REQUIRED { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ESTABLISHMENT_NAME { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string NAME { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ADDRESS { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string MERCHANTID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string EMAIL { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ACCOUNTNUMBER { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string MERCHANT_WALLET_ID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string USERALIAS { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string USERTYPE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ENABLEDFLAG { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string FIRSTTIMELOGINFLAG { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string DELFLAG { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string CITY { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string STATE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string PIN { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string RESPONSECODE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string RESPONSEDESC { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string OTP_STATUS { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string OTP_VALIDATED { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ENROLLMENT_STATUS { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string INITIAL_AMOUNT { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string TRANSACTION_STATUS { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string TXN_ID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string TXN_DATE { get; set; }
    }
    [DataContract]
    public class CHANGEPIN
    {
        [DataMember(EmitDefaultValue = false)]
        public string OPCODE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string MOBILENO { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string COUNTRYCODE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string OLDMPIN { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string NEWMPIN { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string DEVICETYPE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string DEVICEID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string PUSHTOKEN { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string RESPONSECODE { get; set; }
    }

    [DataContract]
    public class LOGIN
    {
        [DataMember(EmitDefaultValue = false)]
        public string OPCODE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string MOBILENO { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string COUNTRYCODE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string MPIN { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string DEVICETYPE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string DEVICEID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string PUSHTOKEN { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string RESPONSECODE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string SESSIONID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ATTEMPTCOUNT { get; set; }
    }

    [DataContract]
    public class ACCOUNTS
    {
        [DataMember(EmitDefaultValue = false)]
        public string OPCODE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string SESSIONID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string DEVICETYPE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string DEVICEID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string CUSTOMERID { get; set; }
    }
    [DataContract]
    public class CUSTOMERDETAIL
    {
        [DataMember(EmitDefaultValue = false)]
        public string NAME { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string CUSTOMERID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string EMAIL { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string MOBILE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ADDRESS { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string OCCUPATION { get; set; }
    }

    [DataContract]
    public class ACCOUNTDETAIL
    {
        [DataMember(EmitDefaultValue = false)]
        public string ACCOUNTNAME { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ACCOUNTNUMBER { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ACCONTTYPE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string BRANCHNAME { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string BRANCHADDRESS { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string BRANCHPHONE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string BRANHEMAIL { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string IFSC { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string MICR { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ACCOUNTBALANCE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string AVAILABLEBALANCE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string EFFECTIVEBALANCE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string LIENBALANCE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string UNCLEAREDBALANCE { get; set; }
    }

    [DataContract]
    public class SUCCESSACCOUNTS
    {
        [DataMember(EmitDefaultValue = false)]
        public string STATUS { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public CUSTOMERDETAIL CUSTOMERDETAIL { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public List<ACCOUNTDETAIL> ACCOUNTDETAIL { get; set; }
    }

    [DataContract]
    public class TRANSACTIONS
    {
        [DataMember(EmitDefaultValue = false)]
        public string OPCODE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string SESSIONID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ACCOUNTNO { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ACCOUNTTYPE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string CUSTOMERID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string DEVICETYPE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string DEVICEID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string LASTTRANSACTIONDATETIME { get; set; }
    }

    [DataContract]
    public class TRANASACTION
    {
        [DataMember(EmitDefaultValue = false)]
        public string DATEANDTIME { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string PARTICULAR { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string AMOUNT { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string TRANTYPE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string CHEQUENO { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string BALANCE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string REMARKS { get; set; }
    }
    [DataContract]
    public class SUCCESSTRAN
    {
        [DataMember(EmitDefaultValue = false)]
        public string STATUS { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ACCOUNTBALANCE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string AVAILABLEBALANCE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string EFFECTIVEBALANCE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string LIENBALANCE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string UNCLEAREDBALANCE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public List<TRANASACTION> TRANASACTIONS { get; set; }
    }

    [DataContract]
    public class SUCCESSTRANSACTIONS
    {
        [DataMember(EmitDefaultValue = false)]
        public SUCCESSTRAN success { get; set; }
    }

    [DataContract]
    public class ACCOUNTUPDATE
    {
        [DataMember(EmitDefaultValue = false)]
        public string OPCODE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string SESSIONID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ACCOUNTNO { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ACCOUNTTYPE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string CUSTOMERID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string DEVICETYPE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string DEVICEID { get; set; }
    }

    [DataContract]
    public class SUCCESSACCOUNTUPDATE
    {
        [DataMember(EmitDefaultValue = false)]
        public string STATUS { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ACCOUNTNAME { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ACCOUNTNUMBER { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ACCONTTYPE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string BRANCHNAME { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string BRANCHADDRESS { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string BRANCHPHONE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string BRANHEMAIL { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string IFSC { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string MICR { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ACCOUNTBALANCE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string AVAILABLEBALANCE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string EFFECTIVEBALANCE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string LIENBALANCE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string UNCLEAREDBALANCE { get; set; }
    }

    [DataContract]
    public class BANNERS
    {
        [DataMember(EmitDefaultValue = false)]
        public string OPCODE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string CUSTOMERID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string DEVICETYPE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string DEVICEID { get; set; }
    }

    [DataContract]
    public class BANNER
    {
        [DataMember(EmitDefaultValue = false)]
        public string BANNERIMAGE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string BANNERLINK { get; set; }
    }

    [DataContract]
    public class SUCCESSBANNERS
    {
        [DataMember(EmitDefaultValue = false)]
        public string STATUS { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public List<BANNER> BANNERS { get; set; }
    }
    [DataContract]
    public class REQUEST
    {
        [DataMember(EmitDefaultValue = false)]
        public string OPCODE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string MOBILE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string OLDMPIN { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string PASSWORD { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string NEWMPIN { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string DEVICETYPE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string DEVICEID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string PUSHTOKEN { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string RESPONSECODE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string LASTTRANSACTIONDATETIME { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string SESSION_ID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string CATEGORY { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string CUSTOMERID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ACCOUNTNO { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ACCOUNTTYPE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string LASTRCRETIME { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string EMAILID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string SUBJECT { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string MESSAGE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string CUSTID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string PANNUMBER { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string DOB { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string TRANSACTION { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string TRANSACTIONTYPE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string LASTSYNCTIME { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string CUSTIDOTP { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string DATE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string TPIN { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string TIMESTAMP { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string VIRTUALACCNO { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string AMOUNT { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string TRNREFNO { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string SRCVIRTUALACCNO { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string DESTVIRTUALACCNO { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string NAME { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string USER_ID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string WALLET_ID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string EMAIL { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string INITIAL_AMOUNT { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string MERCHANT_WALLET_ID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string CUSTOMER_WALLET_ID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string OTP{ get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ESTABLISHMENT_NAME { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ADDRESS { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string CITY { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string STATE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string PINCODE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string CUSTOMER_USER_ID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string NEW_PASSWORD { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string CURRENT_PASSWORD { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string SOURCE_MOBILE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string SOURCE_WALLET { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string DESTINATION_WALLET { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string COLLECTION_AMOUNT { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string TXN_ID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string TRANDATE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string DESTINATION_MOBILE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string MERCHANT_MOBILE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string COUNTRYCODE{ get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string REMARKS { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string IFSCCODE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string STATUS { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ACCOUNT_NO { get; set; }
    }

    //public class S
    //{
    //    public string SessionId { get; set; }
    //    public string CustId { get; set; }
    //}

    [DataContract]
    public class GETID
    {
        [DataMember(EmitDefaultValue = false)]
        public string CUSTID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string SESSIONID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string DEVICEID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string DEVICETYPE { get; set; }
    }

    [DataContract]
    public class PROFILE
    {
        [DataMember(EmitDefaultValue = false)]
        public string ENROLLMENT_TYPE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ESTABLISHMENT_NAME { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string NAME { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string MOBILE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string EMAIL { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ADDRESS { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string CITY { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string STATE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string PINCODE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string RESPONSECODE { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string RESPONSEDESC { get; set; }
    }
    //[DataContract]
    //public class TRANASACTION
    //{
    //    [DataMember(EmitDefaultValue = false)]
    //    public string TRANREFNO { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string TRANREFNOTA { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string TPIN { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string REMARKS { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string TRANDATE { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string TOTALCOLLECTIONAMOUNT { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string WALLETAMOUNT { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string CASHAMOUNT { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string SOURCEWALLETID { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string DESTINATIONWALLETID { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string TRANSTATUS { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string TRANTYPE { get; set; }
    //    [DataMember(EmitDefaultValue = false)]
    //    public string RESPONSETIMETA { get; set; }
    //}
}
