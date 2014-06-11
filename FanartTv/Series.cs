using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using FanartTv.Data;

namespace FanartTv
{
  public class Series
  {
    public Dictionary<string, Seriesdata> List { get; set; }

    public Series(string thetvdb_id)
    {
      List = Info(thetvdb_id, API.Key);
    }

    public Series(string thetvdb_id, string apiKey)
    {
      List = Info(thetvdb_id, apiKey);
    }

    private static Dictionary<string, Seriesdata> Info(string thetvdb_id, string apiKey)
    {
      var c = new Dictionary<string, Seriesdata>();

      try
      {
        WebRequest request =
          WebRequest.Create(
            "http://api.fanart.tv/webservice/series/" + apiKey + "/" + thetvdb_id + "/json");

        request.Proxy = WebRequest.DefaultWebProxy;
        request.Credentials = CredentialCache.DefaultCredentials;

        request.Proxy.Credentials = CredentialCache.DefaultCredentials;
        WebResponse response = request.GetResponse();
        var reader = new StreamReader(response.GetResponseStream());

        string json = reader.ReadToEnd();

        Dictionary<string, Seriesdata> tmp;

        using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
        {
          var settings = new DataContractJsonSerializerSettings { UseSimpleDictionaryFormat = true };

          var serializer = new DataContractJsonSerializer(typeof(Dictionary<string, Seriesdata>), settings);
          tmp = (Dictionary<string, Seriesdata>)serializer.ReadObject(ms);
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
