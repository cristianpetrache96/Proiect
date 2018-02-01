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
        private ChessGameRulesManager _rulesManager;

        public ChessGame()
        {
            _chessBoard = new ChessBoard();
            _rulesManager = new ChessGameRulesManager(_chessBoard);
        }
        public ChessGame(User user1,User user2)
        {
            _gameTurn = Side.SideType.White;
            _chessBoard = new ChessBoard();
            _whitePlayer = (Player)user1;
            _blackPlayer = (Player)user2;
            _rulesManager = new ChessGameRulesManager(_chessBoard);
        }


        public Player WhitePlayer
        {
            get
            {
                return _whitePlayer;
            }
        }


        public Player BlackPlayer
        {
            get
            {
                return _blackPlayer;
            }
        }

        public Player CurrentPlayer
        {
            get
            {
                if (BlackTurn())
                    return _blackPlayer;
                else
                    return _whitePlayer;
            }
        }

        public bool BlackTurn()
        {
            return (_gameTurn == Side.SideType.Black);
        }

        public bool WhiteTurn()
        {
            return (_gameTurn == Side.SideType.White);
        }

        public ChessBoard Board
        {
            get
            {
                return _chessBoard;
            }
        }

        public ChessGameRulesManager RulesManager
        {
            get
            {
                return _rulesManager;
            }
        }
    }
}