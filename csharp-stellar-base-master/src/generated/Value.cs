          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Stellar.Generated
{


// === xdr source ============================================================
//  typedef opaque Value<>;
//  ===========================================================================
public class Value {
  public byte[] InnerValue { get; set; } = default(byte[]);
            
  public Value() { }
  public Value(byte[] Value)
  {
    InnerValue = Value;
  }
  public static void Encode(IByteWriter stream, Value  encodedValue) {
  int ValueSize = encodedValue.InnerValue.Length;
  XdrEncoding.EncodeInt32(ValueSize, stream);
  XdrEncoding.WriteFixOpaque(stream, (uint)ValueSize, encodedValue.InnerValue);
  }
  public static Value Decode(IByteReader stream) {
    Value decodedValue = new Value();
  int Valuesize = XdrEncoding.DecodeInt32(stream);
  decodedValue.InnerValue = XdrEncoding.ReadFixOpaque(stream, (uint)Valuesize);
    return decodedValue;
  }
}
}
