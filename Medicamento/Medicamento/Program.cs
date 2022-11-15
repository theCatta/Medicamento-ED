using System;

namespace ED_Medicamento
{
    class Program
    {
        static void Main(string[] args)
        {
            int key;
            Medicamentos medicamentos = new Medicamentos();

            do
            {
                Console.WriteLine(
                  "\n--------------------------------------------------------------------" +
                  "\n| 0. Finalizar processo                                            |" +
                  "\n| 1. Cadastrar medicamento                                         |" +
                  "\n| 2. Consultar medicamento (sintético: informar dados)             |" +
                  "\n| 3. Consultar medicamento (analítico: informar dados + lotes)     |" +
                  "\n| 4. Comprar medicamento (cadastrar lote)                          |" +
                  "\n| 5. Vender medicamento (abater do lote mais antigo)               |" +
                  "\n| 6. Listar medicamentos (informando dados sintéticos)             |" +
                  "\n--------------------------------------------------------------------");

                Console.Write("\nEscolha uma opção: ");
                key = int.Parse(Console.ReadLine());
                Console.Write("\n");                

                switch (key)
                {
                    case 1:
                        Console.WriteLine("Para cadastrar um novo medicamento primeiro é necessário inserir os dados solicitados.");
                        Console.WriteLine("\n");

                        //ID Med (int)
                        Console.WriteLine("Insira o ID do medicamento: ");
                        string idMed = Console.ReadLine();

                        //NOME Med (string)
                        Console.WriteLine("Insira o NOME do medicamento: ");
                        string nomeMed = Console.ReadLine();

                        //LABORATORIO Med (string)
                        Console.WriteLine("Insira o LABORATÓRIO do medicamento: ");
                        string labMed = Console.ReadLine();

                        Medicamento addMed = new Medicamento(int.Parse(idMed), nomeMed, labMed);
                        medicamentos.adicionar(addMed);
                        break;
                    case 2:
                        string c2;

                        Console.WriteLine("Pesquise o medicamento pelo ID: ");
                        c2 = Console.ReadLine();
                        Medicamento pesqMedSint = new Medicamento();
                        pesqMedSint.Id = (int.Parse(c2));
                        pesqMedSint = medicamentos.pesquisar(pesqMedSint);

                        Console.Write(
                        "\nDADOS DO MEDICAMENTO: " +
                        "\nId: " + pesqMedSint.Id +
                        "\nNome: " + pesqMedSint.Nome +
                        "\nLaboratório: " + pesqMedSint.Laboratorio +
                        "\nQuantidade disponível:" + pesqMedSint.qtdeDisponivel());
                        break;
                    case 3:
                        string c3;

                        Console.WriteLine("Pesquise o medicamento pelo ID: ");
                        c3 = Console.ReadLine();
                        Medicamento pesqMedAna = new Medicamento();
                        pesqMedAna.Id = (int.Parse(c3));
                        pesqMedAna = medicamentos.pesquisar(pesqMedAna);

                        Console.Write(
                            "\nDADOS DO MEDICAMENTO: " +
                            "\nId: " + pesqMedAna.Id +
                            "\nNome: " + pesqMedAna.Nome +
                            "\nLaboratório: " + pesqMedAna.Laboratorio +
                            "\nQuantidade disponível:" + pesqMedAna.qtdeDisponivel()
                        );

                        Console.WriteLine("\nDados dos Lotes: ");

                        if(pesqMedAna.Lotes.Count > 0)
                        {
                            string aux;
                            foreach (Lote l in pesqMedAna.Lotes)
                            {
                                aux = l.ToString();
                                Console.Write("\n" + aux);
                            }
                        }
                        break;
                    case 4:
                        string c4;

                        Console.WriteLine("Pesquise o ID do medicamento que deseja comprar: ");
                        c4 = Console.ReadLine();
                        Medicamento pesqMedCompraLote = new Medicamento();
                        pesqMedCompraLote.Id = (int.Parse(c4));
                        pesqMedCompraLote = medicamentos.pesquisar(pesqMedCompraLote);

                        //DADOS DO LOTE
                        Lote Compra = new Lote();

                        //ID Lote (int)
                        Console.WriteLine("Insira o ID do lote: ");
                        c4 = Console.ReadLine();
                        Compra.Id = (int.Parse(c4));

                        //QUANTIDADE Lote (int)
                        Console.WriteLine("Insira a quantidade de medicamentos do lote: ");
                        c4 = Console.ReadLine();
                        Compra.Qtde = (int.Parse(c4));

                        //VENCIMENTO Lote (datetime)                       
                        Console.WriteLine("Dia de vencimento");
                        string dia = Console.ReadLine();
                        Console.WriteLine("Mês de vencimento");
                        string mes = Console.ReadLine();
                        Console.WriteLine("Ano de vencimento");
                        string ano = Console.ReadLine();

                        DateTime venc = new DateTime(1, 1, 1);
                        Compra.Venc = (venc);


                        pesqMedCompraLote.comprar(Compra);
                        break;
                    case 5:
                        string c5;
                        Console.WriteLine("Pesquise o ID do medicamento que deseja vender: ");
                        c5 = Console.ReadLine();
                        Medicamento pesqMedVenda = new Medicamento();
                        pesqMedVenda.Id = (int.Parse(c5));
                        pesqMedVenda = medicamentos.pesquisar(pesqMedVenda);

                        Console.WriteLine("Insira quantas unidades deseja vender: ");
                        c5 = Console.ReadLine();
                        pesqMedVenda.vender(int.Parse(c5));
                        break;
                    case 6:
                        foreach (Medicamento Med in medicamentos.ListaMedicamentos)
                        {
                            Console.WriteLine(Med.toString());
                        }
                        break;
                }
            } while (key != 0);
        }
    }
}