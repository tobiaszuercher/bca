using System;
using System.Net.Http;
using System.Threading.Tasks;
using ServiceStack;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello World!");

		//KeyValueP

		"http://sb.tournamentsoftware.com/ranking/category.aspx"
			.AddQueryParam("id", 12401)
			.AddQueryParam("category", 2338)
			.GetStringFromUrl(responseFilter: httpRes =>
			{
				var remaining = httpRes.Headers["X-Api-Remaining"];
				

			});

		var response = "http://sb.tournamentsoftware.com/ranking/category.aspx"
			.AddQueryParam("id", 12401)
			.AddQueryParam("category", 2338)
			.PostToUrl("ctl00$ctl00$ctl00$cphPage$ddlSearchType=1&ctl00$ctl00$ctl00$cphPage$cphPage$cphPage$dlPublication=12401&tl00$ctl00$ctl00$cphPage$cphPage$cphPage$C2338FOG=79397",
					   requestFilter: (System.Net.HttpWebRequest request) =>
		{
			request.Headers.
		});


		Console.WriteLine(response);
	}

	static async Task MainAsync()
	{
		"http://sb.tournamentsoftware.com/ranking/category.aspx"
			.AddQueryParam("id", 12401)
			.AddQueryParam("category", 2338)
			.GetStringFromUrl();

		var response = "http://sb.tournamentsoftware.com/ranking/category.aspx"
			.AddQueryParam("id", 12401)
			.AddQueryParam("category", 2338)
			.PostToUrl("ctl00$ctl00$ctl00$cphPage$ddlSearchType=1&ctl00$ctl00$ctl00$cphPage$cphPage$cphPage$dlPublication=12401&tl00$ctl00$ctl00$cphPage$cphPage$cphPage$C2338FOG=79397");

		//?id=12401&category=2338".Ge

		//var client = new HttpClient();
		//var response = await client.GetAsync("http://sb.tournamentsoftware.com/ranking/category.aspx?id=12401&category=2338");
		//Console.WriteLine(await response.Content.ReadAsStringAsync());

		//var body = new MultipartFormDataContent();
		
		//client.PostAsync
	}
}
