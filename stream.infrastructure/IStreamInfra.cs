using System;
using System.IO;

namespace stream.infrastructure
{
   public interface IStreamInfra
    {
        byte[] ReadBytes(Stream stream);
        byte[] ReadFullyBytes(Stream stream, int initialLength);
    }
}
