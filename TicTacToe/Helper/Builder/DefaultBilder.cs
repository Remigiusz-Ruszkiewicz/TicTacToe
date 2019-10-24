﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Helper.Builder
{
    public abstract class DefaultBilder : IBoardCreate
    {
        public List<Row> Rows { get; set; } = new List<Row>();
        readonly int rowCount ;
        public DefaultBilder(int rowCount)
        {
            this.rowCount = rowCount;
        }

        public void AddCells()
        {
            Rows.ForEach(r =>
            {
                List<Cell> cells = new List<Cell>();
                for (int i = 0; i < Rows.Count; i++)
                {
                    cells.Add(CreateCell(i, Rows[i]));
                }
                r.Cells = cells;
            });
        }

        public Cell CreateCell(int id, Row row)
        {
            return new Cell { Id = id, Row = row };
        }

        public Row CreateRow(int id)
        {
            return new Row { Id = id };
        }

        public void CreateRows()
        {
            for (int i = 0; i < rowCount; i++)
            {
                Rows.Add(CreateRow(i));
            }
        }
    }
}
