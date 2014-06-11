using System.Runtime.Serialization;

namespace FanartTv.Data
{
  [DataContract]
  public class Thumb
  {
    [DataMember(Name = "id")]
    public int? Id { get; set; }

    [DataMember(Name = "url")]
    public string Url { get; set; }

    [DataMember(Name = "likes")]
    public int? Likes { get; set; }
  }
}
