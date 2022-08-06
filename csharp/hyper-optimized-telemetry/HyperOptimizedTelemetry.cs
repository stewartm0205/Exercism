using System;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte[] buf = { 0xfc, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 };
        int i;
        byte[] nbuf = BitConverter.GetBytes(reading);
        for (i = 0; i < nbuf.Length; i++) buf[i + 1] = nbuf[i];
        return buf;
    }

    public static byte[] ToBuffer(UInt16 reading)
    {
        byte[] buf = { 0x2, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 };
        int i;
        byte[] nbuf = BitConverter.GetBytes(reading);
        for (i = 0; i < nbuf.Length; i++) buf[i + 1] = nbuf[i];
        return buf;

    }
    public static byte[] ToBuffer(Int16 reading)
    {
        byte[] buf = { 0x2, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 };
        int i;
        byte[] nbuf = BitConverter.GetBytes(reading);
        for (i = 0; i < nbuf.Length; i++) buf[i + 1] = nbuf[i];
        return buf;

    }
    public static byte[] ToBuffer(UInt32 reading)
    {
        byte[] buf = { 0x4, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 };
        int i;
        byte[] nbuf = BitConverter.GetBytes(reading);
        for (i = 0; i < nbuf.Length; i++) buf[i + 1] = nbuf[i];
        return buf;
    }
    public static byte[] ToBuffer(Int32 reading)
    {
        byte[] buf = { 0xfc, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 };
        int i;
        byte[] nbuf = BitConverter.GetBytes(reading);
        for (i = 0; i < nbuf.Length; i++) buf[i + 1] = nbuf[i];
        return buf;
    }
    public static long FromBuffer(byte[] buffer)
    {
        long blong = 0;
        int i;
        long mult = 1;
        for (i = 1; i <= 8; i++) {
            blong += (int) buffer[i] * mult;
            mult *= 256;
        }
        return blong;
    }
}
