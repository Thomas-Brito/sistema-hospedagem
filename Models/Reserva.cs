using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema_de_Hospedagem.Models;

namespace Sistema_de_Hospedagem.Models
{
  public class Reserva
  {
    public List<Pessoa> Hospedes { get; private set; }
    public Suite Suite { get; private set; }
    public int DiasReservados { get; set; }
    
    public Reserva()
    {
      Hospedes = new List<Pessoa>();
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
      if (Suite == null)
      {
          throw new InvalidOperationException("A suíte deve ser cadastrada antes de adicionar hóspedes.");
      }

      if (Suite.Capacidade >= hospedes.Count)
      {
          Hospedes = hospedes;
      }
      else
      {
          throw new InvalidOperationException("A quantidade de hóspedes excede a capacidade da suíte.");
      }
    }

    public void CadastrarSuite(Suite suite)
    {
      Suite = suite;
    }

    public int ObterQuantidadeHospedes() => Hospedes.Count;

    public decimal CalcularValorDiaria()
    {
      if (Suite == null)
      {
        throw new InvalidOperationException("A suíte deve ser cadastrada antes de calcular o valor da diária.");
      }

      if (DiasReservados > 10)
      {
        return Suite.ValorDiaria * DiasReservados * 90 / 100;
      }
      else
      {
        return Suite.ValorDiaria * DiasReservados;
      }
    }
  }
}