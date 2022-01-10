using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 6.Escreva um programa que calcule a nota média de cada aluno e a média da turma.O
             * programa deve receber o nome do aluno e a nota de cada bimestre(4 notas), ao
             * informar no nome do aluno o valor “finalizar” o programa deve realizar os cálculos da
             * média e apresentar na tela
             * */

            try
            {
                Console.Title = "Questão 6";
                ExecutarPrograma();
            }
            catch (Exception ex)
            {
                Console.Clear();
                string msg = string.Format("{0} \n\n" +
                    "localização do erro:\n\n{1}",
                    ex.Message, ex.StackTrace);
                MessageBox.Show(msg, "Erro no programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Reiniciando Programa", string.Empty ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main(args);
            }
        }

        public static void ExecutarPrograma()
        {
            string nomeAluno;
            List<string> nomeAlunos = new List<string>();
            float mediaTurma;
            float[] notasBimestre = new float[4];
            List<float> mediaAlunos = new List<float>();

            do
            {
                Console.Write(string.Format("Informe o nome do {0}º Aluno ou \"finalizar\" para encerrar a adição de alunos e notas: ", nomeAlunos.Count + 1));
                nomeAluno = Console.ReadLine().Trim();

                if (nomeAluno != "finalizar")
                {
                    nomeAlunos.Add(nomeAluno);

                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write(string.Format("Informe a nota do {0}º Bimestre: ", i + 1));
                        float notaTemp = float.Parse(Console.ReadLine().Trim());

                        if (notaTemp < 0 || notaTemp > 10)
                        {
                            while (notaTemp < 0 || notaTemp > 10)
                            {
                                Console.WriteLine("As notas são apenas de 0 a 10!");
                                Console.Write(string.Format("Informe novamente a nota do {0}º Bimestre: ", i + 1));
                                notaTemp = float.Parse(Console.ReadLine().Trim());
                                if (notaTemp >= 0 && notaTemp <= 10)
                                {
                                    notasBimestre[i] = notaTemp;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            notasBimestre[i] = notaTemp;
                        }
                    }

                    mediaAlunos.Add(notasBimestre.Average());
                    Console.Clear();
                }
                else
                {
                    Console.Clear();

                    if (nomeAlunos.Count > 0)
                    {
                        Console.WriteLine("====Média dos Alunos informados====");
                        for (int i = 0; i < nomeAlunos.Count; i++)
                        {
                            Console.WriteLine(string.Format("A média do aluno {0} é: {1}", nomeAlunos[i], mediaAlunos[i].ToString("f1")));
                        }

                        Console.WriteLine("\n====Média da Turma====");
                        mediaTurma = mediaAlunos.Average();
                        Console.WriteLine(string.Format("A média da turma é: {0}", mediaTurma.ToString("f1")));
                        Console.ReadKey();
                    }
                    break;
                }
            } while (true);
        }
    }
}