          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Stellar.Generated
{


// === xdr source ============================================================
//  enum BucketEntryType
//  {
//      LIVEENTRY = 0,
//      DEADENTRY = 1
//  };
//  ===========================================================================
public class BucketEntryType {
  public enum BucketEntryTypeEnum
  {
  LIVEENTRY = 0,
  DEADENTRY = 1,
  }

  public BucketEntryTypeEnum InnerValue { get; set; } = default(BucketEntryTypeEnum);

  public static BucketEntryType Create(BucketEntryTypeEnum v)
  {
    return new BucketEntryType {
      InnerValue = v
    };
  }

  public static BucketEntryType Decode(IByteReader stream) {
    int value = XdrEncoding.DecodeInt32(stream);
    switch (value) {
      case 0: return Create(BucketEntryTypeEnum.LIVEENTRY);
      case 1: return Create(BucketEntryTypeEnum.DEADENTRY);
			default:
			  throw new System.Exception("Unknown enum value: " + value);
		  }
		}

		public static void Encode(IByteWriter stream, BucketEntryType value) {
		  XdrEncoding.EncodeInt32((int)value.InnerValue, stream);
		}
}
}
