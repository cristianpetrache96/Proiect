using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proiect_TP.Models
{
    public class ChessGame
    {
        private ChessBoard _chessBoard;
        private Side.SideType _gameTurn;
        private Player _whitePlayer;
        private Player _blackPlayer;

        public ChessGame(User user1,User user2)
        {
            _chessBoard = new ChessBoard();
            _whitePlayer = new Player(user1, new Side(Side.SideType.White));
            _blackPlayer = new Player(user2, new Side(Side.SideType.Black));
        }

    }
}