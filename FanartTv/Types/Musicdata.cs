using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FanartTv.Types
{
  [DataContract]
  public class ArtistData
  {
    [DataMember(Name = "name")]
    public string Name { get; set; }

    [DataMember(Name = "mbid_id")]
    public string MbId { get; set; }

    [DataMember(Name = "artistbackground")]
    public List<ArtistImage> AImagesrtistbackground { get; set; }

    [DataMember(Name = "artistthumb")]
    public List<ArtistImage> Artistthumb { get; set; }

    [DataMember(Name = "musiclogo")]
    public List<ArtistImage> Musiclogo { get; set; }

    [DataMember(Name = "hdmusiclogo")]
    public List<ArtistImage> Hdmusiclogo { get; set; }

    [DataMember(Name = "albums")]
    public Dictionary<string, Albums> Albums { get; set; }

    [DataMember(Name = "musicbanner")]
    public List<ArtistImage> Musicbanner { get; set; }
  }

  [DataContract]
  public class Art
  {
    [DataMember(Name = "id")]
    public string Id { get; set; }

    [DataMember(Name = "url")]
    public string Url { get; set; }

    [DataMember(Name = "likes")]
    public string Likes { get; set; }

    [DataMember(Name = "disc")]
    public string Disc { get; set; }

    [DataMember(Name = "size")]
    public string Size { get; set; }
  }

  [DataContract]
  public class ArtistImage
  {
    [DataMember(Name = "id")]
    public int? Id { get; set; }

    [DataMember(Name = "url")]
    public string Url { get; set; }

    [DataMember(Name = "likes")]
    public int? Likes { get; set; }
  }

  [DataContract]
  public class LatestArtistData
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

  [DataContract]
  public class LabelData
  {
    [DataMember(Name = "name")]
    public string Name { get; set; }

    [DataMember(Name = "id")]
    public string Id { get; set; }

    [DataMember(Name = "musiclabel")]
    public List<Musiclabel> Labels { get; set; }
  }

  [DataContract]
  public class Musiclabel
  {
    [DataMember(Name = "id")]
    public string Id { get; set; }

    [DataMember(Name = "url")]
    public string Url { get; set; }

    [DataMember(Name = "colour")]
    public string Colour { get; set; }

    [DataMember(Name = "likes")]
    public string Likes { get; set; }
  }

  [DataContract]
  public class AlbumData
  {
    [DataMember(Name = "name")]
    public string Name { get; set; }

    [DataMember(Name = "mbid_id")]
    public string MbidId { get; set; }

    [DataMember(Name = "albums")]
    public Dictionary<string, Albums> Albums { get; set; }
  }

  [DataContract]
  public class Albums
  {
    [DataMember(Name = "cdart")]
    public List<Art> Cdart { get; set; }

    [DataMember(Name = "albumcover")]
    public List<ArtistImage> Albumcover { get; set; }
  }
}