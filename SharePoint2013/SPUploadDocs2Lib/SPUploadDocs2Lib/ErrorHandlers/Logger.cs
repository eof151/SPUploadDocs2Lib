using System.Windows.Forms;

namespace SPUploadDocs2Lib.ErrorHandlers
{
    public class Logger
    {
        public static void LogError(string output)
        {
            MessageBox.Show(output, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void LogWarning(string output)
        {
            MessageBox.Show(output,"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void LogInformation(string output)
        {
            MessageBox.Show(output, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
