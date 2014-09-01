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
For Transparent Proxy Set Api.proxy = true

Any Examples:
 * // Set a global Apikey
 * FanartTv.API.Key = "apikey";
 * var album = new FanartTv.Music.Album("9ba659df-5814-32f6-b95f-02b738698e7c");
 * // or use the Key directly
 * var album = new Album("1dc4c347-a1db-32aa-b14f-bc9cc507b843", "apikey");

Artist
 * 	var mo = new FanartTv.Music.Artist("f4a31f0a-51dd-4fa7-986d-3095c40c5ed9");

Movie
 *  var mo0 = new FanartTv.Movies.Movie("10195");
 *  var mo1 = new FanartTv.Movies.Movie("tt0800369");
 *  var mo2 = new FanartTv.Movies.Latest();


