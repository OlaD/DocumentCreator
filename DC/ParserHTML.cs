using System.Net;
using HtmlAgilityPack;

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
												if(nodes == null)
												{
																return "";
												}
												else
												{
																string city = nodes[2].InnerText;
																string encodedCity = EncodeCity(city);
																return encodedCity;
												}
								}

								private string EncodeCity(string city)
								{
												string encodedCity = city.Replace('±', 'ą');
												encodedCity = encodedCity.Replace('¶', 'ś');
												encodedCity = encodedCity.Replace('¦', 'Ś');
												encodedCity = encodedCity.Replace('Ľ', 'ź');
												encodedCity = encodedCity.Replace('¬', 'Ź');
												return encodedCity;
								}


				}
}
