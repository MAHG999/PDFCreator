using NUnit.Framework;


namespace PrintTest
{
    public class Tests
    {
        

        [Test]
        public void Test1()
        {
            string[] Variable = new string[] { "HKB11B02", "0000000061405708", "21.56", "MXN", "25.01", "AAA010101AAA", "Tecnology advance", "XAXX010101000", "Luke Skywallker", "81112100", "E", "Credito", "Beneficio por cargo recurrente" };
            int counter = 0;
            string[] Result = ConsolePDFCreator.XMLReader.Reader(@"C:\Users\marco\source\repos\ConsolePDFCreator\bin\Debug\In\DocPrueba.xml");
            foreach (var itemValor in Result)
            {
                Assert.AreEqual(Variable[counter], itemValor);
                counter++;
            }
            
        }
    }
}