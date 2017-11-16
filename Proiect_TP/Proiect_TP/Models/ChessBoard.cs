using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace Proiect_TP.Models
{
    public class ChessBoard
    {
        private Side _whiteSide;
        private Side _blackSide;
        private Hashtable _cells;

        public ChessBoard()
        {
            _cells = new Hashtable();
        }

        public void InitTable()
        {
            _cells.Clear();

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    AddCell(new Cell(row, col));
                }
            }
        }

        public void AddCell(Cell newCell)
        {
            _cells.Add(newCell.GetKey(), newCell);
        }

        public void RemoveCell(Cell cell)
        {
            if (_cells.Contains(cell))
            {
                _cells.Remove(cell);
            }
        }

        public void ClearTable()
        {
            _cells.Clear();
        }
    }
}