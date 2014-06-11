using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using FanartTv.Data;

namespace FanartTv
{
  public class Album
  {
    public Dictionary<string, Albumdata> List { get; set; }

    public Album(string mbid)
    {
      List = Info(mbid, API.Key);
    }

    public Album(string mbid, string apiKey)
    {
      List = Info(mbid, apiKey);
    }

    private static Dictionary<string, Albumdata> Info(string mbid, string apiKey)
    {
      var c = new Dictionary<string, Albumdata>();

      try
      {
        WebRequest request =
          WebRequest.Create(
            "http://api.fanart.tv/webservice/album/" + apiKey + "/" + mbid + "/json");

        request.Proxy = WebRequest.DefaultWebProxy;
        request.Credentials = CredentialCache.DefaultCredentials;
        
        request.Proxy.Credentials = CredentialCache.DefaultCredentials;
        WebResponse response = request.GetResponse();
        var reader = new StreamReader(response.GetResponseStream());

        string json = reader.ReadToEnd();

        Dictionary<string, Albumdata> tmp;

        using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
        {
          var settings = new DataContractJsonSerializerSettings { UseSimpleDictionaryFormat = true };

          var serializer = new DataContractJsonSerializer(typeof(Dictionary<string, Albumdata>), settings);
          tmp = (Dictionary<string, Albumdata>)serializer.ReadObject(ms);
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
