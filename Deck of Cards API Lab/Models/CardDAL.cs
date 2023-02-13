using System;
using Newtonsoft.Json;
using System.Net;

namespace Deck_of_Cards_API_Lab.Models
{
	public class CardDAL
	{
        public static CardModel GetCards(string id)
        {
            //Setup
            string url = $"https://deckofcardsapi.com/api/deck/{id}/draw/?count=5";

            //Request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Convert it to JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //Convert to C#
            CardModel result = JsonConvert.DeserializeObject<CardModel>(JSON);
            return result;
        }

        public static CardModel Reshuffle(string id)
        {
            {
                //Setup
                string url = $"https://deckofcardsapi.com/api/deck/{id}/shuffle/";

                //Request
                HttpWebRequest request = WebRequest.CreateHttp(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                //Convert it to JSON
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string JSON = reader.ReadToEnd();

                //Convert to C#
                CardModel result = JsonConvert.DeserializeObject<CardModel>(JSON);
                return result;
            }
        }
    }
}

