using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FanartTv.Data
{
  [DataContract]
  public class Seriesdata
  {
    [DataMember(Name = "thetvdb_id")]
    public string ThetvdbId { get; set; }

    [DataMember(Name = "clearlogo")]
    public List<Image> Clearlogo { get; set; }

    [DataMember(Name = "hdtvlogo")]
    public List<Image> Hdtvlogo { get; set; }

    [DataMember(Name = "clearart")]
    public List<Image> Clearart { get; set; }

    [DataMember(Name = "showbackground")]
    public List<Seasonimage> Showbackground { get; set; }

    [DataMember(Name = "tvthumb")]
    public List<Image> Tvthumb { get; set; }

    [DataMember(Name = "seasonposter")]
    public List<Seasonimage> Seasonposter { get; set; }

    [DataMember(Name = "seasonthumb")]
    public List<Seasonimage> Seasonthumb { get; set; }

    [DataMember(Name = "hdclearart")]
    public List<Image> Hdclearart { get; set; }

    [DataMember(Name = "tvbanner")]
    public List<Image> Tvbanner { get; set; }

    [DataMember(Name = "characterart")]
    public List<Image> Characterart { get; set; }

    [DataMember(Name = "tvposter")]
    public List<Image> Tvposter { get; set; }

    [DataMember(Name = "seasonbanner")]
    public List<Image> Seasonbanner { get; set; }
  }
}
