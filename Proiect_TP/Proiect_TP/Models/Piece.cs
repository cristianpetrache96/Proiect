using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proiect_TP.Models
{
    public  class Piece
    {
        Side _side;
        PieceType _type;
        public enum PieceType { Empty, King, Queen, Rook, Bishop, Knight, Pawn };
        int _numberOfMoves;
        string _imgPath;

        public Piece()
        {
            _side = null;
            _type = PieceType.Empty;
        
        }

        public Piece(Side side, PieceType type)
        {
            _type = type;
            _side = side;

            if(_side.SideTip == Side.SideType.White)
            switch(type)
            {
                    case PieceType.Rook:
                        _imgPath = "../../Images/white_rook.png";
                        break;
                    case PieceType.Pawn:
                        _imgPath = "../../Images/white_pawn.png";
                        break;
                    case PieceType.Bishop:
                        _imgPath = "../../Images/white_bishop.png";
                        break;
                    case PieceType.Queen:
                        _imgPath = "../../Images/white_queen.png";
                        break;
                    case PieceType.Knight:
                        _imgPath = "../../Images/white_knight.png";
                        break;
                    case PieceType.King:
                        _imgPath = "../../Images/white_king.png";
                        break;


                }
            else
            {
                switch (type)
                {
                    case PieceType.Rook:
                        _imgPath = "../Images/black_rook.png";
                        break;
                    case PieceType.Pawn:
                        _imgPath = "../Images/black_pawn.png";
                        break;
                    case PieceType.Bishop:
                        _imgPath = "../Images/black_bishop.png";
                        break;
                    case PieceType.Queen:
                        _imgPath = "../Images/black_queen.png";
                        break;
                    case PieceType.Knight:
                        _imgPath = "../Images/black_knight.png";
                        break;
                    case PieceType.King:
                        _imgPath = "../Images/black_king.png";
                        break;


                }
            }
        }

        public PieceType Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public Side Side
        {
            get
            {
                return _side;
            }
            set
            {
                _side = value;
            }
        }

        public string ImagePath
        {
            get
            {
                return _imgPath;
            }
            set
            {
                _imgPath = value;
            }
        }

        public int NumberOfMoves
        {
            get
            {
                return _numberOfMoves;
            }
            set
            {
                _numberOfMoves = value;
            }
        }
    }
}