using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using FanartTv.Types;

namespace FanartTv.TV
{
  /// <summary>
  /// Get images for Latest Shows
  /// </summary>
  public class Latest
  {
    /// <summary>
    /// List of images for Latest Shows
    /// </summary>
    public List<TvLatest> List { get; set; }

    /// <summary>
    /// Get images for Latest Shows
    /// </summary>
    public Latest()
    {
      List = Info(API.Key, API.cKey);
    }

    /// <summary>
    /// Get images for Latest Shows
    /// </summary>
    /// <param name="apiKey">Users api_key</param>
    public Latest(string apiKey)
    {
      List = Info(apiKey, API.cKey);
    }

    /// <summary>
    /// Get images for Latest Shows
    /// </summary>
    /// <param name="apiKey">Users api_key</param>
    /// <param name="clientKey">Users client_key</param>
    public Latest(string apiKey, string clientKey)
    {
        List = Info(apiKey, clientKey);
    }

    /// <summary>
    /// API Result
    /// </summary>
    /// <param name="apiKey">Users api_key</param>
    /// <param name="clientKey">Users client_key</param>
    /// <returns>List of images for Latest Shows</returns>
    private static List<TvLatest> Info(string apiKey, string clientKey)
    {
      try
      {
        List<TvLatest> tmp;
        API.ErrorOccurred = false;
        API.ErrorMessage = string.Empty;

        var json = clientKey != "" ? Helper.Json.GetJson(API.Server + "tv/latest" + "?api_key=" + apiKey) : Helper.Json.GetJson(API.Server + "tv/latest" + "?api_key=" + apiKey + "&client_key=" + clientKey);

        if (API.ErrorOccurred)
          return new List<TvLatest>();

        using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
        {
          var settings = new DataContractJsonSerializerSettings { UseSimpleDictionaryFormat = true };
          var serializer = new DataContractJsonSerializer(typeof(List<TvLatest>), settings);
          tmp = (List<TvLatest>)serializer.ReadObject(ms);
        }
        return tmp ?? new List<TvLatest>();
      }
      catch (Exception ex)
      {
        API.ErrorOccurred = true;
        API.ErrorMessage = ex.Message;
        return new List<TvLatest>();
      }
    }
  }
}
