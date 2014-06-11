using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FanartTv.Data
{
  [DataContract]
  public class Albums
  {
    [DataMember(Name = "albumcover")]
    public List<Thumb> CoverThumbs { get; set; }

    [DataMember(Name = "cdart")]
    public List<Art> CdArts { get; set; }
  }
}
