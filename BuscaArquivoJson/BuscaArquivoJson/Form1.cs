using BuscaArquivoJson.Model;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json.Serialization;

namespace BuscaArquivoJson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\BANCOJSON\arquivo.json");

            //estratégia comentada usando Runtime
            //var js = new DataContractJsonSerializer(typeof(List<Pessoal>));
            //var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            //var listaPessoal = (List<Pessoal>)js.ReadObject(ms);

            //Usando newton
            var listaPessoal = JsonConvert.DeserializeObject<List<Pessoal>>(json);

            dataGridPessoal.DataSource = listaPessoal;

        }
    }
}