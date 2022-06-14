using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EncoraChallenge.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            string[] words = new string[]
            {
                "abaccadcc",
                "xyzxy"
            };

            // Act
            var result = Program.SortingOperations(words);

            // Assert
            string[] expectedResult = new string[]
            {
                "ccccaaabd",
                "xxyyz"
            };
            Assert.AreEqual(expectedResult.Length, result.Length);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], result[i]);
                Console.WriteLine(result[i]);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            string[] words = new string[]
            {
                "dulgvgzwqg",
                "gxtjtmtyrw",
                "hnlnxiupgt",
                "gzjotckivp",
                "dpwwsdptae",
                "pcscpilknb",
                "btvyhhmflf",
                "artrtnqxcr",
                "nrtcmcoadn",
                "fkdsgnekft"
            };

            // Act
            var result = Program.SortingOperations(words);

            // Assert
            string[] expectedResult = new string[]
            {
                "gggdlquvwz",
                "tttgjmrwxy",
                "nnghilptux",
                "cgijkoptvz",
                "ddppwwaest",
                "ccppbiklns",
                "ffhhblmtvy",
                "rrrttacnqx",
                "ccnnadmort",
                "ffkkdegnst"
            };
            Assert.AreEqual(expectedResult.Length, result.Length);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], result[i]);
                Console.WriteLine(result[i]);
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            string[] words = new string[]
            {
                "wzenwebuau",
                "vokfxzynwl",
                "neldfeyrxk",
                "wqadfiodgs",
                "ykiuvzfcbc"
            };

            // Act
            var result = Program.SortingOperations(words);

            // Assert
            string[] expectedResult = new string[]
            {
                "eeuuwwabnz",
                "fklnovwxyz",
                "eedfklnrxy",
                "ddafgioqsw",
                "ccbfikuvyz"
            };
            Assert.AreEqual(expectedResult.Length, result.Length);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], result[i]);
                Console.WriteLine(result[i]);
            }
        }

        [TestMethod]
        public void TestMethod4()
        {
            // Arrange
            string[] words = new string[]
            {
                "qakmc",
                "rrtbk",
                "vaixn",
                "wmpnj",
                "uproi",
                "btska",
                "ejqwr",
                "elwlg",
                "oaoiy",
                "hrqkn"
            };

            // Act
            var result = Program.SortingOperations(words);

            // Assert
            string[] expectedResult = new string[]
            {
                "ackmq",
                "rrbkt",
                "ainvx",
                "jmnpw",
                "iopru",
                "abkst",
                "ejqrw",
                "llegw",
                "ooaiy",
                "hknqr"
            };
            Assert.AreEqual(expectedResult.Length, result.Length);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], result[i]);
                Console.WriteLine(result[i]);
            }
        }

        [TestMethod]
        public void TestMethod5()
        {
            // Arrange
            string[] words = new string[]
            {
                "pzjim",
                "njnfq",
                "xyohs",
            };

            // Act
            var result = Program.SortingOperations(words);

            // Assert
            string[] expectedResult = new string[]
            {
                "ijmpz",
                "nnfjq",
                "hosxy"
            };
            Assert.AreEqual(expectedResult.Length, result.Length);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], result[i]);
                Console.WriteLine(result[i]);
            }
        }

        [TestMethod]
        public void TestMethod6()
        {
            // Arrange
            string[] words = new string[]
            {
                "xqycs",
                "beoax",
                "afkso",
                "bldit",
                "gwrys",
            };

            // Act
            var result = Program.SortingOperations(words);

            // Assert
            string[] expectedResult = new string[]
            {
                "cqsxy",
                "abeox",
                "afkos",
                "bdilt",
                "grswy"
            };
            Assert.AreEqual(expectedResult.Length, result.Length);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], result[i]);
                Console.WriteLine(result[i]);
            }
        }
    }
}
