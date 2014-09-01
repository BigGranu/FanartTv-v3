using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FanartTv.Types
{
  [DataContract]
  public class MovieData
  {
    [DataMember(Name = "name")]
    public string Name { get; set; }

    [DataMember(Name = "tmdb_id")]
    public string TmdbId { get; set; }

    [DataMember(Name = "imdb_id")]
    public string ImdbId { get; set; }

    [DataMember(Name = "hdmovieclearart")]
    public List<MovieArt> Hdmovieclearart { get; set; }

    [DataMember(Name = "hdmovielogo")]
    public List<MovieArt> Hdmovielogo { get; set; }

    [DataMember(Name = "movieart")]
    public List<MovieArt> Movieart { get; set; }

    [DataMember(Name = "moviebackground")]
    public List<MovieArt> Moviebackground { get; set; }

    [DataMember(Name = "movieposter")]
    public List<MovieArt> Movieposter { get; set; }

    [DataMember(Name = "movielogo")]
    public List<MovieArt> Movielogo { get; set; }

    [DataMember(Name = "moviedisc")]
    public List<MovieDisc> Moviedisc { get; set; }

    [DataMember(Name = "moviethumb")]
    public List<MovieArt> Moviethumb { get; set; }

    [DataMember(Name = "moviebanner")]
    public List<MovieArt> Moviebanner { get; set; }
  }

  [DataContract]
  public class MovieArt
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
  public class MovieDisc
  {
    [DataMember(Name = "id")]
    public string Id { get; set; }

    [DataMember(Name = "url")]
    public string Url { get; set; }

    [DataMember(Name = "lang")]
    public string Lang { get; set; }

    [DataMember(Name = "likes")]
    public string Likes { get; set; }

    [DataMember(Name = "disc")]
    public string Disc { get; set; }

    [DataMember(Name = "disc_type")]
    public string DiscType { get; set; }
  }

  [DataContract]
  public class MovieLatest
  {
    [DataMember(Name = "tmdb_id")]
    public string TmdbId { get; set; }

    [DataMember(Name = "imdb_id")]
    public string ImdbId { get; set; }

    [DataMember(Name = "name")]
    public string Name { get; set; }

    [DataMember(Name = "new_images")]
    public string NewImages { get; set; }

    [DataMember(Name = "total_images")]
    public string TotalImages { get; set; }
  }
}
