using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FanartTv.Data
{
  [DataContract]
  public class Moviedata
  {
    [DataMember(Name = "tmdb_id")]
    public string TmdbId { get; set; }

    [DataMember(Name = "imdb_id")]
    public string ImdbId { get; set; }

    [DataMember(Name = "hdmovielogo")]
    public List<Image> HD_Logo { get; set; }

    [DataMember(Name = "moviedisc")]
    public List<Moviedisc> Disc { get; set; }

    [DataMember(Name = "movielogo")]
    public List<Image> Logo { get; set; }

    [DataMember(Name = "movieposter")]
    public List<Image> Poster { get; set; }

    [DataMember(Name = "hdmovieclearart")]
    public List<Image> HD_Clearart { get; set; }

    [DataMember(Name = "movieart")]
    public List<Image> Art { get; set; }

    [DataMember(Name = "moviebackground")]
    public List<Image> Background { get; set; }

    [DataMember(Name = "moviebanner")]
    public List<Image> Banner { get; set; }

    [DataMember(Name = "moviethumb")]
    public List<Image> Thumb { get; set; }
  }
}
