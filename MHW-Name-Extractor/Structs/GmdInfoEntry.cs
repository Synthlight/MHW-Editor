namespace MHW_Name_Extractor.Structs {
    public struct GmdInfoEntry {
        uint string_index;
        int hash_key_2x; // signed_crc32(key_value + key_value)
        int hash_key_3x; // signed_crc32(key_value + key_value + key_value)
        uint pad; // always 0xCDCDCDCD
        ulong key_offset;
        ulong bucket_index;
    }
}