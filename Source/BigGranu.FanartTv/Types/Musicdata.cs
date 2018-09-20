using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FanartTv.Types
{
  [DataContract]
  public class ArtistData
  {
    private string _name = string.Empty;
    private string _mbidId = string.Empty;
    private List<ArtistImage> _artistbackground = new List<ArtistImage>();
    private List<ArtistImage> _artistthumb = new List<ArtistImage>();
    private List<ArtistImage> _musiclogo = new List<ArtistImage>();
    private List<ArtistImage> _hdmusiclogo = new List<ArtistImage>();
    private Dictionary<string, Albums> _albums = new Dictionary<string, Albums>();
    private List<ArtistImage> _musicbanner = new List<ArtistImage>();

    [DataMember(Name = "name")]
    public string Name
    {
      get { return _name; }
      set { _name = value; }
    }

    [DataMember(Name = "mbid_id")]
    public string MbId
    {
      get { return _mbidId; }
      set { _mbidId = value; }
    }

    [DataMember(Name = "artistbackground")]
    public List<ArtistImage> AImagesrtistbackground
    {
      get { return _artistbackground; }
      set { _artistbackground = value; }
    }

    [DataMember(Name = "artistthumb")]
    public List<ArtistImage> Artistthumb
    {
      get { return _artistthumb; }
      set { _artistthumb = value; }
    }

    [DataMember(Name = "musiclogo")]
    public List<ArtistImage> Musiclogo
    {
      get { return _musiclogo; }
      set { _musiclogo = value; }
    }

    [DataMember(Name = "hdmusiclogo")]
    public List<ArtistImage> Hdmusiclogo
    {
      get { return _hdmusiclogo; }
      set { _hdmusiclogo = value; }
    }

    [DataMember(Name = "albums")]
    public Dictionary<string, Albums> Albums
    {
      get { return _albums; }
      set { _albums = value; }
    }

    [DataMember(Name = "musicbanner")]
    public List<ArtistImage> Musicbanner
    {
      get { return _musicbanner; }
      set { _musicbanner = value; }
    }
  }

  [DataContract]
  public class Art
  {
    private string _id = string.Empty;
    private string _url = string.Empty;
    private string _likes = string.Empty;
    private string _disc = string.Empty;
    private string _size = string.Empty;

    [DataMember(Name = "id")]
    public string Id
    {
      get { return _id; }
      set { _id = value; }
    }

    [DataMember(Name = "url")]
    public string Url
    {
      get { return _url; }
      set { _url = value; }
    }

    [DataMember(Name = "likes")]
    public string Likes
    {
      get { return _likes; }
      set { _likes = value; }
    }

    [DataMember(Name = "disc")]
    public string Disc
    {
      get { return _disc; }
      set { _disc = value; }
    }

    [DataMember(Name = "size")]
    public string Size
    {
      get { return _size; }
      set { _size = value; }
    }
  }

  [DataContract]
  public class ArtistImage
  {
    private string _id = string.Empty;
    private string _url = string.Empty;
    private string _likes = string.Empty;

    [DataMember(Name = "id")]
    public string Id
    {
      get { return _id; }
      set { _id = value; }
    }

    [DataMember(Name = "url")]
    public string Url
    {
      get { return _url; }
      set { _url = value; }
    }

    [DataMember(Name = "likes")]
    public string Likes
    {
      get { return _likes; }
      set { _likes = value; }
    }
  }

  [DataContract]
  public class LatestArtistData
  {
    private string _id = string.Empty;
    private string _name = string.Empty;
    private string _newImages = string.Empty;
    private string _totalImages = string.Empty;

    [DataMember(Name = "id")]
    public string Id
    {
      get { return _id; }
      set { _id = value; }
    }

    [DataMember(Name = "name")]
    public string Name
    {
      get { return _name; }
      set { _name = value; }
    }

    [DataMember(Name = "new_images")]
    public string NewImages
    {
      get { return _newImages; }
      set { _newImages = value; }
    }

    [DataMember(Name = "total_images")]
    public string TotalImages
    {
      get { return _totalImages; }
      set { _totalImages = value; }
    }
  }

  [DataContract]
  public class LabelData
  {
    private string _id = string.Empty;
    private string _name = string.Empty;
    private List<Musiclabel> _musiclabel = new List<Musiclabel>();

    [DataMember(Name = "id")]
    public string Id
    {
      get { return _id; }
      set { _id = value; }
    }

    [DataMember(Name = "name")]
    public string Name
    {
      get { return _name; }
      set { _name = value; }
    }

    [DataMember(Name = "musiclabel")]
    public List<Musiclabel> Labels
    {
      get { return _musiclabel; }
      set { _musiclabel = value; }
    }
  }

  [DataContract]
  public class Musiclabel
  {
    private string _id = string.Empty;
    private string _url = string.Empty;
    private string _colour = string.Empty;
    private string _likes = string.Empty;

    [DataMember(Name = "id")]
    public string Id
    {
      get { return _id; }
      set { _id = value; }
    }

    [DataMember(Name = "url")]
    public string Url
    {
      get { return _url; }
      set { _url = value; }
    }

    [DataMember(Name = "colour")]
    public string Colour
    {
      get { return _colour; }
      set { _colour = value; }
    }

    [DataMember(Name = "likes")]
    public string Likes
    {
      get { return _likes; }
      set { _likes = value; }
    }
  }

  [DataContract]
  public class AlbumData
  {
    private string _name = string.Empty;
    private string _mbidId = string.Empty;
    private Dictionary<string, Albums> _albums = new Dictionary<string, Albums>();

    [DataMember(Name = "name")]
    public string Name
    {
      get { return _name; }
      set { _name = value; }
    }

    [DataMember(Name = "mbid_id")]
    public string MbidId
    {
      get { return _mbidId; }
      set { _mbidId = value; }
    }

    [DataMember(Name = "albums")]
    public Dictionary<string, Albums> Albums
    {
      get { return _albums; }
      set { _albums = value; }
    }
  }

  [DataContract]
  public class Albums
  {
    private List<Art> _cdart = new List<Art>();
    private List<ArtistImage> _albumcover = new List<ArtistImage>();

    [DataMember(Name = "cdart")]
    public List<Art> Cdart
    {
      get { return _cdart; }
      set { _cdart = value; }
    }

    [DataMember(Name = "albumcover")]
    public List<ArtistImage> Albumcover
    {
      get { return _albumcover; }
      set { _albumcover = value; }
    }
  }
}