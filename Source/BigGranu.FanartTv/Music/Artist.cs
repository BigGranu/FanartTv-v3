using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using FanartTv.Types;

namespace FanartTv.Music
{
  /// <summary>
  /// Get Images for Artist
  /// </summary>
  public class Artist
  {
    /// <summary>
    /// List of Images for a Artist
    /// </summary>
    public ArtistData List { get; set; }

    /// <summary>
    /// Get Images for Artist
    /// </summary>
    /// <param name="mbId">Musicbrainz id for the artist</param>
    public Artist(string mbId)
    {
      List = Info(mbId, API.Key, API.cKey);
    }

    /// <summary>
    /// Get Images for Artist
    /// </summary>
    /// <param name="mbId">Musicbrainz id for the artist</param>
    /// <param name="apiKey">Users api_key</param>
    public Artist(string mbId, string apiKey)
    {
      List = Info(mbId, apiKey, API.cKey);
    }

    /// <summary>
    /// Get Images for Artist
    /// </summary>
    /// <param name="mbId">Musicbrainz id for the artist</param>
    /// <param name="apiKey">Users api_key</param>
    /// <param name="clientKey">Users client_key</param>
    public Artist(string mbId, string apiKey, string clientKey)
    {
        List = Info(mbId, apiKey, clientKey);
    }

    /// <summary>
    /// API Result
    /// </summary>
    /// <param name="mbId">Musicbrainz id for the artist</param>
    /// <param name="apiKey">Users api_key</param>
    /// <param name="clientKey">Users client_key</param>
    /// <returns>List of Images for a Artist</returns>
    private static ArtistData Info(string mbId, string apiKey, string clientKey)
    {
      try
      {
        ArtistData tmp;
        API.ErrorOccurred = false;
        API.ErrorMessage = string.Empty;

        var json = clientKey != "" ? Helper.Json.GetJson(API.Server + "music/" + mbId + "?api_key=" + apiKey) : Helper.Json.GetJson(API.Server + "music/" + mbId + "?api_key=" + apiKey + "&client_key=" + clientKey);

        if (API.ErrorOccurred)
          return new ArtistData();

        using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
        {
          var settings = new DataContractJsonSerializerSettings { UseSimpleDictionaryFormat = true };
          var serializer = new DataContractJsonSerializer(typeof(ArtistData), settings);
          tmp = (ArtistData)serializer.ReadObject(ms);
        }
        return tmp ?? new ArtistData();
      }
      catch (Exception ex)
      {
        API.ErrorOccurred = true;
        API.ErrorMessage = ex.Message;
        return new ArtistData();
      }
    }
  }
}
