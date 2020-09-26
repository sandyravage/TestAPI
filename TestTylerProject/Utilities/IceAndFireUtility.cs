using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TestTylerProject.Models;

namespace TestTylerProject.Utilities
{
    public class IceAndFireUtility
    {
        private HttpClient _client;
        public IceAndFireUtility()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://www.anapioficeandfire.com/");
        }
        public async Task<Character> GetCharacter(int id)
        {
            var result = await _client.GetAsync($"api/characters/{id}");
            var rawCharacter = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Character>(rawCharacter);
        }


    }
}
