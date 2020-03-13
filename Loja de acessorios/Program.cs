using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSEYAEROacessorios
{
    class Program
    {
        static void Main(string[] args)
        {
            string vnome;
            string vgenero;
            string[] vtcod = new string[10];
            string[] vtproduto = new string[10];
            double[] vtvalor = new double[10];
            int[] vtestoque = new int[10];
            int vvendido;
            int indice;
            double vpagar;
            double vimposto;
            string vcont;
            double vtotal;
            string vconf;
            int vcontador;
            string[] vtcomprado = new string[30];
            int[] vtcompradovendido = new int[30];
            int vcontadorcontando;



            vtcod[0] = "1";
            vtcod[1] = "2";
            vtcod[2] = "3";
            vtcod[3] = "4";
            vtcod[4] = "5";
            vtcod[5] = "6";
            vtcod[6] = "7";
            vtcod[7] = "8";
            vtcod[8] = "9";
            vtcod[9] = "10";

            vtproduto[0] = "colares";
            vtproduto[1] = "turbantes";
            vtproduto[2] = "pulseiras";
            vtproduto[3] = "aneis";
            vtproduto[4] = "pentes";
            vtproduto[5] = "cordões";
            vtproduto[6] = "brincos";
            vtproduto[7] = "argolas";
            vtproduto[8] = "piercings";
            vtproduto[9] = "arcos";

            vtvalor[0] = 10;
            vtvalor[1] = 20;
            vtvalor[2] = 30;
            vtvalor[3] = 40;
            vtvalor[4] = 50;
            vtvalor[5] = 60;
            vtvalor[6] = 70;
            vtvalor[7] = 80;
            vtvalor[8] = 90;
            vtvalor[9] = 100;

            vtestoque[0] = 100;
            vtestoque[1] = 100;
            vtestoque[2] = 100;
            vtestoque[3] = 100;
            vtestoque[4] = 100;
            vtestoque[5] = 100;
            vtestoque[6] = 100;
            vtestoque[7] = 100;
            vtestoque[8] = 100;
            vtestoque[9] = 100;

            Console.WriteLine("+++++++++++++++-----------------------------------------------------------------++++++++++++++");
            Console.WriteLine("");
            Console.WriteLine("----------++++++++++                     ABS EYA ERO                     +++++++++++----------");
            Console.WriteLine("");
            Console.WriteLine("                                      VIEMOS PARA ARRAZAR!");
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++-----------------------------------------------------------------++++++++++++++");
            Console.ReadKey();
            Console.WriteLine("                                         SEJA BEM VINDO");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("           Digite o seu nome: ");
            vnome = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("           Digite 1 para Masculino ou 2 Para Feminino. ");
            vgenero = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();




            if (vgenero == "1")
            {
                Console.WriteLine("Olá meu amigo " + vnome + " vamos as Compras na ABS EYA ERO? ");
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine();



                vcont = "s";
                vtotal = 0;
                vcontador = 0;
                while (vcont == "s" || vcont == "S")
                {

                    Console.WriteLine(" Temos essas opções de produtos em estoque: ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("         PRODUTO                        PREÇO R$          QUANTIDADE EM ESTOQUE");
                    Console.WriteLine("    Código 1:  Colar                     " + vtvalor[0] + ",00                  " + vtestoque[0]);
                    Console.WriteLine("    Código 2:  Turbante                  " + vtvalor[1] + ",00                  " + vtestoque[1]);
                    Console.WriteLine("    Código 3:  Pulseira                  " + vtvalor[2] + ",00                  " + vtestoque[2]);
                    Console.WriteLine("    Código 4:  Anel                      " + vtvalor[3] + ",00                  " + vtestoque[3]);
                    Console.WriteLine("    Código 5:  Pente                     " + vtvalor[4] + ",00                  " + vtestoque[4]);
                    Console.WriteLine("    Código 6:  Cordao                    " + vtvalor[5] + ",00                  " + vtestoque[5]);
                    Console.WriteLine("    Código 7:  Brinco                    " + vtvalor[6] + ",00                  " + vtestoque[6]);
                    Console.WriteLine("    Código 8:  Argola                    " + vtvalor[7] + ",00                  " + vtestoque[7]);
                    Console.WriteLine("    Código 9:  Piercing                  " + vtvalor[8] + ",00                  " + vtestoque[8]);
                    Console.WriteLine("    Código 10: Arco                     " + vtvalor[9] + ",00                  " + vtestoque[9]);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();



                    Console.Write("             Digite o código do produto escolhido: ");
                    indice = int.Parse(Console.ReadLine()) - 1;
                    Console.WriteLine();

                    Console.Write("             Digite a quantidade do produto escolhido: ");
                    vvendido = int.Parse(Console.ReadLine());



                    if (vvendido == 0)   // TENTOU COMPRAR 0 PRODUTOS
                    {
                        Console.WriteLine("         Voçê não comprou nada, idiota, escolha pelo menos um item. AJUDA NOIZ");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("         Querido " + vnome + ", Digite S (sim) se você quer continuar comprando: ");
                        vcont = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                    }



                    if (vvendido > 0 && vvendido <= vtestoque[indice])   // COMPROU DENTRO DO LIMITE DO ESTOQUE
                    {
                        vpagar = vvendido * vtvalor[indice];
                        Console.WriteLine("         Você confirma a compra no valor de R$ " + vpagar + " reais?");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("         Digite S(sim) ou N(nao).");
                        vconf = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine();

                        if (vconf == "S" || vconf == "s") // CONFIRMAÇÃO DA COMPRA ACIMA
                        {
                            vtcomprado[vcontador] = vtproduto[indice];    // SALVA O nome do produto
                            vtcompradovendido[vcontador] = vvendido;     // SALVA A quantidade do produto COMPARDO ACIMA


                            vcontador = vcontador + 1;  // SALVA A QUANTIDADE DE COMPRAS DE PRODUTOS DIFERENTES 
                            vtestoque[indice] = vtestoque[indice] - vvendido; // ATUALIZAÇÃO DO ESTOQUE 
                            vtotal = vtotal + vpagar;   // ATUALIZA E SALVA O VALOR DE CADA COMPRA FEITA ACIMA  


                            Console.WriteLine();
                            Console.WriteLine();

                            Console.Write("          " + vnome + ", nessa compra voce escolheu " + vvendido + " {0}, no valor de  R$ " + vpagar + " reais.", vtproduto[indice]);
                            Console.WriteLine();
                            Console.WriteLine();

                            Console.WriteLine("-----------------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();


                            Console.Write("         Querido " + vnome + ", Digite S (sim) se você quer continuar comprando: ");
                            vcont = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();


                            if (vcont == "n" || vcont == "N")   // essa é a resposta final  NÃO QUER MAIS CONTINUAR COMPRANDO
                            {
                                vimposto = vpagar * 0.09;  //calculo do imposto
                                Console.Write("         Parabens  meu TRUTA " + vnome + " voce comprou:"); // " + vvendido + " {0}, e vai pagar  R$ " + vtotal + " reais.", vtproduto[indice]);
                                vcontadorcontando = 0;
                                while (vcontadorcontando <= vcontador - 1)  // esse laço lista todos os ítens comprados
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("         " + vtcomprado[vcontadorcontando] + " e " + vtcompradovendido[vcontadorcontando] + " peças.");
                                    vcontadorcontando = vcontadorcontando + 1; // ele sai do laço quando o consumidor para de comprar 
                                }
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("           Você pagará R$ " + vtotal + " reais, sendo R$ " + vimposto + " reais em impostos para o GOVERNO!!!!! ");
                            }
                            Console.WriteLine();        // fim do  segundo while 
                        }



                        if (vconf == "N" || vconf == "n") // não confirma a última compra feita 
                        {
                            Console.Write("         Compra cancelada. " + vnome + ", Digite S (sim) se você quer comprar outro produto: ");
                            vcont = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine();

                            if ((vcont == "n" || vcont == "N") && vcontador != 0)   //  não confirma a última compra e não quer continuar comprando
                                                                                    // MAS COMPROU ALGUMA COISA
                            {
                                vimposto = vpagar * 0.09;
                                vcontadorcontando = 0;
                                Console.Write("         Parabens  meu TRUTA " + vnome + " voce comprou:");
                                Console.WriteLine();

                                while (vcontadorcontando <= vcontador - 1) // LISTA OS ÍTENS COMPRADOS
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("          " + vtcomprado[vcontadorcontando] + " e " + vtcompradovendido[vcontadorcontando] + " peças.");
                                    vcontadorcontando = vcontadorcontando + 1;
                                } // saiu do segundo while



                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("            Você pagará R$ " + vtotal + " reais, sendo R$ " + vimposto + " reais em impostos para o GOVERNO!!!!! ");
                            }




                            if ((vcont == "n" || vcont == "N") && vcontador == 0)   //  ele fez apenas uma pesquisa de preço   NÃO COMPROU, MAS ESCOLHEU ALGUM PRODUTO
                            {
                                Console.WriteLine("         Obrigado pela pesquisa, estamos a sua disposição " + vnome);

                            }
                            Console.WriteLine();
                            Console.WriteLine();



                        }  // FIM DO SE : NÃO CONFIRMA A ULTIMA COMPRA FEITA
                    }  // FIM DO SE:  COMPRA DENTRO DO LIMITE DE ESTOQUE

                    if (vvendido > vtestoque[indice])  // TENTA COMPRAR ACIMA DA QUANTIDADE DISPONÍVEL
                    {
                        Console.WriteLine();
                        Console.WriteLine("         Nao temos mais " + vtproduto[indice] + " no estoque, temos apenas " + vtestoque[indice] + " unidades.");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("         Querido" + vnome + " escolha " + vtestoque[indice] + " unidades ou menos, mas continue em comprando!!");
                        Console.Write("         Digite S (sim) se você quer continuar comprando: ");
                        vcont = Console.ReadLine();
                    }

                } //   fim do if: confirmação de compra



            }   //  fim do if: gênero




            //---------------------------FEMININO-----------AINDA NÃO ESTÁ PRONTO-------------------------------------------------------------------------------------------------------------------------

            if (vgenero == "2")
            {
                Console.WriteLine("Olá Minha amiga " + vnome + " vamos as Compras na ABS EYA ERO? ");
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine();



                vcont = "s";
                vtotal = 0;
                vcontador = 0;
                while (vcont == "s" || vcont == "S")
                {

                    Console.WriteLine(" Temos essas opções de produtos em estoque: ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("         PRODUTO                        PREÇO R$          QUANTIDADE EM ESTOQUE");
                    Console.WriteLine("    Código 1:  Colar                     " + vtvalor[0] + ",00                  " + vtestoque[0]);
                    Console.WriteLine("    Código 2:  Turbante                  " + vtvalor[1] + ",00                  " + vtestoque[1]);
                    Console.WriteLine("    Código 3:  Pulseira                  " + vtvalor[2] + ",00                  " + vtestoque[2]);
                    Console.WriteLine("    Código 4:  Anel                      " + vtvalor[3] + ",00                  " + vtestoque[3]);
                    Console.WriteLine("    Código 5:  Pente                     " + vtvalor[4] + ",00                  " + vtestoque[4]);
                    Console.WriteLine("    Código 6:  Cordao                    " + vtvalor[5] + ",00                  " + vtestoque[5]);
                    Console.WriteLine("    Código 7:  Brinco                    " + vtvalor[6] + ",00                  " + vtestoque[6]);
                    Console.WriteLine("    Código 8:  Argola                    " + vtvalor[7] + ",00                  " + vtestoque[7]);
                    Console.WriteLine("    Código 9:  Piercing                  " + vtvalor[8] + ",00                  " + vtestoque[8]);
                    Console.WriteLine("    Código 10: Arco                     " + vtvalor[9] + ",00                  " + vtestoque[9]);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();



                    Console.Write("             Digite o código do produto escolhido: ");
                    indice = int.Parse(Console.ReadLine()) - 1;
                    Console.WriteLine();

                    Console.Write("             Digite a quantidade do produto escolhido: ");
                    vvendido = int.Parse(Console.ReadLine());



                    if (vvendido == 0)   // TENTOU COMPRAR 0 PRODUTOS
                    {
                        Console.WriteLine("         Voçê não comprou nada, maravilhosa, escolha pelo menos um item. AJUDA AS MINA");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("         Querida " + vnome + ", Digite S (sim) se você quer continuar comprando: ");
                        vcont = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                    }



                    if (vvendido > 0 && vvendido <= vtestoque[indice])   // COMPROU DENTRO DO LIMITE DO ESTOQUE
                    {
                        vpagar = vvendido * vtvalor[indice];
                        Console.WriteLine("         Você confirma a compra no valor de R$ " + vpagar + " reais?");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("         Digite S(sim) ou N(nao).");
                        vconf = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine();

                        if (vconf == "S" || vconf == "s") // CONFIRMAÇÃO DA COMPRA ACIMA
                        {
                            vtcomprado[vcontador] = vtproduto[indice];    // SALVA O nome do produto
                            vtcompradovendido[vcontador] = vvendido;     // SALVA A quantidade do produto COMPARDO ACIMA


                            vcontador = vcontador + 1;  // SALVA A QUANTIDADE DE COMPRAS DE PRODUTOS DIFERENTES 
                            vtestoque[indice] = vtestoque[indice] - vvendido; // ATUALIZAÇÃO DO ESTOQUE 
                            vtotal = vtotal + vpagar;   // ATUALIZA E SALVA O VALOR DE CADA COMPRA FEITA ACIMA  


                            Console.WriteLine();
                            Console.WriteLine();

                            Console.Write("          " + vnome + ", nessa compra voce escolheu " + vvendido + " {0}, no valor de  R$ " + vpagar + " reais.", vtproduto[indice]);
                            Console.WriteLine();
                            Console.WriteLine();

                            Console.WriteLine("-----------------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();


                            Console.Write("         LINDA " + vnome + ", Digite S (sim) se você quer continuar comprando: ");
                            vcont = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();


                            if (vcont == "n" || vcont == "N")   // essa é a resposta final  NÃO QUER MAIS CONTINUAR COMPRANDO
                            {
                                vimposto = vpagar * 0.09;  //calculo do imposto
                                Console.Write("         Parabens  EMPODERADA " + vnome + " voce comprou:"); // " + vvendido + " {0}, e vai pagar  R$ " + vtotal + " reais.", vtproduto[indice]);
                                Console.WriteLine();
                                vcontadorcontando = 0;
                                while (vcontadorcontando <= vcontador - 1)  // esse laço lista todos os ítens comprados
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("         " + vtcomprado[vcontadorcontando] + " e " + vtcompradovendido[vcontadorcontando] + " peças.");
                                    vcontadorcontando = vcontadorcontando + 1; // ele sai do laço quando o consumidor para de comprar 
                                }
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("            Você pagará R$ " + vtotal + " reais, sendo R$ " + vimposto + " reais em impostos para o GOVERNO!!!!! ");
                            }
                            Console.WriteLine();        // fim do  segundo while 
                        }



                        if (vconf == "N" || vconf == "n") // não confirma a última compra feita 
                        {
                            Console.Write("         Compra cancelada. " + vnome + ", Digite S (sim) se você quer comprar outro produto: ");
                            vcont = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine();

                            if ((vcont == "n" || vcont == "N") && vcontador != 0)   //  não confirma a última compra e não quer continuar comprando
                                                                                    // MAS COMPROU ALGUMA COISA
                            {
                                vimposto = vpagar * 0.09;
                                vcontadorcontando = 0;
                                Console.Write("         Parabens  EMPODERADA " + vnome + " voce comprou:");
                                Console.WriteLine();

                                while (vcontadorcontando <= vcontador - 1) // LISTA OS ÍTENS COMPRADOS
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("          " + vtcomprado[vcontadorcontando] + " e " + vtcompradovendido[vcontadorcontando] + " peças.");
                                    vcontadorcontando = vcontadorcontando + 1;
                                } // saiu do segundo while



                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("            Você pagará R$ " + vtotal + " reais, sendo R$ " + vimposto + " reais em impostos para o GOVERNO!!!!! ");
                            }




                            if ((vcont == "n" || vcont == "N") && vcontador == 0)   //  ele fez apenas uma pesquisa de preço   NÃO COMPROU, MAS ESCOLHEU ALGUM PRODUTO
                            {
                                Console.WriteLine("         Obrigado pela pesquisa, estamos a sua disposição " + vnome);

                            }
                            Console.WriteLine();
                            Console.WriteLine();



                        }  // FIM DO SE : NÃO CONFIRMA A ULTIMA COMPRA FEITA
                    }  // FIM DO SE:  COMPRA DENTRO DO LIMITE DE ESTOQUE

                    if (vvendido > vtestoque[indice])  // TENTA COMPRAR ACIMA DA QUANTIDADE DISPONÍVEL
                    {
                        Console.WriteLine();
                        Console.WriteLine("         Nao temos mais " + vtproduto[indice] + " no estoque, temos apenas " + vtestoque[indice] + " unidades.");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("         Querida" + vnome + " escolha " + vtestoque[indice] + " unidades ou menos, mas continue em comprando!!");
                        Console.Write("         Digite S (sim) se você quer continuar comprando: ");
                        vcont = Console.ReadLine();
                    }

                } //   fim do if: confirmação de compra

            }   //  fim do if: gênero

            //     NOTA DE RODAPÉ AO FIM DA COMPRA
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ________      A ABS EYA ERO Agradece a Confiança    _______________");
            Console.WriteLine();
            // Comando para Segurar a tela ativa
            Console.ReadKey();


        }
    }
}