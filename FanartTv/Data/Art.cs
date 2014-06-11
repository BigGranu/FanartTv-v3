using System.Runtime.Serialization;

namespace FanartTv.Data
{
  [DataContract]
  public class Art
  {
    [DataMember(Name = "id")]
    public int? Id { get; set; }

    [DataMember(Name = "url")]
    public string Url { get; set; }

    [DataMember(Name = "likes")]
    public int? Likes { get; set; }

    [DataMember(Name = "disc")]
    public int? Disc { get; set; }

    [DataMember(Name = "size")]
    public int? Size { get; set; }
  }
}
