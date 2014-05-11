﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core;

using Newtonsoft.Json;

namespace TwitterAPI
{
    public abstract class TwitterSearch
    {
        private static string Url_Serach_Tweets = "https://api.twitter.com/1.1/search/tweets.json";

        public static TwitterResponse<TwitterSearchCollection> Search(OAuthTokens tokens)
        {
            return Search(tokens);
        }

        public static TwitterResponse<TwitterSearchCollection> Search(OAuthTokens tokens, TwitterSearchOptions Options = null)
        {
            ResponseResult result = Method.Get(Url_Serach_Tweets, tokens, Options);

            return new TwitterResponse<TwitterSearchCollection>(result);
        }

        /// <summary>
        /// 検索オプション
        /// </summary>
        public class TwitterSearchOptions : ParameterClass
        {
            /// <summary>
            /// 検索する文字列
            /// </summary>
            [Parameters("q")]
            public string SearchText { get; set; }

            /// <summary>
            /// 検索結果を表示する件数
            /// </summary>
            [Parameters("count")]
            public int? Count { get; set; }

            [Parameters("since_id")]
            public decimal? SinceId { get; set; }

            [Parameters("max_id")]
            public decimal? MaxId { get; set; }

            [Parameters("include_entities")]
            public bool? IncludeIntities { get; set; }
        }
    }
}
