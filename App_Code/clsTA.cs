using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

/// <summary>
/// Summary description for clsTA
/// </summary>
[DataContract]
public class TAREQUEST
{
    [DataMember(EmitDefaultValue = false)]
    public string OPCODE { get; set; }
    [DataMember(EmitDefaultValue = false, IsRequired = false)]
    public string MOBILE { get; set; }
    [DataMember(EmitDefaultValue = false, IsRequired = false)]
    public string NAME { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public string TIMESTAMP { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public string SRCVIRTUALACCNO { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public string DESTVIRTUALACCNO { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public string AMOUNT { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public string TPIN { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public string TRNREFNO { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public string VIRTUALACCNO { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public string ACCOUNTNUMBER { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public string IFSCCODE { get; set; }
}
[DataContract]
public class TARESPONSE
{
    [DataMember(EmitDefaultValue = false)]
    public string RESPONSECODE { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public string RESPONSEDESC { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public string VIRTUALACCOUNT { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public string TPIN { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public string BALANCE { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public string FUNDINGLIMIT { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public string TRNREFNO { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public string RRN { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public string SRCMOBILENUMBER { get; set; }
}