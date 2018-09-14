namespace FactoryVsStrategy.Factory
{
    public class FileOutputFactory
    {
        public static IFileOutput GetMyFormatter(OutputFormat outputFormat)
        {
            switch (outputFormat)
            {
                case OutputFormat.EXCEL:
                    return new ExcelFileOutput();
                case OutputFormat.FLAT:
                    return new FlatFileOutput();
            }
            return null;
        }
    }

    public enum OutputFormat
    {
        EXCEL,
        FLAT
    }
}
