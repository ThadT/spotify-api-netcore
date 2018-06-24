# Spotify API Wrapper for .NET Standard

Cross Platform .NET Spotify API Library

## Getting Started

Install Package on Nuget

```
Install-Package Spotify.API.NetCore
```

or

```
dotnet add package Spotify.API.NetCore
```

## How to use

### Authentication

### Albums

* #### GetAlbumTracks
Get Spotify catalog information about an album's tracks. Optional parameters can be used to limit the number of tracks returned.

**Paramters**  

|Name|Description|Example|
|--------------|-------------------------|-------------------------|
|id| The Spotify ID for the album. | `"5O7V8l4SeXTymVp3IesT9C"`
|[limit]| The maximum number of items to return. Default: 20. Minimum: 1. Maximum: 50. | `20`
|[offset]| The index of the first track to return. Default: 0 (the first object). | `0`
|[market]| An ISO 3166-1 alpha-2 country code. Provide this parameter if you want to apply Track Relinking. | `"DE"`

Returns a SimpleTrack wrapped inside a Paging-object

**Usage**  

```cs
var tracks = _spotify.GetAlbumTracks("album-id");
tracks.Items.ForEach(item => Console.WriteLine(item.Name));
```

* #### GetAlbum

Get Spotify catalog information for a single album.

**Paramters**  

|Name|Description|Example|
|--------------|-------------------------|-------------------------|
|id| The Spotify ID for the album. | `5O7V8l4SeXTymVp3IesT9C`
|[market]| An ISO 3166-1 alpha-2 country code. Provide this parameter if you want to apply Track Relinking. | `"DE"`

Returns a FullAlbum

**Usage**  
```cs
var album = _spotify.GetAlbum("album-id");
Console.WriteLine(album.Name + "| Popularity: " + album.Popularity);
```


* #### GetSeveralAlbums

### Artists

* #### GetArtist
* #### GetRelatedArtists
* #### GetArtistsTopTracks
* #### GetArtistsAlbums
* #### GetSeveralArtists

### Browse

* #### GetFeaturedPlaylists
* #### GetNewAlbumReleases
* #### GetCategories
* #### GetCategory
* #### GetCategoryPlaylists

### Follow

* #### Follow
* #### Unfollow
* #### IsFollowing
* #### FollowPlaylist
* #### UnfollowPlaylist
* #### IsFollowingPlaylist

### Library

* #### SaveTracks
* #### SaveTrack
* #### GetSavedTracks
* #### RemoveSavedTracks
* #### CheckSavedTracks
* #### SaveAlbums
* #### SaveAlbum
* #### GetSavedAlbums
* #### RemoveSavedAlbums
* #### CheckSavedAlbums

### Player

* #### GetDevices
* #### GetPlayback
* #### GetPlayingTrack
* #### TransferPlayback
* #### ResumePlayback
* #### PausePlayback
* #### SkipPlaybackToNext
* #### SkipPlaybackToPrevious
* #### SetRepeatMode
* #### SetVolume
* #### SetShuffle

### Playlists

* #### GetUserPlaylists
* #### GetPlaylist
* #### GetPlaylistTracks
* #### CreatePlaylist
* #### UpdatePlaylist
* #### ReplacePlaylistTracks
* #### RemovePlaylistTracks
* #### RemovePlaylistTrack
* #### AddPlaylistTracks
* #### AddPlaylistTrack
* #### ReorderPlaylist

### Profiles

* #### GetPublicProfile
* #### GetPrivateProfile

### Search

* #### SearchItems

### Tracks

* #### GetSeveralTracks
* #### GetTrack

## Demo

Coming soon...

## Contribution

* If you want to contribute to codes, create pull request
* If you find any bugs or error, create an issue

## License

This project forked from [Spotify-API-NET](https://github.com/JohnnyCrazy/SpotifyAPI-NET) and changed architecture and made Cross Platform. And also previous project just helped for API Map

This project is licensed under the MIT License


