using System.Runtime.Serialization;

namespace FanartTv.Data
{
  [DataContract]
  public class Seasonimage
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
}
