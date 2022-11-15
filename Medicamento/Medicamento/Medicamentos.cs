using System;
using System.Collections.Generic;
using System.Text;

namespace ED_Medicamento
{
    class Medicamentos
    {
        private List<Medicamento> listaMedicamentos;

        internal List<Medicamento> ListaMedicamentos { get => listaMedicamentos; set => listaMedicamentos = value; }

        public Medicamentos()
        {
            ListaMedicamentos = new List<Medicamento>();
        }

        public void adicionar(Medicamento medicamento)
        {
            ListaMedicamentos.Add(medicamento);
        }

        public bool deletar(Medicamento medicamento)
        {
            ListaMedicamentos.Remove(medicamento);
            bool remov = true;

            foreach (Medicamento med in ListaMedicamentos)
            {
                if (med.Equals(medicamento))
                {
                    remov = false;
                    return remov;
                }
            }
            return remov;
        }

        public Medicamento pesquisar(Medicamento medicamento)
        {
            Medicamento aux = new Medicamento();

            foreach (Medicamento med in ListaMedicamentos)
            {
                if (med.Equals(medicamento))
                {

                    aux = med;
                    return aux;
                }
            }
            return aux;
        }

    }
}