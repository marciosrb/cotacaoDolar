using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Net.Http;
using System.Windows.Forms;

namespace CotacaoDolarMS
{
    public partial class FrmCotacaoDolar : Form
    {
        public FrmCotacaoDolar()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var strURL = "https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,USD&key=d6df8014"; //criar contla no hpgbrasil e alterar a chave
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = client.GetAsync(strURL).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;
                        Market market = JsonConvert.DeserializeObject<Market>(result);

                        lblBuy.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", market.Currency.Buy);
                        lblSell.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", market.Currency.Sell);
                        lblVar.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:P}", market.Currency.Variation / 100);
                    }
                    else
                    {
                        lblBuy.Text = "_";
                        lblSell.Text = "_";
                        lblVar.Text = "_";
                    }
                }
                catch (Exception ex)
                {
                    lblBuy.Text = "_";
                    lblSell.Text = "_";
                    lblVar.Text = "_";

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}