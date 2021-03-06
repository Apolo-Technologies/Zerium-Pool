﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeriumPool
{
    public class PoolBlock
    {
        public byte[] BlockData { get; set; }
        public int BlockHeight { get; set; }
        public string BlockHash { get; set; }
        public string Founder { get; set; }

        public PoolBlock(byte[] blockData, int blockHeight, string blockHash,string founder)
        {
            BlockData = blockData;
            BlockHash = blockHash;
            BlockHeight = blockHeight;
            Founder = founder;
        }
    }
}
