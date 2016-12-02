using System.Net;
using HtmlAgilityPack;
using System.Text;
using System.Net.Security;
using System.IO;

namespace DC
{
				class ParserHTML
				{
								public string GetCity(string postCode)
								{
												string downloadString = GetDownloadString(postCode);
												HtmlAgilityPack.HtmlDocument document = GetHtmlDocument(downloadString);
												string city = FindCityInDocument(document);
												return city;
								}

								private string GetDownloadString(string postCode)
								{
												string downloadString = "http://00-000.pl/szukaj.php?k=" + postCode + "&m=&u=";
												return downloadString;
								}

								private HtmlAgilityPack.HtmlDocument GetHtmlDocument(string downloadString)
								{
												WebClient webc = new WebClient();
												string htmlString = webc.DownloadString(downloadString);
												HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
												document.LoadHtml(htmlString);
												return document;
								}

								private string FindCityInDocument(HtmlAgilityPack.HtmlDocument document)
								{
												HtmlNodeCollection nodes = document.DocumentNode.SelectNodes("//td[@class='row']");
												// błąd gdy nodes = null -> powiadomienie że nie istnieje miasto o podanym kodzie
												string city = nodes[2].InnerText;
												string encodedCity = EncodeCity(city);
												return encodedCity;
								}

								private string EncodeCity(string city)
								{
												Encoding pageEncoding = Encoding.GetEncoding("ISO-8859-2");
												Encoding e = Encoding.UTF8;
												byte[] isoBytes = pageEncoding.GetBytes(city);
												byte[] utfBytes = Encoding.Convert(pageEncoding, e, isoBytes);
												string encodedCity = e.GetString(utfBytes);
												return encodedCity;
								}


				}
}
