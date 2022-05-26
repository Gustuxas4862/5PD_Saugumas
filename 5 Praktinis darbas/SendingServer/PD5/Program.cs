namespace PD5
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new DigitalSignaturePanel());
        }
    }
}