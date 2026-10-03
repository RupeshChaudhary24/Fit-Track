namespace FitTrack
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Forms.MainForm mainForm;

            try
            {
                mainForm = new Forms.MainForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "FitTrack could not open safely, so it will close without replacing your saved goals.\n\n" +
                    "Details: " + ex.Message + "\n\n" +
                    "Check goals.json and its backup before trying again.",
                    "FitTrack Startup Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            Application.Run(mainForm);
        }
    }
}