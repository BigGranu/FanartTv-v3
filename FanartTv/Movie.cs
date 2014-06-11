using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using FanartTv.Data;

namespace FanartTv
{
  public class Movie
  {
    public Dictionary<string, Moviedata> List { get; set; }

    public Movie(string imdb_tmdb_id)
    {
      List = Info(imdb_tmdb_id, API.Key);
    }

    public Movie(string imdb_tmdb_id, string apiKey)
    {
      List = Info(imdb_tmdb_id, apiKey);
    }

    private static Dictionary<string, Moviedata> Info(string imdb_tmdb_id, string apiKey)
    {
      var c = new Dictionary<string, Moviedata>();

      try
      {
        WebRequest request =
          WebRequest.Create(
            "http://api.fanart.tv/webservice/movie/" + apiKey + "/" + imdb_tmdb_id + "/json");

        request.Proxy = WebRequest.DefaultWebProxy;
        request.Credentials = CredentialCache.DefaultCredentials;

        request.Proxy.Credentials = CredentialCache.DefaultCredentials;
        WebResponse response = request.GetResponse();
        var reader = new StreamReader(response.GetResponseStream());

        string json = reader.ReadToEnd();

        Dictionary<string, Moviedata> tmp;

        using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
        {
          var settings = new DataContractJsonSerializerSettings { UseSimpleDictionaryFormat = true };

          var serializer = new DataContractJsonSerializer(typeof(Dictionary<string, Moviedata>), settings);
          tmp = (Dictionary<string, Moviedata>)serializer.ReadObject(ms);
        }

        return tmp ?? c;
      }
      catch (Exception)
      {
        return c;
      }
    }
  }
}
