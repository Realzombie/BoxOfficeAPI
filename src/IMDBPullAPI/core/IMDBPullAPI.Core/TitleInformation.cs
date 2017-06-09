using System.Collections.Generic;
using Newtonsoft.Json;

namespace IMDBPullAPI.Core
{
    public class TitleInformation
    {
        [JsonProperty("title_popular")]
        public IList<Title_Popular> PopularTitles { get; set; }
        [JsonProperty("title_exact")]
        public IList<Title_Exact> ExactTitles { get; set; }
    }

    public class Title_Popular
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("title_description")]
        public string Title_Description { get; set; }
        [JsonProperty("episode_title")]
        public string Episode_Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        //public IList<IndividualTitle> Titles { get; set; }
    }

    public class Title_Exact
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("title_description")]
        public string Title_Description { get; set; }
        [JsonProperty("episode_title")]
        public string Episode_Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        //public IList<IndividualTitle> Titles { get; set; }
    }

    public class IndividualTitle
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("title_description")]
        public string Title_Description { get; set; }
        [JsonProperty("episode_title")]
        public string Episode_Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
