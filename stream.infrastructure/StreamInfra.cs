using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace stream.infrastructure
{
    /// <summary>
    /// reference:
    /// read bytes: http://www.yoda.arachsys.com/csharp/readbinary.html
    /// </summary>
    public class StreamInfra : IStreamInfra
    {
        public byte[] ReadBytes(Stream stream)
        {
            byte[] dataToRead = new byte[stream.Length];

            int offset = 0;
            int remaining = dataToRead.Length;

            while (remaining > 0)
            {
                int read = stream.Read(dataToRead, offset, remaining);
                if (read <= 0)
                {
                    throw new EndOfStreamException($"End of stream reached with {remaining} bytes left to read");
                }
                remaining -= read;
                offset += read;
            }

            return dataToRead;
        }

        public byte[] ReadFullyBytes(Stream stream, int initialLength)
        {
            if(initialLength < 1)
            {
                initialLength = 32768;
            }
            byte[] buffer = new byte[initialLength];
            int read = 0;

            int chunk;
            while((chunk = stream.Read(buffer, read, buffer.Length - read)) > 0)
            {
                read += chunk;

                if(read == buffer.Length)
                {
                    int nextByte = stream.ReadByte();
                    if(nextByte == -1)
                    {
                        return buffer;
                    }

                    byte[] newBuffer = new byte[buffer.Length * 2];
                    Array.Copy(buffer, newBuffer, buffer.Length);
                    newBuffer[read] = (byte)nextByte;
                    buffer = newBuffer;
                    read++;
                }
           
            }
            byte[] ret = new byte[read];
            Array.Copy(buffer, ret, read);
            return ret;
        }
 
    }
}
