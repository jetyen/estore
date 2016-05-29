﻿using System.Collections.Generic;
using EStore.Storage;

namespace EStore.Storage
{
    public interface IChunkStatisticService
    {
        void AddFileReadCount(int chunkNum);
        void AddUnmanagedReadCount(int chunkNum);
        void AddCachedReadCount(int chunkNum);
        void AddWriteBytes(int chunkNum, int byteCount);
        void Start();
        void Shutdown();
    }
}
