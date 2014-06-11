using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FanartTv.Data
{
  [DataContract]
  public class Albumdata
  {
    [DataMember(Name = "mbid_id")]
    public string MbId { get; set; }

    [DataMember(Name = "albums")]
    public Dictionary<string, Albums> Albums { get; set; }
  }
}
