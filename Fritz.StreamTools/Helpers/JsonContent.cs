﻿using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace Fritz.StreamTools.Helpers
{
	public class JsonContent : StringContent
  {
		public JsonContent(object data)
			: base(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json")
		{
		}
  }
}
