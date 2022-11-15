using System;
using System.Collections.Generic;
using System.Text;

namespace ED_Medicamento
{
    class Lote
    {
        private int id;
        private int qtde;
        private DateTime venc;

        public int Id { get => id; set => id = value; }
        public int Qtde { get => qtde; set => qtde = value; }
        public DateTime Venc { get => venc; set => venc = value; }

        public Lote()
        {
            Id = -1;
        }

        public Lote(int id, int qtde, DateTime venc)
        {
            Id = id;
            Qtde = qtde;
            Venc = venc;
        }

        public string ToString()
        {
            return "Id: " + Id + " - Quantidade: " + Qtde + " - Data de vencimento: " + Venc;
        }
    }
}