using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FanartTv.Types
{
  [DataContract]
  public class TvData
  {
    private string _name = string.Empty;
    private string _thetvdbId = string.Empty;
    private List<TvArt> _clearlogo = new List<TvArt>();
    private List<TvArt> _tvthumb = new List<TvArt>();
    private List<TvArt> _hdtvlogo = new List<TvArt>();
    private List<TvArt> _clearart = new List<TvArt>();
    private List<TvImage> _showbackground = new List<TvImage>();
    private List<TvImage> _seasonposter = new List<TvImage>();
    private List<TvImage> _seasonthumb = new List<TvImage>();
    private List<TvArt> _hdclearart = new List<TvArt>();
    private List<TvArt> _tvbanner = new List<TvArt>();
    private List<TvArt> _tvposter = new List<TvArt>();
    private List<TvArt> _characterart = new List<TvArt>();
    private List<TvImage> _seasonbanner = new List<TvImage>();


    [DataMember(Name = "name")]
    public string Name
    {
      get { return _name; }
      set { _name = value; }
    }

    [DataMember(Name = "thetvdb_id")]
    public string TheTvdbId
    {
      get { return _thetvdbId; }
      set { _thetvdbId = value; }
    }

    [DataMember(Name = "clearlogo")]
    public List<TvArt> Clearlogo
    {
      get { return _clearlogo; }
      set { _clearlogo = value; }
    }

    [DataMember(Name = "tvthumb")]
    public List<TvArt> Tvthumb
    {
      get { return _tvthumb; }
      set { _tvthumb = value; }
    }

    [DataMember(Name = "hdtvlogo")]
    public List<TvArt> HdTListvlogo
    {
      get { return _hdtvlogo; }
      set { _hdtvlogo = value; }
    }

    [DataMember(Name = "clearart")]
    public List<TvArt> Clearart
    {
      get { return _clearart; }
      set { _clearart = value; }
    }

    [DataMember(Name = "showbackground")]
    public List<TvImage> Showbackground
    {
      get { return _showbackground; }
      set { _showbackground = value; }
    }

    [DataMember(Name = "seasonposter")]
    public List<TvImage> Seasonposter
    {
      get { return _seasonposter; }
      set { _seasonposter = value; }
    }

    [DataMember(Name = "seasonthumb")]
    public List<TvImage> Seasonthumb
    {
      get { return _seasonthumb; }
      set { _seasonthumb = value; }
    }

    [DataMember(Name = "hdclearart")]
    public List<TvArt> Hdclearart
    {
      get { return _hdclearart; }
      set { _hdclearart = value; }
    }

    [DataMember(Name = "tvbanner")]
    public List<TvArt> Tvbanner
    {
      get { return _tvbanner; }
      set { _tvbanner = value; }
    }

    [DataMember(Name = "tvposter")]
    public List<TvArt> Tvposter
    {
      get { return _tvposter; }
      set { _tvposter = value; }
    }

    [DataMember(Name = "characterart")]
    public List<TvArt> Characterart
    {
      get { return _characterart; }
      set { _characterart = value; }
    }

    [DataMember(Name = "seasonbanner")]
    public List<TvImage> Seasonbanner
    {
      get { return _seasonbanner; }
      set { _seasonbanner = value; }
    }
  }

  [DataContract]
  public class TvArt
  {
    private string _id = string.Empty;
    private string _url = string.Empty;
    private string _lang = string.Empty;
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

    [DataMember(Name = "lang")]
    public string Lang
    {
      get { return _lang; }
      set { _lang = value; }
    }

    [DataMember(Name = "likes")]
    public string Likes
    {
      get { return _likes; }
      set { _likes = value; }
    }
  }

  [DataContract]
  public class TvImage
  {
    private string _id = string.Empty;
    private string _url = string.Empty;
    private string _lang = string.Empty;
    private string _likes = string.Empty;
    private string _season = string.Empty;

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

    [DataMember(Name = "lang")]
    public string Lang
    {
      get { return _lang; }
      set { _lang = value; }
    }

    [DataMember(Name = "likes")]
    public string Likes
    {
      get { return _likes; }
      set { _likes = value; }
    }

    [DataMember(Name = "season")]
    public string Season
    {
      get { return _season; }
      set { _season = value; }
    }
  }

  [DataContract]
  public class TvLatest
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
}
