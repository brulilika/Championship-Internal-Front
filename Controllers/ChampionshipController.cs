using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Championship_Internal_Front.Models;
using Championship_Internal_Front.Models.Request;
using Championship_Internal_Front.Controllers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Syncfusion.JavaScript.DataVisualization.Models.Diagram;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Championship_Internal_Front.Controllers
{
    public class ChampionshipController : Controller
    {
        HttpClient client;

        public ChampionshipController(IHttpClientFactory factory)
        {
            client = factory.CreateClient();
            client = BaseRequest.CreateBaseRequest(client);
        }

        /// <summary>
        /// Get all the registered championships
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> GetAllChampionships()
        {
            try
            {
                HttpResponseMessage response = client.GetAsync("api/championship").Result;
                if (response.IsSuccessStatusCode)
                {
                    var championships = await response.Content.ReadFromJsonAsync<Championship[]>();

                    return View(championships?.ToList());
                }
                else
                {
                    throw new Exception("Ocorreu um erro na listagem!");
                }
            }
            catch (Exception ex)
            {
                return View("_Erro", ex);
            }
        }

        /// <summary>
        /// Search all the informations of a certain championship
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> GetChampionshipsById(Guid id)
        {
            try
            {
                HttpResponseMessage response = client.GetAsync($"api/championship/{id.ToString()}").Result;
                if (response.IsSuccessStatusCode)
                {
                    var championship = await response.Content.ReadFromJsonAsync<Championship>();

                    return View(championship);
                }
                else
                {
                    throw new Exception("Ocorreu um erro na busca!");
                }
            }
            catch (Exception ex)
            {
                return View("_Erro", ex);
            }
        }

        /// <summary>
        /// Create a new championship with minimum information
        /// </summary>
        /// <param name="createChampionship"></param>
        /// <returns></returns>
        public async Task<IActionResult> CreateNewChampionship(CreateChampionship createChampionship)
        {
            try
            {

                HttpResponseMessage response = client.PostAsync(
                    $"api/championship",
                    new StringContent(
                        JsonConvert.SerializeObject(createChampionship),
                        Encoding.UTF8,
                        "application/json")
                ).Result;
                if (response.IsSuccessStatusCode)
                {
                    var name = await response.Content.ReadFromJsonAsync<string>();

                    return View(name);
                }
                else
                {
                    throw new Exception("Ocorreu um erro na listagem!");
                }
            }
            catch (Exception ex)
            {
                return View("_Erro", ex);
            }
        }

        /// <summary>
        /// Update a specific championship information
        /// </summary>
        /// <param name="updateChampionship"></param>
        /// <returns></returns>
        public async Task<IActionResult> UpdateChampionship(Championship updateChampionship)
        {
            try
            {

                HttpResponseMessage response = client.PutAsync(
                    $"api/championship/{updateChampionship.Id}",
                    new StringContent(
                        JsonConvert.SerializeObject(updateChampionship),
                        Encoding.UTF8,
                        "application/json")
                ).Result;
                if (response.IsSuccessStatusCode)
                {
                    var championship = await response.Content.ReadFromJsonAsync<Championship>();

                    return View(championship);
                }
                else
                {
                    throw new Exception("Ocorreu um erro na atualização!");
                }
            }
            catch (Exception ex)
            {
                return View("_Erro", ex);
            }
        }

        /// <summary>
        /// Start or Finish a Championship
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> AlterChampionship(Guid id)
        {
            try
            {
                HttpResponseMessage response = client.GetAsync($"api/championship/status/{id}").Result;
                if (response.IsSuccessStatusCode)
                    return View(response.IsSuccessStatusCode);
                else
                    throw new Exception("Ocorreu um erro na atualização!");
            }
            catch (Exception ex)
            {
                return View("_Erro", ex);
            }
        }

        /// <summary>
        /// Delete a specific championship
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> DeleteChampionship(Guid id)
        {
            try
            {
                HttpResponseMessage response = client.DeleteAsync($"api/championship/{id}").Result;
                if (response.IsSuccessStatusCode)
                    return View(response.IsSuccessStatusCode);
                else
                    throw new Exception("Ocorreu um erro na deleção!");
            }
            catch (Exception ex)
            {
                return View("_Erro", ex);
            }
        }
    }
}

