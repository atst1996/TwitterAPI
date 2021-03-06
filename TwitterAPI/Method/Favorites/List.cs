﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TwitterAPI
{
    public abstract partial class TwitterFavorites
    {

		public static TwitterResponse<TwitterStatus> List(OAuthTokens tokens, FavoritesListOptions options)
		{
			var res = Method.Get(UrlBank.FavoritesList, tokens, options);
			throw new Exception("未実装");
			return null;
		}

    }

    public class FavoritesListOptions : ParameterClass
    {
		[Parameters("user_id")]
        public decimal? UserId { get; set; }

		[Parameters("screen_name")]
        public string ScreenName { get; set; }

		[Parameters("count")]
        public int? Count { get; set; }

		[Parameters("since_id")]
		public decimal? SinceId { get; set; }

		[Parameters("max_id")]
		public decimal? MaxId { get; set; }

		[Parameters("include_entities")]
		public bool? IncludeEntities { get; set; }
    }
}
