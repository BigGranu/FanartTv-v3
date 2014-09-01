using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using FanartTv.Types;

namespace FanartTv.Music
{
  /// <summary>
  /// Get Images for Album
  /// </summary>
  public class Album
  {
    /// <summary>
    /// List of Images for a Album
    /// </summary>
    public AlbumData List { get; set; }

    /// <summary>
    /// Get Images for Album
    /// </summary>
    /// <param name="mbId">Albums musicbrainz release-group id</param>
    public Album(string mbId)
    {
      List = Info(mbId, API.Key);
    }

    /// <summary>
    /// Get Images for Album
    /// </summary>
    /// <param name="mbId">Albums musicbrainz release-group id</param>
    /// <param name="apiKey">Users api_key</param>
    public Album(string mbId, string apiKey)
    {
      List = Info(mbId, apiKey);
    }

    /// <summary>
    /// API Result
    /// </summary>
    /// <param name="mbId">Albums musicbrainz release-group id</param>
    /// <param name="apiKey">Users api_key</param>
    /// <returns>List of Images for a Album</returns>
    private static AlbumData Info(string mbId, string apiKey)
    {
      try
      {
        AlbumData tmp;

        using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(Helper.Json.GetJson(API.Server + "albums/" + mbId + "?api_key=" + apiKey))))
        {
          var settings = new DataContractJsonSerializerSettings {UseSimpleDictionaryFormat = true};

          var serializer = new DataContractJsonSerializer(typeof(AlbumData), settings);
          tmp = (AlbumData)serializer.ReadObject(ms);
        }
        return tmp ?? new AlbumData();
      }
      catch (Exception)
      {
        return new AlbumData();
      }
    }
  }
}
