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
      List = Info(mbId, API.Key, API.cKey);
    }

    /// <summary>
    /// Get Images for Album
    /// </summary>
    /// <param name="mbId">Albums musicbrainz release-group id</param>
    /// <param name="apiKey">Users api_key</param>
    public Album(string mbId, string apiKey)
    {
      List = Info(mbId, apiKey, API.cKey);
    }

    /// <summary>
    /// Get Images for Album
    /// </summary>
    /// <param name="mbId">Albums musicbrainz release-group id</param>
    /// <param name="apiKey">Users api_key</param>
    /// <param name="clientKey">Users client_key</param>
    public Album(string mbId, string apiKey, string clientKey)
    {
        List = Info(mbId, apiKey, clientKey);
    }

    /// <summary>
    /// API Result
    /// </summary>
    /// <param name="mbId">Albums musicbrainz release-group id</param>
    /// <param name="apiKey">Users api_key</param>
    /// <param name="clientKey">Users client_key</param>
    /// <returns>List of Images for a Album</returns>
    private static AlbumData Info(string mbId, string apiKey, string clientKey)
    {
      try
      {
        AlbumData tmp;
        API.ErrorOccurred = false;
        API.ErrorMessage = string.Empty;

        var json = clientKey != "" ? Helper.Json.GetJson(API.Server + "music/albums/" + mbId + "?api_key=" + apiKey) : Helper.Json.GetJson(API.Server + "music/albums/" + mbId + "?api_key=" + apiKey + "&client_key=" + clientKey);

        if (API.ErrorOccurred)
          return new AlbumData();

        using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
        {
          var settings = new DataContractJsonSerializerSettings {UseSimpleDictionaryFormat = true};

          var serializer = new DataContractJsonSerializer(typeof(AlbumData), settings);
          tmp = (AlbumData)serializer.ReadObject(ms);
        }
        return tmp ?? new AlbumData();
      }
      catch (Exception ex)
      {
        API.ErrorOccurred = true;
        API.ErrorMessage = ex.Message;
        return new AlbumData();
      }
    }
  }
}
