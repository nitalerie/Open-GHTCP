namespace GHNamespaceF
{
    public class TextureMetadata
    {
        public short UnkFlags; // Only used on loading and saving. Value of 0x200 (512) for green note

        public int Key; // Only used on loading and saving. Value of 0x151ee874 for green note

        public short Width;

        public short Height;

        public short UnkShort3; // Only used on loading and saving. Value of 0x01 for green note. Maybe number of frames?

        public byte MipMapCount;

        public short UnkShort4; // Only used on loading and saving. Value of 0x0805 for green note

        public int StartIndex;

        public int Length; //Probably

        public byte[] Data;

        public TextureMetadata(short unkFlags, int key, short width, short height, short unkShort3, byte mipMapCount,
            short unkShort4, int startIndex, int length)
        {
            UnkFlags = unkFlags;
            Key = key;
            Width = width;
            Height = height;
            UnkShort3 = unkShort3;
            MipMapCount = mipMapCount;
            UnkShort4 = unkShort4;
            StartIndex = startIndex;
            Length = length;
        }
    }
}