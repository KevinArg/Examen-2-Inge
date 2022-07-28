using Laboratorio5.Models;
using System.Text.Json;
namespace Laboratorio5.Handlers
{
    public class ExpendingMachineHandler
    {
        private string rutaConexion;
        public ExpendingMachineHandler()
        {
            var builder = WebApplication.CreateBuilder();
            rutaConexion = builder.Configuration.GetConnectionString("ExpendingMachine");
        }
        public List<SupplyModel> ObtainCurrentSupply()
        {
            string json = File.ReadAllText(rutaConexion);
            return JsonSerializer.Deserialize<List<SupplyModel>>(json);
        }
    }
}
