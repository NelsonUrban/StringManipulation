using NUnit.Framework;
using StringManipulation;
using System.Collections.Generic;

namespace StringManipulationTest
{
    public class StringManipulationTest
    {
        private List<string> inputStrings;
        private List<string> expectedOutput;

        [SetUp]
        public void Setup()
        {
            inputStrings = new List<string>();
            expectedOutput = new List<string>();
        }

        [Test]
        public void SortingOperations_ShouldReturnExpectedResult_When_sending_2_strings()
        {
            // Arrange
            inputStrings.Add("abaccadcc");
            inputStrings.Add("xyzxy");

            expectedOutput.Add("ccccaaabd");
            expectedOutput.Add("xxyyz");

            int numberOfStrings = inputStrings.Count;

            // Act
            List<string> actualOutput = Program.SortingOperations(inputStrings);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(numberOfStrings, Is.EqualTo(expectedOutput.Count));
                Assert.That(actualOutput.Count, Is.EqualTo(expectedOutput.Count));
            });
            CollectionAssert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void ShouldThrow_An_exception_when_the_list_is_Empty()
        {
            // Arrange
            List<string> lista = new();
            // Act y Assert
            Assert.Throws<Exception>(() => Program.SortingOperations(lista), "You should send a List of strings");
        }

        [Test]
        public void SortingOperations_ShouldReturnExpectedResult_When_sending_10_strings_with_10_letters()
        {
            // Arrange
            inputStrings.Add("dulgvgzwqg");
            inputStrings.Add("gxtjtmtywr");
            inputStrings.Add("hnlnxiupgt");
            inputStrings.Add("gzjotckivp");
            inputStrings.Add("dpwwsdptae");
            inputStrings.Add("pcscpilknb");
            inputStrings.Add("btvyhhmflf");
            inputStrings.Add("artrtnqxcr");
            inputStrings.Add("nrtcmcoadn");
            inputStrings.Add("fkdsgnekft");

            expectedOutput.Add("gggdlquvwz");
            expectedOutput.Add("tttgjmrwxy");
            expectedOutput.Add("nnghilptux");
            expectedOutput.Add("cgijkoptvz");
            expectedOutput.Add("ddppwwaest");
            expectedOutput.Add("ccppbiklns");
            expectedOutput.Add("ffhhblmtvy");
            expectedOutput.Add("rrrttacnqx");
            expectedOutput.Add("ccnnadmort");
            expectedOutput.Add("ffkkdegnst");

            int numberOfStrings = inputStrings.Count;

            // Act
            List<string> actualOutput = Program.SortingOperations(inputStrings);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(numberOfStrings, Is.EqualTo(expectedOutput.Count));
                Assert.That(actualOutput.Count, Is.EqualTo(expectedOutput.Count));
            });
            CollectionAssert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void SortingOperations_ShouldReturnExpectedResult_When_sending_10_strings_with_5_letters()
        {
            // Arrange
            inputStrings.Add("qakmc");
            inputStrings.Add("rrtbk");
            inputStrings.Add("vaixn");
            inputStrings.Add("wmpnj");
            inputStrings.Add("uproi");
            inputStrings.Add("btska");
            inputStrings.Add("ejqwr");
            inputStrings.Add("elwlg");
            inputStrings.Add("oaoiy");
            inputStrings.Add("hrqkn");

            expectedOutput.Add("ackmq");
            expectedOutput.Add("rrbkt");
            expectedOutput.Add("ainvx");
            expectedOutput.Add("jmnpw");
            expectedOutput.Add("iopru");
            expectedOutput.Add("abkst");
            expectedOutput.Add("ejqrw");
            expectedOutput.Add("llegw");
            expectedOutput.Add("ooaiy");
            expectedOutput.Add("hknqr");

            int numberOfStrings = inputStrings.Count;

            // Act
            List<string> actualOutput = Program.SortingOperations(inputStrings);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(numberOfStrings, Is.EqualTo(expectedOutput.Count));
                Assert.That(actualOutput.Count, Is.EqualTo(expectedOutput.Count));
            });
            CollectionAssert.AreEqual(expectedOutput, actualOutput);
        }
        [Test]
        public void SortingOperations_ShouldReturnExpectedResult_When_sending_5_strings_with_5_letters()
        {
            // Arrange
            inputStrings.Add("xqycs");
            inputStrings.Add("beoax");
            inputStrings.Add("afkso");
            inputStrings.Add("bldit");
            inputStrings.Add("gwrys");           

            expectedOutput.Add("cqsxy");
            expectedOutput.Add("abeox");
            expectedOutput.Add("afkos");
            expectedOutput.Add("bdilt");
            expectedOutput.Add("grswy");

            int numberOfStrings = inputStrings.Count;

            // Act
            List<string> actualOutput = Program.SortingOperations(inputStrings);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(numberOfStrings, Is.EqualTo(expectedOutput.Count));
                Assert.That(actualOutput.Count, Is.EqualTo(expectedOutput.Count));
            });
            CollectionAssert.AreEqual(expectedOutput, actualOutput);
        }
        [Test]
        public void SortingOperations_ShouldReturnExpectedResult_When_sending_5_strings_with_10_letters()
        {
            // Arrange          
            inputStrings.Add("wzenwebuau");
            inputStrings.Add("vokfxzynwl");
            inputStrings.Add("neldfeyrxk");
            inputStrings.Add("wqadfiodgs");
            inputStrings.Add("ykiuvzfcbc");

            expectedOutput.Add("eeuuwwabnz");
            expectedOutput.Add("fklnovwxyz");
            expectedOutput.Add("eedfklnrxy");
            expectedOutput.Add("ddafgioqsw");
            expectedOutput.Add("ccbfikuvyz");

            int numberOfStrings = inputStrings.Count;

            // Act
            List<string> actualOutput = Program.SortingOperations(inputStrings);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(numberOfStrings, Is.EqualTo(expectedOutput.Count));
                Assert.That(actualOutput.Count, Is.EqualTo(expectedOutput.Count));
            });
            CollectionAssert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void SortingOperations_ShouldReturnExpectedResult_When_sending_3_strings_with_5_letters()
        {
            // Arrange           
            inputStrings.Add("pzjim");
            inputStrings.Add("njnfq");
            inputStrings.Add("xyohs");

            expectedOutput.Add("ijmpz");
            expectedOutput.Add("nnfjq");
            expectedOutput.Add("hosxy");

            int numberOfStrings = inputStrings.Count;

            // Act
            List<string> actualOutput = Program.SortingOperations(inputStrings);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(numberOfStrings, Is.EqualTo(expectedOutput.Count));
                Assert.That(actualOutput.Count, Is.EqualTo(expectedOutput.Count));
            });
            CollectionAssert.AreEqual(expectedOutput, actualOutput);
        }
    }
}