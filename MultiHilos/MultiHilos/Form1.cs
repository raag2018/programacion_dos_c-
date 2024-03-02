namespace MultiHilos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void mostrarAvanceProceso(int param)
        {
            pgrProceso.Value = param;
        }
        private async void btnProceso_Click(object sender, EventArgs e){
            // Iniciamos una tarea asincrónica
            Task<string> task = Task.Run(() => solicitud());
            // Actualizamos la etiqueta de inicio
            lblStart.Text = "Proceso iniciado";
            // Realizamos el proceso y actualizamos el progreso
            await Task.Run(() => {
                for (int indice = 0; indice <= 100; indice++){
                    // Simulamos un proceso con una espera de 100 ms
                    Thread.Sleep(100);
                    // Actualizamos el progreso
                    UpdateProgress(indice);
                }
            });
            // Esperamos a que la tarea termine y obtenemos el resultado
            string resultado = await task;
            // Actualizamos las etiquetas de estado
            lblStart.Text = "Proceso Finalizado";
            lblEnd.Text = "Terminado";
        }

        private void UpdateProgress(int value){
            if (pgrProceso.InvokeRequired){
                pgrProceso.Invoke((MethodInvoker)(() => pgrProceso.Value = value));
            }else{
                pgrProceso.Value = value;
            }

            if (lblEnd.InvokeRequired){
                lblEnd.Invoke((MethodInvoker)(() => lblEnd.Text = "Cargando " + value.ToString() + "%"));
            }else{
                lblEnd.Text = "Cargando " + value.ToString() + "%";
            }
        }
        private string solicitud()
        {
            Thread.Sleep(10000);
            return "Proceso Finalizado";
        }
    }
}
