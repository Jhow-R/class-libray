using System;
using System.IO;

namespace FileIOLibrary
{
    public class FileIO
    {
        public string ReadLine(string filePath, int lineNumber)
        {
            return ReadSpecificLine(filePath, lineNumber);
        }

        private string ReadSpecificLine(string filePath, int lineNumber)
        {
            string content = null;

            try
            {
                /* StreamReader: pode ser usado para ler o conteúdo de um arquivo de texto. Possui métodos para ler caracteres individuais, ler até o final do arquivo e ler linhas individuais.
                 * 
                 */

                using (StreamReader inputFile = new StreamReader(filePath))
                {
                    // Pulando linhas até chegar na escolhida
                    for (int i = 1; i < lineNumber; i++)
                    {
                        // ReadLine (): lê uma única linha de um fluxo e retorna o conteúdo dessa linha como uma string. Especificamente, ele lê a linha correspondente à posição atual do ponteiro de fluxo.
                        inputFile.ReadLine();

                        if (inputFile.EndOfStream)
                        {
                            Console.WriteLine($"Fim. Arquivo contém somente {i} linhas.");
                            break;
                        }
                    }

                    // Linha especifica para leitura
                    content = inputFile.ReadLine();
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Erro ao ler o arquivo...");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO...\n" + ex.Message);
            }

            return content;
        }
    }
}
