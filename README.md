FANART.TV
==========

.Net data bindings for [FANART.TV](http://fanart.tv/)

The Features are:
 * Search Music
	* Artist
	* Album
	* Label
	* Latest Images
 * Search Movie
	* Movies
	* Latest Images
 * Search TV
	* Tv Show
	* Latest Images

For an APIKey go to [FANART.TV](http://fanart.tv/get-an-api-key/)

Any Examples:
 * // Set a global Apikey
 * FanartTv.API.Key = "apikey";
 * // For Transparent Proxy
 * FanartTv.Api.proxy = true


Music
 * var album = new FanartTv.Music.Album("9ba659df-5814-32f6-b95f-02b738698e7c");
 * var artist = new FanartTv.Music.Artist("f4a31f0a-51dd-4fa7-986d-3095c40c5ed9");
 * // or use the Key directly
 * var album = new Album("1dc4c347-a1db-32aa-b14f-bc9cc507b843", "apikey");
 * var label = new FanartTv.Music.Label("e832b688-546b-45e3-83e5-9f8db5dcde1d");
 * var latest = new FanartTv.Music.Latest("91b020d36e832bf14efc3a33c165994e");

Movie
 *  var mo0 = new FanartTv.Movies.Movie("10195");
 *  var mo1 = new FanartTv.Movies.Movie("tt0800369");
 *  var mo2 = new FanartTv.Movies.Latest();

TV
 *  var tv0 = new FanartTv.TV.Show("75682");
 *  var tv1 = new FanartTv.TV.Latest();

