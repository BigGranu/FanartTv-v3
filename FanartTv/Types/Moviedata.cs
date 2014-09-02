using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FanartTv.Types
{
  [DataContract]
  public class MovieData
  {
    private string _name = string.Empty;
    private string _tmdbId = string.Empty;
    private string _imdbId = string.Empty;
    private List<MovieArt> _hdmovieclearart = new List<MovieArt>();
    private List<MovieArt> _hdmovielogo = new List<MovieArt>();
    private List<MovieArt> _movieart = new List<MovieArt>();
    private List<MovieArt> _moviebackground = new List<MovieArt>();
    private List<MovieArt> _movieposter = new List<MovieArt>();
    private List<MovieArt> _movielogo = new List<MovieArt>();
    private List<MovieDisc> _moviedisc = new List<MovieDisc>();
    private List<MovieArt> _moviethumb = new List<MovieArt>();
    private List<MovieArt> _moviebanner = new List<MovieArt>();

    [DataMember(Name = "name")]
    public string Name
    {
      get { return _name; }
      set { _name = value; }
    }

    [DataMember(Name = "tmdb_id")]
    public string TmdbId
    {
      get { return _tmdbId; }
      set { _tmdbId = value; }
    }

    [DataMember(Name = "imdb_id")]
    public string ImdbId
    {
      get { return _imdbId; }
      set { _imdbId = value; }
    }

    [DataMember(Name = "hdmovieclearart")]
    public List<MovieArt> Hdmovieclearart
    {
      get { return _hdmovieclearart; }
      set { _hdmovieclearart = value; }
    }

    [DataMember(Name = "hdmovielogo")]
    public List<MovieArt> Hdmovielogo
    {
      get { return _hdmovielogo; }
      set { _hdmovielogo = value; }
    }

    [DataMember(Name = "movieart")]
    public List<MovieArt> Movieart
    {
      get { return _movieart; }
      set { _movieart = value; }
    }

    [DataMember(Name = "moviebackground")]
    public List<MovieArt> Moviebackground
    {
      get { return _moviebackground; }
      set { _moviebackground = value; }
    }

    [DataMember(Name = "movieposter")]
    public List<MovieArt> Movieposter
    {
      get { return _movieposter; }
      set { _movieposter = value; }
    }

    [DataMember(Name = "movielogo")]
    public List<MovieArt> Movielogo
    {
      get { return _movielogo; }
      set { _movielogo = value; }
    }

    [DataMember(Name = "moviedisc")]
    public List<MovieDisc> Moviedisc
    {
      get { return _moviedisc; }
      set { _moviedisc = value; }
    }

    [DataMember(Name = "moviethumb")]
    public List<MovieArt> Moviethumb
    {
      get { return _moviethumb; }
      set { _moviethumb = value; }
    }

    [DataMember(Name = "moviebanner")]
    public List<MovieArt> Moviebanner
    {
      get { return _moviebanner; }
      set { _moviebanner = value; }
    }
  }

  [DataContract]
  public class MovieArt
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
  public class MovieDisc
  {
    private string _id = string.Empty;
    private string _url = string.Empty;
    private string _lang = string.Empty;
    private string _likes = string.Empty;
    private string _disc = string.Empty;
    private string _discType = string.Empty;

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

    [DataMember(Name = "disc")]
    public string Disc
    {
      get { return _disc; }
      set { _disc = value; }
    }

    [DataMember(Name = "disc_type")]
    public string DiscType
    {
      get { return _discType; }
      set { _discType = value; }
    }
  }

  [DataContract]
  public class MovieLatest
  {
    private string _tmdbId = string.Empty;
    private string _imdbId = string.Empty;
    private string _name = string.Empty;
    private string _newImages = string.Empty;
    private string _totalImages = string.Empty;

    [DataMember(Name = "tmdb_id")]
    public string TmdbId
    {
      get { return _tmdbId; }
      set { _tmdbId = value; }
    }

    [DataMember(Name = "imdb_id")]
    public string ImdbId
    {
      get { return _imdbId; }
      set { _imdbId = value; }
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