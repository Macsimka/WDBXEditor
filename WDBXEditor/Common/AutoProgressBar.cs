using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WDBXEditor.Common
{
    internal class AutoProgressBar : ProgressBar
    {
        private BackgroundWorker bgw = new BackgroundWorker();

        public void Start(int increment = 3)
        {
            if (bgw.IsBusy) return;

            Style = ProgressBarStyle.Continuous;
            Value = 0;
            bgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
            bgw.ProgressChanged += new ProgressChangedEventHandler(bgw_ProgressChanged);
            bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_RunWorkerCompleted);
            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;
            bgw.RunWorkerAsync(increment);
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            int inc = (int)e.Argument;
            int i = 0;

            while (!bgw.CancellationPending)
            {
                System.Threading.Thread.Sleep(250);
                int percent = i;

                if (percent > 100)
                {
                    percent = 100;
                    i = 0;
                }
                else
                    i += inc;

                bgw.ReportProgress(percent);
            }
        }

        private void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!bgw.CancellationPending)
                Invoke((MethodInvoker)delegate { Value = e.ProgressPercentage; });
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Task.Run(() => ClearValue());
        }

        public void Stop(bool clear = true)
        {
            if (bgw.IsBusy)
                bgw.CancelAsync();

            if (clear)
                Task.Run(() => ClearValue());
        }

        private async Task ClearValue()
        {
            await Task.Factory.StartNew(() =>
            {
                while (bgw.CancellationPending || Value != 0)
                {
                    Invoke((MethodInvoker)delegate { Value = 0; });
                    Task.Delay(50).Wait();
                }
            });
        }
    }
}
