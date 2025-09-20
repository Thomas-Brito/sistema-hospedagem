using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema_de_Hospedagem.Models;

namespace Sistema_de_Hospedagem.Models
{
  public class Suite
  {
    public string TipoSuite { get; set; }
    public int Capacidade { get; set; }
    public decimal ValorDiaria { get; set; }
  }
    
}