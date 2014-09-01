using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FanartTv.Types
{
  [DataContract]
  public class TvData
  {
    [DataMember(Name = "name")]
    public string Name { get; set; }

    [DataMember(Name = "thetvdb_id")]
    public string TheTvdbId { get; set; }

    [DataMember(Name = "clearlogo")]
    public List<TvArt> Clearlogo { get; set; }

    [DataMember(Name = "tvthumb")]
    public List<TvArt> Tvthumb { get; set; }

    [DataMember(Name = "hdtvlogo")]
    public List<TvArt> HdTListvlogo { get; set; }

    [DataMember(Name = "clearart")]
    public List<TvArt> Clearart { get; set; }

    [DataMember(Name = "showbackground")]
    public List<TvImage> Showbackground { get; set; }

    [DataMember(Name = "seasonposter")]
    public List<TvImage> Seasonposter { get; set; }

    [DataMember(Name = "seasonthumb")]
    public List<TvImage> Seasonthumb { get; set; }

    [DataMember(Name = "hdclearart")]
    public List<TvArt> Hdclearart { get; set; }

    [DataMember(Name = "tvbanner")]
    public List<TvArt> Tvbanner { get; set; }

    [DataMember(Name = "tvposter")]
    public List<TvArt> Tvposter { get; set; }

    [DataMember(Name = "characterart")]
    public List<TvArt> Characterart { get; set; }

    [DataMember(Name = "seasonbanner")]
    public List<TvImage> Seasonbanner { get; set; }
  }

  [DataContract]
  public class TvArt
  {
    [DataMember(Name = "id")]
    public string Id { get; set; }

    [DataMember(Name = "url")]
    public string Url { get; set; }

    [DataMember(Name = "lang")]
    public string Lang { get; set; }

    [DataMember(Name = "likes")]
    public string Likes { get; set; }
  }

  [DataContract]
  public class TvImage
  {
    [DataMember(Name = "id")]
    public string Id { get; set; }

    [DataMember(Name = "url")]
    public string Url { get; set; }

    [DataMember(Name = "lang")]
    public string Lang { get; set; }

    [DataMember(Name = "likes")]
    public string Likes { get; set; }

    [DataMember(Name = "season")]
    public string Season { get; set; }
  }

  [DataContract]
  public class TvLatest
  {
    [DataMember(Name = "id")]
    public string Id { get; set; }

    [DataMember(Name = "name")]
    public string Name { get; set; }

    [DataMember(Name = "new_images")]
    public string NewImages { get; set; }

    [DataMember(Name = "total_images")]
    public string TotalImages { get; set; }
  }
}
