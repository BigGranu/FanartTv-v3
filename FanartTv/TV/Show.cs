using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using FanartTv.Types;

namespace FanartTv.TV
{
  /// <summary>
  /// Get images for a Show
  /// </summary>
  public class Show
  {
    /// <summary>
    /// List of images for a Show
    /// </summary>
    public TvData List { get; set; }

    /// <summary>
    /// Get images for a Show
    /// </summary>
    /// <param name="theTvBbId">thetvdb id for the show.</param>
    public Show(string theTvBbId)
    {
      List = Info(theTvBbId, API.Key);
    }

    /// <summary>
    /// Get images for a Show
    /// </summary>
    /// <param name="theTvBbId">thetvdb id for the show.</param>
    /// <param name="apiKey">Users api_key</param>
    public Show(string theTvBbId, string apiKey)
    {
      List = Info(theTvBbId, apiKey);
    }

    /// <summary>
    /// API Result
    /// </summary>
    /// <param name="theTvBbId">thetvdb id for the show.</param>
    /// <param name="apiKey">Users api_key</param>
    /// <returns>List of images for a Shows</returns>
    private static TvData Info(string theTvBbId, string apiKey)
    {
      try
      {
        TvData tmp;

        using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(Helper.Json.GetJson(API.Server + "tv/" + theTvBbId + "?api_key=" + apiKey))))
        {
          var settings = new DataContractJsonSerializerSettings { UseSimpleDictionaryFormat = true };
          var serializer = new DataContractJsonSerializer(typeof(TvData), settings);
          tmp = (TvData)serializer.ReadObject(ms);
        }
        return tmp ?? new TvData();
      }
      catch (Exception)
      {
        return new TvData();
      }
    }
  }  
}


