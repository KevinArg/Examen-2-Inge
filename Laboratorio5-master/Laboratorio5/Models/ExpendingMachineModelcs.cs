using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Laboratorio5.Models
{
    public class ExpendingMachineModel
    {
        public IEnumerable<SupplyModel> supply { get; set; }
        public TransactionModel transaction { get; set; }
    }
    public class SupplyModel
    {
        public string nombre { get; set; }
        public int precio { get; set; }
        public int cantidad { get; set; }
    }
    public class TransactionModel
    {
        public int quantCoca { get; set; }
        public int quantPepsi { get; set; }
        public int quantFanta { get; set; }
        public int quantSprite { get; set; }
    }
}
