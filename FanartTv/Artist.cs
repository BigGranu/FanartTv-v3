using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using FanartTv.Data;

namespace FanartTv
{
  public class Artist
  {
    public Dictionary<string, Artistdata> List { get; set; }

    public Artist(string mbid)
    {
      List = Info(mbid, API.Key);
    }

    public Artist(string mbid, string apiKey)
    {
      List = Info(mbid, apiKey);
    }

    private static Dictionary<string, Artistdata> Info(string mbid, string apiKey)
    {
      var c = new Dictionary<string, Artistdata>();

      try
      {
        WebRequest request =
          WebRequest.Create(
            "http://api.fanart.tv/webservice/artist/" + apiKey + "/" + mbid + "/json");

        request.Proxy = WebRequest.DefaultWebProxy;
        request.Credentials = CredentialCache.DefaultCredentials;
        
        request.Proxy.Credentials = CredentialCache.DefaultCredentials;
        WebResponse response = request.GetResponse();
        var reader = new StreamReader(response.GetResponseStream());

        string json = reader.ReadToEnd();

        Dictionary<string, Artistdata> tmp;

        using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
        {
          var settings = new DataContractJsonSerializerSettings { UseSimpleDictionaryFormat = true };

          var serializer = new DataContractJsonSerializer(typeof(Dictionary<string, Artistdata>), settings);
          tmp = (Dictionary<string, Artistdata>)serializer.ReadObject(ms);
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
