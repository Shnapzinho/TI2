using System.Collections;

namespace TI2;

public class Cipher
{
    public BitArray PlainText { get; set; }
    public BitArray BitRegister { get; private set; }
    public BitArray BitKey { get; private set; }
    public BitArray CipherBit { get; private set; }

    public void ProcessBitRegister(string parsingStr)
    {
        BitRegister = new(parsingStr.Length);
        for (int i = 0; i < parsingStr.Length; i++)
            BitRegister[i] = parsingStr[i] == '1';
    }

    //x34 + x15 + x14 + x + 1
    public void GenerateBitKey(int length)
    {
        BitKey = new(length);
        int len = BitRegister.Length;
        for (int i = 0; i < length; i++)
        {
            BitKey[i] = BitRegister[0];
            bool nextValue = BitRegister[len - 34] ^ BitRegister[len - 15] ^ BitRegister[len - 14] ^ BitRegister[len - 1];
            for (int index = 0; index < len - 1; index++)
            {
                BitRegister[index] = BitRegister[index + 1];
            }
            BitRegister[len - 1] = nextValue;
        }
    }
    public void CipherAlg()
    {
        CipherBit = BitKey.Xor(PlainText);
    }
}
