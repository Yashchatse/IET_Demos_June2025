namespace _15Sessions.Helper
{
    public class Logger
    {
        private static Logger logger = new Logger();
        private Logger()
        {

        }

        public static Logger CurrentLogger { get { return logger; } }
        public void Log(string message)
        {
            string logFilePath = "D:\\Personal\\IETCDAC\\June25\\WebDemos\\MVCDemosJune25\\15Sessions\\Log\\Log.txt";
            FileStream fileStream = null;

            if (File.Exists(logFilePath))
            {
                fileStream = new FileStream(logFilePath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fileStream = new FileStream(logFilePath, FileMode.OpenOrCreate, FileAccess.Write);
            }

            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine(string.Format("Logged at {0}: {1}", DateTime.Now.ToString(), message));
            streamWriter.Close();
            fileStream.Close();

            streamWriter = null;
            fileStream = null;

        }
    }
}
