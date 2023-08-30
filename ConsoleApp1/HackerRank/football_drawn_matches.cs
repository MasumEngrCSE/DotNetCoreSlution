//using RestSharp;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

class fdmResult
{

    /*
     * Complete the 'getNumDraws' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER year as parameter.
     */

    public int getNumDraws(int year)
    {

        //int totM = GetDrawnMatchesCount(year).Result;


        //return totM;


        try
        {
            var lstYM = new List<Data>();

            using (var client = new HttpClient())
            {
                var baseAddress = "https://jsonmock.hackerrank.com/api/";
                client.Timeout = TimeSpan.FromMinutes(20000);
                client.BaseAddress = new Uri(baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Program.SSlCertificateApply();
                //System.Net.ServicePointManager.ServerCertificateValidationCallback =
                // delegate (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                // {
                //     return true;
                // };

                var postTask = client.GetAsync($"football_matches?year={year}");
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    Task<string> readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    var resultMain = JsonConvert.DeserializeObject<fdmRoot>(readTask.Result.ToString());

                    #region All mathches in the year
                    lstYM.AddRange(resultMain.data);
                    for (int i = 2; i < resultMain.total_pages; i++)
                    {
                        #region Call Api

                        var callApi = client.GetAsync($"football_matches?year={year}&page={i}");
                        callApi.Wait();

                        var resultYPM = callApi.Result;
                        if (resultYPM.IsSuccessStatusCode)
                        {
                            Task<string> readTaskYPM = result.Content.ReadAsStringAsync();
                            readTaskYPM.Wait();
                            var YPMData = JsonConvert.DeserializeObject<fdmRoot>(readTaskYPM.Result.ToString());
                            lstYM.AddRange(YPMData.data);
                        }
                        #endregion
                    }
                    #endregion
                }
            }

            int retval = lstYM.Where(p => p.team1goals == p.team2goals).Count();

            //Console.WriteLine($"retval:{retval}");

            return retval;
        }
        catch (Exception ex)
        {
            //Console.WriteLine($"Exception:{ex}");
            throw ex;
        }
   
    
    
    }


    public async Task<int> GetDrawnMatchesCount(int year)
    {
        int totalCount = 0;
        int totalPages = 1;
        int currentPage = 1;

        try
        {
            List<Data> matches = new List<Data>();

            // Fetch the first page of matches
            fdmRoot resultMain = await GetMatchesByYear(year, currentPage);
            if (resultMain != null)
            {
                matches.AddRange(resultMain.data);
                totalPages = resultMain.total_pages;
            }

            // Fetch remaining pages of matches (if available)
            while (currentPage < totalPages)
            {
                currentPage++;
                fdmRoot resultYPM = await GetMatchesByYear(year, currentPage);
                if (resultYPM != null)
                {
                    matches.AddRange(resultYPM.data);
                }
            }

            // Calculate the count of drawn matches
            totalCount = matches.Count(p => p.team1goals == p.team2goals);
        }
        catch (Exception ex)
        {
            // Handle exceptions appropriately
            throw ex;
        }

        return totalCount;
    }

    private async Task<fdmRoot> GetMatchesByYear(int year, int page)
    {
        string url = $"football_matches?year={year}&page={page}";
        var baseAddress = "https://jsonmock.hackerrank.com/api/";
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri(baseAddress);

            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<fdmRoot>(responseBody);
            }
            return null;
        }
    }




}

class fdmSolution
{
    public void initialCall()
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        int result = new fdmResult().getNumDraws(year);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}


public class Data
{
    public string competition { get; set; }
    public int year { get; set; }
    public string round { get; set; }
    public string team1 { get; set; }
    public string team2 { get; set; }
    public string team1goals { get; set; }
    public string team2goals { get; set; }
}

public class fdmRoot
{
    public int page { get; set; }
    public int per_page { get; set; }
    public int total { get; set; }
    public int total_pages { get; set; }
    public List<Data>? data { get; set; }
}