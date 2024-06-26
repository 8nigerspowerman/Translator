using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Translator2
{
    public partial class Form1 : Form
    {
        private const string baseUrl = "https://api.mymemory.translated.net";
        private HttpClient httpClient;

        public Form1()
        {
            InitializeComponent();
            httpClient = new HttpClient();
        }

        private async Task<string> TranslateAsync(string text, string sourceLang, string targetLang)
        {
            string url = $"{baseUrl}/get?q={Uri.EscapeDataString(text)}&langpair={sourceLang}|{targetLang}";

            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseJson = await response.Content.ReadAsStringAsync();
            var translationResult = JsonConvert.DeserializeObject<TranslationResponse>(responseJson);

            if (translationResult.ResponseStatus == 200)
            {
                return translationResult.TranslatedText;
            }

            return string.Empty;
        }

        private void Form1_load(object sender, EventArgs e)
        {
            cmbSourceLanguage.BorderRadius = 20;
            cmbTargetLanguage.BorderRadius = 20;

            cmbSourceLanguage.BorderRadius = 20;
            cmbTargetLanguage.BorderRadius = 20;

            cmbSourceLanguage.Items.AddRange(new string[] { "en", "ru", "es" });
            cmbTargetLanguage.Items.AddRange(new string[] { "en", "ru", "es" });

            cmbSourceLanguage.SelectedIndex = 0;
            cmbTargetLanguage.SelectedIndex = 1;
        }

        private async void Пе_Click(object sender, EventArgs e)
        {
            try
            {
                string translatedText = await TranslateAsync(textinput.Text, cmbSourceLanguage.SelectedItem.ToString(), cmbTargetLanguage.SelectedItem.ToString());
                textoutput.Text = translatedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: \r\n" + ex);
                throw;
            }
        }

        private void cmbTargetLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class TranslationResponse
    {
        [JsonProperty("responseStatus")]
        public int ResponseStatus { get; set; }

        [JsonProperty("responseData")]
        public TranslationData ResponseData { get; set; }

        public string TranslatedText => ResponseData?.TranslatedText;
    }

    public class TranslationData
    {
        [JsonProperty("translatedText")]
        public string TranslatedText { get; set; }

    }
}
