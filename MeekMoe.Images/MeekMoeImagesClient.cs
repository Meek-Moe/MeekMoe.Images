using MeekMoe.Images.Entities;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MeekMoe.Images
{
    public class MeekMoeImagesClient
    {
        private readonly HttpClient _httpClient;

        /// <summary>
        /// Initialize with your own HttpClient, you may create more instances that way
        /// </summary>
        /// <param name="httpClient">Your own HttpClient</param>
        public MeekMoeImagesClient(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        /// <summary>
        /// Initialize without your own HttpClient, its recommended to only create one instance of this and reuse the object
        /// </summary>
        public MeekMoeImagesClient()
        {
            this._httpClient = new HttpClient();
        }

        /// <summary>
        /// Get a random MeekMoeImage from a specific endpoint
        /// </summary>
        /// <param name="endpoint">Endpoint to query</param>
        /// <returns>MeekMoeImage</returns>
        public async Task<MeekMoeImage> GetMoeApiImageAsync(Endpoint endpoint)
        {
            var urlEndpoint = "";
            switch (endpoint)
            {
                case Endpoint.ProjectDiva:
                    urlEndpoint = "diva";
                    break;
                case Endpoint.KagamineRin:
                    urlEndpoint = "rin";
                    break;
                case Endpoint.OtomachiUna:
                    urlEndpoint = "una";
                    break;
                case Endpoint.Gumi:
                    urlEndpoint = "gumi";
                    break;
                case Endpoint.MegurineLuka:
                    urlEndpoint = "luka";
                    break;
                case Endpoint.IA:
                    urlEndpoint = "ia";
                    break;
                case Endpoint.Fukase:
                    urlEndpoint = "fukase";
                    break;
                case Endpoint.HatsuneMiku:
                    urlEndpoint = "miku";
                    break;
                case Endpoint.KagamineLen:
                    urlEndpoint = "len";
                    break;
                case Endpoint.Kaito:
                    urlEndpoint = "kaito";
                    break;
                case Endpoint.KasaneTeto:
                    urlEndpoint = "teto";
                    break;
                case Endpoint.Meiko:
                    urlEndpoint = "meiko";
                    break;
                case Endpoint.YuzukiYukari:
                    urlEndpoint = "yukari";
                    break;
                case Endpoint.SFA2Miki:
                    urlEndpoint = "miki";
                    break;
                case Endpoint.Lily:
                    urlEndpoint = "lily";
                    break;
                case Endpoint.Mayu:
                    urlEndpoint = "mayu";
                    break;
                case Endpoint.AokiLapis:
                    urlEndpoint = "aoki";
                    break;
                case Endpoint.Zola:
                    urlEndpoint = "zola";
                    break;
                default:
                    return default;
            }
            var json = await this._httpClient.GetStringAsync("https://api.meek.moe/" + urlEndpoint);
            return JsonConvert.DeserializeObject<MeekMoeImage>(json);
        }
    }

    /// <summary>
    /// Endpoint list, may be updated with more endpoint when more get added
    /// </summary>
    public enum Endpoint
    {
        ProjectDiva,
        KagamineRin,
        OtomachiUna,
        Gumi,
        MegurineLuka,
        IA,
        Fukase,
        HatsuneMiku,
        KagamineLen,
        Kaito,
        KasaneTeto,
        Meiko,
        YuzukiYukari,
        SFA2Miki,
        Lily,
        Mayu,
        AokiLapis,
        Zola
    }
}
