# MeekMoe.Images
MeekMoe API .Net API Client

## Usage
```csharp
using MeekMoe.Images;

var meekClient = new MeekMoeImagesClient();
//Gets a random Hatsune Miku image from the API
var image = await meekClient.GetMoeApiImageAsync(Endpoint.Miku)
```
