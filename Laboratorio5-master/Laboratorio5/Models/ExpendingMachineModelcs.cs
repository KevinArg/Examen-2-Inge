using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Laboratorio5.Models
{
    public class ExpendingMachineModel
    {
        public string nombre { get; set; }
        public int precio { get; set; }
        public int cantidad { get; set; }
    }
}
