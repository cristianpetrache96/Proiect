using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proiect_TP.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestChessGameInit()
        {
            User user1 = new User()
            {
                Name = "Catalin"
            };


            User user2 = new User()
            {
                Name = "Cristian"
            };

            ChessGame chessgame = new ChessGame(user1, user2);
        }
    }
}
