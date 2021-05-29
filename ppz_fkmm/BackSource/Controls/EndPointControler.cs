﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ppz_fkmm.BackSource.Controls;

using System.Net.Http;
//using ppz_fkmm.BackSource.DataModels;


namespace ppz_fkmm.BackSource.EndPoints
{
    class EndPointControler<ModelTemplate>
    {
        public async Task<List<ModelTemplate>> LoadData(string url, HttpControler httpControler)
        {
            using (HttpResponseMessage response = await httpControler.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<ModelTemplate> models = await response.Content.ReadAsAsync<List<ModelTemplate>>();
                    return models;
                }
                throw new Exception(response.ReasonPhrase);
            }
        }
    }
}