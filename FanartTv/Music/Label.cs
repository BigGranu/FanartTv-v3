using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using FanartTv.Types;

namespace FanartTv.Music
{
  /// <summary>
  /// Get Images for Label
  /// </summary>
  public class Label
  {
    /// <summary>
    /// Get Images for Label
    /// </summary>
    public LabelData List { get; set; }

    /// <summary>
    /// List of Images for a Label
    /// </summary>
    /// <param name="mbid">Labels musicbrainz id</param>
    public Label(string mbid)
    {
      List = Info(mbid, API.Key, API.cKey);
    }

    /// <summary>
    /// Get Images for Label
    /// </summary>
    /// <param name="mbid">Labels musicbrainz id</param>
    /// <param name="apiKey">Users api_key</param>
    public Label(string mbid, string apiKey)
    {
      List = Info(mbid, apiKey, API.cKey);
    }

    /// <summary>
    /// Get Images for Label
    /// </summary>
    /// <param name="mbid">Labels musicbrainz id</param>
    /// <param name="apiKey">Users api_key</param>
    /// <param name="clientKey">Users client_key</param>
    public Label(string mbid, string apiKey, string clientKey)
    {
        List = Info(mbid, apiKey, clientKey);
    }

    /// <summary>
    /// API Result
    /// </summary>
    /// <param name="mbId">Labels musicbrainz id</param>
    /// <param name="apiKey">Users api_key</param>
    /// <returns>List of Images for a Label</returns>
    /// <param name="clientKey">Users client_key</param>
    private static LabelData Info(string mbId, string apiKey, string clientKey)
    {
      try
      {
        LabelData tmp;
        API.ErrorOccurred = false;
        API.ErrorMessage = string.Empty;

        var json = clientKey != "" ? Helper.Json.GetJson(API.Server + "music/labels/" + mbId + "?api_key=" + apiKey) : Helper.Json.GetJson(API.Server + "music/labels/" + mbId + "?api_key=" + apiKey + "&client_key=" + clientKey);

        if (API.ErrorOccurred)
          return new LabelData();

        using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
        {
          var settings = new DataContractJsonSerializerSettings {UseSimpleDictionaryFormat = true};
          var serializer = new DataContractJsonSerializer(typeof (LabelData), settings);
          tmp = (LabelData) serializer.ReadObject(ms);
        }
        return tmp ?? new LabelData();
      }
      catch (Exception ex)
      {
        API.ErrorOccurred = true;
        API.ErrorMessage = ex.Message;
        return new LabelData();
      }
    }
  }
}