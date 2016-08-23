using System;
using System.Collections.Generic;
using System.Text;

namespace ExtProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crea la clase
            ProcessRunner pr = new ProcessRunner();
            pr.CommandLine = "write.exe";
            // Lanza el proceso, devuelve el Id del proceso
            int process_id = pr.Exec();
            // Comprueba si el proceso con el mismo Id se está ejecutando
            bool active = pr.IsRunning(process_id);
        }
    }
}
