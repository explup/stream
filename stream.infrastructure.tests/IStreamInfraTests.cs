using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace stream.infrastructure.tests
{
    [TestClass]
    public class IStreamInfraTests
    {
        [TestMethod]
        public void ReadBytes_MemoryStream_Test()
        {
            string str = "0123456789";
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < 1; i++)
            {
                stringBuilder.Append(str);
            }

            byte[] bytes = Encoding.UTF8.GetBytes(stringBuilder.ToString());
            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                System.Math.Pow(2, 10);
                IStreamInfra streamInfra = new StreamInfra();
                streamInfra.ReadBytes(memoryStream);
            }

        }

        [TestMethod]
        public void ReadFullyBytes_MemoryStream_Test()
        {
            string str = "0123456789";
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < 1; i++)
            {
                stringBuilder.Append(str);
            }

            byte[] bytes = Encoding.UTF8.GetBytes(stringBuilder.ToString());
            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                System.Math.Pow(2, 10);
                IStreamInfra streamInfra = new StreamInfra();
                streamInfra.ReadFullyBytes(memoryStream,0);
            }

        }
    }
}
