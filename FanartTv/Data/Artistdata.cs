using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FanartTv.Data
{
  [DataContract]
  public class Artistdata
  {
    [DataMember(Name = "mbid_id")]
    public string MbId { get; set; }

    [DataMember(Name = "artistthumb")]
    public List<Thumb> ArtistThumb { get; set; }

    [DataMember(Name = "artistbackground")]
    public List<Thumb> ArtistBackground { get; set; }

    [DataMember(Name = "musiclogo")]
    public List<Thumb> MusikLogo { get; set; }

    [DataMember(Name = "hdmusiclogo")]
    public List<Thumb> HdMusikLogo { get; set; }

    [DataMember(Name = "musicbanner")]
    public List<Thumb> Musicbanner { get; set; }

    [DataMember(Name = "albums")]
    public Dictionary<string, Albums> Albums { get; set; }
  }
}
