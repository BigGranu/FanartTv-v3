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
    /// List of Images for a Label
    /// </summary>
    /// <param name="mbid">Labels musicbrainz id</param>
    public Label(string mbid)
    {
      List = Info(mbid, API.Key);
    }

    /// <summary>
    /// Get Images for Label
    /// </summary>
    /// <param name="mbid">Labels musicbrainz id</param>
    /// <param name="apiKey">Users api_key</param>
    public Label(string mbid, string apiKey)
    {
      List = Info(mbid, apiKey);
    }

    /// <summary>
    /// Get Images for Label
    /// </summary>
    public LabelData List { get; set; }

    /// <summary>
    /// API Result
    /// </summary>
    /// <param name="mbId">Labels musicbrainz id</param>
    /// <param name="apiKey">Users api_key</param>
    /// <returns>List of Images for a Label</returns>
    private static LabelData Info(string mbId, string apiKey)
    {
      try
      {
        LabelData tmp;

        using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(Helper.Json.GetJson(API.Server + "music/labels/" + mbId + "?api_key=" + apiKey))))
        {
          var settings = new DataContractJsonSerializerSettings {UseSimpleDictionaryFormat = true};
          var serializer = new DataContractJsonSerializer(typeof (LabelData), settings);
          tmp = (LabelData) serializer.ReadObject(ms);
        }
        return tmp ?? new LabelData();
      }
      catch (Exception)
      {
        return new LabelData();
      }
    }
  }
}